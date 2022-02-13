using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LocalNetworkChecker
{
    /// <summary>
    /// メイン画面フォームクラス
    /// </summary>
    public partial class Form1 : Form
    {
        #region フィールド変数

        /// <summary>ネットワークアダプタ・IPアドレスの情報</summary>
        private NetworkAdapter[] ifs;

        /// <summary>PING送信処理オブジェクトリスト</summary>
        private List<Pinger> pingerList;

        /// <summary>PING未完了件数</summary>
        private int count = 0;

        #endregion

        #region 初期処理

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// 初期処理
        /// </summary>
        private void Init()
        {
            ifs = NetworkUtil.GetNetworkInterfaces(true, true, true);
            cmbMyAddress.Items.AddRange(GetNetworkInterfaceItems());
            if (cmbMyAddress.Items.Count > 0) cmbMyAddress.SelectedIndex = 0;
            SetTargetAddress();
            txtTargetAddress.Select();
        }

        /// <summary>
        /// ネットワークアダプタ情報取得
        /// </summary>
        /// <returns>ネットワークアダプタ情報群</returns>
        private string[] GetNetworkInterfaceItems()
        {
            var list = new List<string>();
            foreach(NetworkAdapter item in ifs)
            {
                list.Add(item.ToString());
            }
            return list.ToArray();
        }

        /// <summary>
        /// チェック対象アドレス設定
        /// </summary>
        private void SetTargetAddress()
        {
            var myAddress = ifs[cmbMyAddress.SelectedIndex].IPAddress;
            var targetAddress = GetTargetAddress(myAddress);
            txtTargetAddress.Text = targetAddress;
            txtTargetAddress.Select(targetAddress.Length, 0);
        }

        /// <summary>
        /// チェック対象アドレス取得
        /// </summary>
        /// <param name="address">指定されたIPアドレス</param>
        /// <returns>チェック対象アドレス</returns>
        public string GetTargetAddress(string address)
        {
            if (string.IsNullOrEmpty(address)) return address;
            var idx = address.LastIndexOf(".");
            return address.Substring(0, idx) + ".*";
        }

        private void cmbMyAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetTargetAddress();
        }

        #endregion

        #region 実行

        /// <summary>
        /// 実行ボタン押下時処理
        /// </summary>
        /// <param name="sender">イベント発生オブジェクト</param>
        /// <param name="e">イベント引数</param>
        private void btnRun_Click(object sender, EventArgs e)
        {
            pnlControlPanel.Enabled = false;
            dataGridView1.Rows.Clear();

            var targetAddress = txtTargetAddress.Text.Trim();
            var from = decimal.ToInt32(numStart.Value);
            var to = decimal.ToInt32(numEnd.Value);
            var timeoutMS = decimal.ToInt32(numTimeoutMS.Value);

            PreparePing(targetAddress, from, to, timeoutMS);
            ShowPingInfo();
            DoPing();
        }

        /// <summary>
        /// PING送信オブジェクトの準備
        /// </summary>
        /// <param name="targetAddress">チェック対象アドレス</param>
        /// <param name="from">第4オクテットFrom</param>
        /// <param name="to">第4オクテットTo</param>
        /// <param name="timeoutMS">タイムアウト時間(ミリ秒)</param>
        private void PreparePing(string targetAddress, int from, int to, int timeoutMS)
        {
            Pinger.OnResultProcess = OnResult2;
            pingerList = new List<Pinger>();
            for (int i = from; i <= to; i++)
            {
                var address = targetAddress.Replace("*", i.ToString());
                Pinger pinger = new Pinger(i - from, address, timeoutMS);
                pingerList.Add(pinger);
            }
            Application.DoEvents();
            count = pingerList.Count;
        }

        /// <summary>
        /// PING送信状況リストの表示
        /// </summary>
        private void ShowPingInfo()
        {
            foreach (Pinger pinger in pingerList)
            {
                int index = dataGridView1.Rows.Add(pinger.Address, "", "", "");
                dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.LightCyan;
            }
        }

        /// <summary>
        /// PING送信実行
        /// </summary>
        private void DoPing()
        {
            foreach (Pinger pinger in pingerList)
            {
                pinger.Execute();
            }
        }

        /// <summary>
        /// PING結果反映処理
        /// </summary>
        /// <param name="result">PING結果</param>
        /// <param name="index">インデックス</param>
        private void OnResult2(Pinger pinger, PingResult result)
        {
            var index = pinger.Index;
            var status = result.Reply != null ? result.Reply.Status.ToString() : result.Message;
            dataGridView1.Rows[index].Cells[0].Value = result.Address;
            dataGridView1.Rows[index].Cells[1].Value = result.Success ? "○" : "×";
            dataGridView1.Rows[index].Cells[2].Value = result.MacAddress;
            dataGridView1.Rows[index].Cells[3].Value = status == "11050" ? "General failure" : status;
            dataGridView1.Rows[index].DefaultCellStyle.BackColor = result.Success ? Color.White : Color.Gray;
            count--;
            if (count == 0)
            {
                pnlControlPanel.Enabled = true;
                pingerList.Clear();
                GC.Collect();
            }
        }

        #endregion

        #region 設定変更

        /// <summary>
        /// 変更ボタン押下時処理
        /// </summary>
        /// <param name="sender">イベント発生オブジェクト</param>
        /// <param name="e">イベント引数</param>
        private void btnAdjust_Click(object sender, EventArgs e)
        {
            numStart.ReadOnly = false;
            numEnd.ReadOnly = false;
            numTimeoutMS.ReadOnly = false;
            btnAdjust.Enabled = false;
        }

        /// <summary>
        /// 第4オクテットTo欄ダブルクリック時処理
        /// </summary>
        /// <param name="sender">イベント発生オブジェクト</param>
        /// <param name="e">イベント引数</param>
        private void numEnd_DoubleClick(object sender, EventArgs e)
        {
            numEnd.Value = 10;
        }

        #endregion
    }
}
