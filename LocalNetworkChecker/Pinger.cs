using System;
using System.Net.NetworkInformation;
using System.Text;

namespace LocalNetworkChecker
{
    /// <summary>
    /// PING送信処理オブジェクト
    /// </summary>
    class Pinger
    {
        /// <summary>PING結果表示処理デリゲート</summary>
        public delegate void OnResult(Pinger pinger, PingResult result);

        /// <summary>PING結果表示処理</summary>
        public static OnResult OnResultProcess { get; set; }

        /// <summary>インデックス</summary>
        public int Index { get; set; }

        /// <summary>PING送信先IPアドレス</summary>
        public string Address { get; set; }

        /// <summary>タイムアウト時間(ミリ秒)</summary>
        public int TimeoutMS { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="index">インデックス</param>
        /// <param name="address">PING送信先IPアドレス</param>
        /// <param name="timeout">タイムアウト時間(ミリ秒)</param>
        public Pinger(int index, string address, int timeout)
        {
            Index = index;
            Address = address;
            TimeoutMS = timeout;
        }

        /// <summary>
        /// PING送信実行
        /// </summary>
        public void Execute()
        {
            Ping pingSender = new Ping();
            pingSender.PingCompleted += new PingCompletedEventHandler(PingCompletedCallback);

            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);

            PingOptions options = new PingOptions(64, true);

            pingSender.SendAsync(this.Address, TimeoutMS, buffer, options, null);
        }

        /// <summary>
        /// PING完了時処理
        /// </summary>
        /// <param name="sender">イベント発生オブジェクト</param>
        /// <param name="e">イベント引数</param>
        private void PingCompletedCallback(object sender, PingCompletedEventArgs e)
        {
            PingResult result;

            if (e.Cancelled)
            {
                result = new PingResult(Address, "Ping canceled.");
            }
            else if (e.Error != null)
            {
                result = new PingResult(Address, "Ping failed: " + e.Error.ToString());
            }
            else
            {
                result = new PingResult(Address, e.Reply);
                if (result.Success)
                {
                    result.MacAddress = NetworkUtil.GetMacAddress(Address);
                }
            }

            OnResultProcess?.Invoke(this, result);
        }
    }
}
