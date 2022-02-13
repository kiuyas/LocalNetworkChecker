using System.Net.NetworkInformation;

namespace LocalNetworkChecker
{
    /// <summary>
    /// PING送信結果保持クラス
    /// </summary>
    class PingResult
    {
        /// <summary>PING応答情報</summary>
        public PingReply Reply { get; set; }
        /// <summary></summary>

        /// <summary>PING送信先IPアドレス</summary>
        public string Address { get; set; }

        /// <summary>PING成否</summary>
        public bool Success { get; set; }

        /// <summary>MACアドレス</summary>
        public string MacAddress { get; set; }

        /// <summary>メッセージ</summary>
        public string Message { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="address">PING送信先IPアドレス</param>
        /// <param name="reply">PING応答情報</param>
        public PingResult(string address, PingReply reply)
        {
            Reply = reply;
            Address = address;
            Success = reply.Status == IPStatus.Success;
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="address">PING送信先IPアドレス</param>
        /// <param name="message">メッセージ</param>
        public PingResult(string address, string message)
        {
            Address = address;
            Message = message;
            Success = false;
        }
    }
}
