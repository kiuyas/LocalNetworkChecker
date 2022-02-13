using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace LocalNetworkChecker
{
    /// <summary>
    /// ネットワークユーティリティクラス
    /// </summary>
    class NetworkUtil
    {
        #region ネットワークインタフェース情報取得

        // 参考
        //https://www.delftstack.com/ja/howto/csharp/get-local-ip-address-in-csharp/

        /// <summary>
        /// ネットワークインタフェース情報取得
        /// </summary>
        /// <param name="getIpaddress">IPアドレスを取得するか</param>
        /// <param name="eliminateLoopback">ループバックインターフェースを除外するか</param>
        /// <param name="eliminateDown">起動していないインタフェースを除外するか</param>
        /// <returns></returns>
        public static NetworkAdapter[] GetNetworkInterfaces(bool getIpaddress, bool eliminateLoopback, bool eliminateDown)
        {
            var list = new List<NetworkAdapter>();
            var interfaces = NetworkInterface.GetAllNetworkInterfaces();

            for (int i = 0; i < interfaces.Length; i++)
            {
                var item = interfaces[i];
                var ipAddress = getIpaddress ? GetIPAddressOfAdapter(item) : null;
                var effective = IsEffective(item);
                if (eliminateLoopback && !effective) continue;
                if (eliminateDown && item.OperationalStatus != OperationalStatus.Up) continue;
                list.Add(new NetworkAdapter(item, ipAddress, effective));
            }

            return list.ToArray();
        }

        /// <summary>
        /// 指定されたネットワークインタフェースに対応するIPアドレスを取得する
        /// </summary>
        /// <param name="item">ネットワークインタフェース情報</param>
        /// <returns>IPアドレス</returns>
        private static string GetIPAddressOfAdapter(NetworkInterface item)
        {
            var ipAddress = "";
            foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
            {
                if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                {
                    ipAddress = ip.Address.ToString();
                }
            }
            return ipAddress;
        }

        /// <summary>
        /// ネットワークインタフェースが有効かチェックする
        /// </summary>
        /// <param name="adapter">ネットワークインタフェース</param>
        /// <returns></returns>
        private static bool IsEffective(NetworkInterface adapter)
        {
            return adapter.NetworkInterfaceType != NetworkInterfaceType.Unknown
                && adapter.NetworkInterfaceType != NetworkInterfaceType.Loopback;
        }

        #endregion

        #region ARP情報取得

        // 参考
        //https://hensa40.cutegirl.jp/archives/6689

        [DllImport("iphlpapi.dll", ExactSpelling = true)]

        private static extern int SendARP(int DestIP, int SrcIp, byte[] pMacAddr, ref int PhyAddrLen);

        /// <summary>
        /// 指定されたIPアドレスに対応するマックアドレスをARPテーブルから取得する
        /// </summary>
        /// <param name="dstIpAddr"> MACアドレスを取得するリモートPCのIPアドレス</param>
        public static string GetMacAddress(string dstIpAddr)
        {
            if (dstIpAddr == "0.0.0.0") return null;

             IPAddress dest = IPAddress.Parse(dstIpAddr);

            int destAddr = BitConverter.ToInt32(dest.GetAddressBytes(), 0);

            byte[] pMacAddr = new byte[6];
            int PhyAddrLen = pMacAddr.Length;

            string result;

            int ret = SendARP(destAddr, 0, pMacAddr, ref PhyAddrLen);
            if (ret == 0)
            {
                result = GenerateMACAddress(pMacAddr);
            }
            else
            {
                result = ret.ToString();
            }

            return result;
        }

        /// <summary>
        /// MACアドレス情報を文字列化する
        /// </summary>
        /// <param name="pMacAddr">MACアドレス情報</param>
        /// <returns>MACアドレス文字列</returns>
        public static string GenerateMACAddress(byte[] pMacAddr)
        {
            return string.Format("{0:x2}-{1:x2}-{2:x2}-{3:x2}-{4:x2}-{5:x2}", pMacAddr[0],
                                                                                               pMacAddr[1],
                                                                                               pMacAddr[2],
                                                                                               pMacAddr[3],
                                                                                               pMacAddr[4],
                                                                                               pMacAddr[5]).ToUpper();
        }

        #endregion
    }
}

