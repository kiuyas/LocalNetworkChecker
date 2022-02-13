namespace LocalNetworkChecker
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTargetAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColIPAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMACAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMemo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbMyAddress = new System.Windows.Forms.ComboBox();
            this.numStart = new System.Windows.Forms.NumericUpDown();
            this.numEnd = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdjust = new System.Windows.Forms.Button();
            this.pnlControlPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numTimeoutMS = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEnd)).BeginInit();
            this.pnlControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeoutMS)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTargetAddress
            // 
            this.txtTargetAddress.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTargetAddress.Location = new System.Drawing.Point(232, 40);
            this.txtTargetAddress.Name = "txtTargetAddress";
            this.txtTargetAddress.ReadOnly = true;
            this.txtTargetAddress.Size = new System.Drawing.Size(183, 28);
            this.txtTargetAddress.TabIndex = 1;
            this.txtTargetAddress.Text = "000.000.000.*";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(0, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "このPCのアドレス";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(0, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "チェック対象アドレス";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnRun.Location = new System.Drawing.Point(808, 8);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(112, 32);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "実行(F5)";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIPAddress,
            this.ColPing,
            this.ColMACAddress,
            this.ColMemo});
            this.dataGridView1.Location = new System.Drawing.Point(8, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(920, 408);
            this.dataGridView1.TabIndex = 5;
            // 
            // ColIPAddress
            // 
            this.ColIPAddress.HeaderText = "IPv4アドレス";
            this.ColIPAddress.Name = "ColIPAddress";
            this.ColIPAddress.ReadOnly = true;
            this.ColIPAddress.Width = 150;
            // 
            // ColPing
            // 
            this.ColPing.HeaderText = "Ping";
            this.ColPing.Name = "ColPing";
            this.ColPing.ReadOnly = true;
            // 
            // ColMACAddress
            // 
            this.ColMACAddress.HeaderText = "MACアドレス";
            this.ColMACAddress.Name = "ColMACAddress";
            this.ColMACAddress.ReadOnly = true;
            this.ColMACAddress.Width = 200;
            // 
            // ColMemo
            // 
            this.ColMemo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColMemo.HeaderText = "備考";
            this.ColMemo.Name = "ColMemo";
            this.ColMemo.ReadOnly = true;
            // 
            // cmbMyAddress
            // 
            this.cmbMyAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMyAddress.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbMyAddress.FormattingEnabled = true;
            this.cmbMyAddress.Location = new System.Drawing.Point(232, 8);
            this.cmbMyAddress.Name = "cmbMyAddress";
            this.cmbMyAddress.Size = new System.Drawing.Size(568, 29);
            this.cmbMyAddress.TabIndex = 6;
            this.cmbMyAddress.SelectedIndexChanged += new System.EventHandler(this.cmbMyAddress_SelectedIndexChanged);
            // 
            // numStart
            // 
            this.numStart.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numStart.Location = new System.Drawing.Point(424, 40);
            this.numStart.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numStart.Name = "numStart";
            this.numStart.ReadOnly = true;
            this.numStart.Size = new System.Drawing.Size(64, 28);
            this.numStart.TabIndex = 7;
            this.numStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numEnd
            // 
            this.numEnd.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numEnd.Location = new System.Drawing.Point(512, 40);
            this.numEnd.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numEnd.Name = "numEnd";
            this.numEnd.ReadOnly = true;
            this.numEnd.Size = new System.Drawing.Size(64, 28);
            this.numEnd.TabIndex = 8;
            this.numEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numEnd.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numEnd.DoubleClick += new System.EventHandler(this.numEnd_DoubleClick);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(488, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "-";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdjust
            // 
            this.btnAdjust.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAdjust.Location = new System.Drawing.Point(832, 40);
            this.btnAdjust.Name = "btnAdjust";
            this.btnAdjust.Size = new System.Drawing.Size(88, 32);
            this.btnAdjust.TabIndex = 10;
            this.btnAdjust.Text = "変更";
            this.btnAdjust.UseVisualStyleBackColor = true;
            this.btnAdjust.Click += new System.EventHandler(this.btnAdjust_Click);
            // 
            // pnlControlPanel
            // 
            this.pnlControlPanel.Controls.Add(this.label5);
            this.pnlControlPanel.Controls.Add(this.label4);
            this.pnlControlPanel.Controls.Add(this.numTimeoutMS);
            this.pnlControlPanel.Controls.Add(this.btnAdjust);
            this.pnlControlPanel.Controls.Add(this.label3);
            this.pnlControlPanel.Controls.Add(this.numEnd);
            this.pnlControlPanel.Controls.Add(this.numStart);
            this.pnlControlPanel.Controls.Add(this.cmbMyAddress);
            this.pnlControlPanel.Controls.Add(this.btnRun);
            this.pnlControlPanel.Controls.Add(this.label2);
            this.pnlControlPanel.Controls.Add(this.label1);
            this.pnlControlPanel.Controls.Add(this.txtTargetAddress);
            this.pnlControlPanel.Location = new System.Drawing.Point(8, 0);
            this.pnlControlPanel.Name = "pnlControlPanel";
            this.pnlControlPanel.Size = new System.Drawing.Size(920, 72);
            this.pnlControlPanel.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(800, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "ms";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(576, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "ﾀｲﾑｱｳﾄ時間";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numTimeoutMS
            // 
            this.numTimeoutMS.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numTimeoutMS.Location = new System.Drawing.Point(696, 40);
            this.numTimeoutMS.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numTimeoutMS.Name = "numTimeoutMS";
            this.numTimeoutMS.ReadOnly = true;
            this.numTimeoutMS.Size = new System.Drawing.Size(104, 28);
            this.numTimeoutMS.TabIndex = 11;
            this.numTimeoutMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numTimeoutMS.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 488);
            this.Controls.Add(this.pnlControlPanel);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "Form1";
            this.Text = "ローカルネットワークチェッカー";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEnd)).EndInit();
            this.pnlControlPanel.ResumeLayout(false);
            this.pnlControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeoutMS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtTargetAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIPAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPing;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMACAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMemo;
        private System.Windows.Forms.ComboBox cmbMyAddress;
        private System.Windows.Forms.NumericUpDown numStart;
        private System.Windows.Forms.NumericUpDown numEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdjust;
        private System.Windows.Forms.Panel pnlControlPanel;
        private System.Windows.Forms.NumericUpDown numTimeoutMS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

