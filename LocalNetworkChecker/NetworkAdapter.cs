using System.Net.NetworkInformation;

namespace LocalNetworkChecker
{
    /// <summary>
    /// ネットワークアダプタ情報保持クラス
    /// </summary>
    class NetworkAdapter
    {
        /// <summary>ネットワークアダプタ情報</summary>
        public NetworkInterface Adapter { get; set; }

        /// <summary>IPアドレス</summary>
        public string IPAddress { get; set; }

        /// <summary>有効か</summary>
        public bool Effective { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="adapter">ネットワークアダプタ情報</param>
        /// <param name="ipAddress">IPアドレス</param>
        /// <param name="effective">有効か</param>
        public NetworkAdapter(NetworkInterface adapter, string ipAddress, bool effective)
        {
            Adapter = adapter;
            IPAddress = ipAddress;
            Effective = effective;
        }

        /// <summary>
        /// 文字列表現の取得
        /// </summary>
        /// <returns>文字列表現</returns>
        public new string ToString()
        {
            return string.Format("{0} [{1}] ({2},{3})",
                IPAddress,
                Adapter.Name,
                Adapter.NetworkInterfaceType.ToString(),
                Adapter.GetPhysicalAddress().ToString()
            );
        }
    }
}
