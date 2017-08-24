namespace BitcoinTrader
{
    partial class BitTrex
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetMarketSummary = new System.Windows.Forms.Button();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.txbBitcoinName = new System.Windows.Forms.TextBox();
            this.lblHigh = new System.Windows.Forms.Label();
            this.lblHighData = new System.Windows.Forms.Label();
            this.lblLow = new System.Windows.Forms.Label();
            this.lblLowData = new System.Windows.Forms.Label();
            this.lblAsk = new System.Windows.Forms.Label();
            this.lblAskData = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCoinNameBuy = new System.Windows.Forms.Label();
            this.lblCoinNameSell = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUnitBuy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBuy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbPriceBuy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalBuy = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUnitSell = new System.Windows.Forms.TextBox();
            this.lblUnitSell = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbSell = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotalSell = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetMarketSummary
            // 
            this.btnGetMarketSummary.Location = new System.Drawing.Point(130, 22);
            this.btnGetMarketSummary.Name = "btnGetMarketSummary";
            this.btnGetMarketSummary.Size = new System.Drawing.Size(76, 23);
            this.btnGetMarketSummary.TabIndex = 0;
            this.btnGetMarketSummary.Text = "Search";
            this.btnGetMarketSummary.UseVisualStyleBackColor = true;
            this.btnGetMarketSummary.Click += new System.EventHandler(this.btnGetMarketSummary_Click);
            // 
            // txbResult
            // 
            this.txbResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbResult.Location = new System.Drawing.Point(12, 323);
            this.txbResult.Multiline = true;
            this.txbResult.Name = "txbResult";
            this.txbResult.Size = new System.Drawing.Size(633, 111);
            this.txbResult.TabIndex = 1;
            // 
            // txbBitcoinName
            // 
            this.txbBitcoinName.Location = new System.Drawing.Point(6, 22);
            this.txbBitcoinName.Name = "txbBitcoinName";
            this.txbBitcoinName.Size = new System.Drawing.Size(116, 20);
            this.txbBitcoinName.TabIndex = 2;
            this.txbBitcoinName.Text = "BTC-LTC";
            // 
            // lblHigh
            // 
            this.lblHigh.AutoSize = true;
            this.lblHigh.Location = new System.Drawing.Point(427, 31);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(44, 13);
            this.lblHigh.TabIndex = 3;
            this.lblHigh.Text = "24 High";
            // 
            // lblHighData
            // 
            this.lblHighData.AutoSize = true;
            this.lblHighData.Location = new System.Drawing.Point(502, 31);
            this.lblHighData.Name = "lblHighData";
            this.lblHighData.Size = new System.Drawing.Size(97, 13);
            this.lblHighData.TabIndex = 4;
            this.lblHighData.Text = "xxxxxxxxxxxxxxxxxx";
            // 
            // lblLow
            // 
            this.lblLow.AutoSize = true;
            this.lblLow.Location = new System.Drawing.Point(430, 61);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(42, 13);
            this.lblLow.TabIndex = 5;
            this.lblLow.Text = "24 Low";
            // 
            // lblLowData
            // 
            this.lblLowData.AutoSize = true;
            this.lblLowData.Location = new System.Drawing.Point(502, 60);
            this.lblLowData.Name = "lblLowData";
            this.lblLowData.Size = new System.Drawing.Size(92, 13);
            this.lblLowData.TabIndex = 6;
            this.lblLowData.Text = "xxxxxxxxxxxxxxxxx";
            // 
            // lblAsk
            // 
            this.lblAsk.AutoSize = true;
            this.lblAsk.Location = new System.Drawing.Point(446, 92);
            this.lblAsk.Name = "lblAsk";
            this.lblAsk.Size = new System.Drawing.Size(25, 13);
            this.lblAsk.TabIndex = 7;
            this.lblAsk.Text = "Ask";
            this.lblAsk.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAskData
            // 
            this.lblAskData.AutoSize = true;
            this.lblAskData.Location = new System.Drawing.Point(504, 92);
            this.lblAskData.Name = "lblAskData";
            this.lblAskData.Size = new System.Drawing.Size(87, 13);
            this.lblAskData.TabIndex = 8;
            this.lblAskData.Text = "xxxxxxxxxxxxxxxx";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 134);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.lblTotalBuy);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.txbPriceBuy);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.cmbBuy);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.btnUnitBuy);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.lblCoinNameBuy);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.lblTotalSell);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.cmbSell);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.lblUnitSell);
            this.splitContainer1.Panel2.Controls.Add(this.btnUnitSell);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.lblCoinNameSell);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(633, 163);
            this.splitContainer1.SplitterDistance = 301;
            this.splitContainer1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BUY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "SELL";
            // 
            // lblCoinNameBuy
            // 
            this.lblCoinNameBuy.AutoSize = true;
            this.lblCoinNameBuy.Location = new System.Drawing.Point(164, 2);
            this.lblCoinNameBuy.Name = "lblCoinNameBuy";
            this.lblCoinNameBuy.Size = new System.Drawing.Size(62, 13);
            this.lblCoinNameBuy.TabIndex = 1;
            this.lblCoinNameBuy.Text = "(coin name)";
            // 
            // lblCoinNameSell
            // 
            this.lblCoinNameSell.AutoSize = true;
            this.lblCoinNameSell.Location = new System.Drawing.Point(193, 2);
            this.lblCoinNameSell.Name = "lblCoinNameSell";
            this.lblCoinNameSell.Size = new System.Drawing.Size(62, 13);
            this.lblCoinNameSell.TabIndex = 1;
            this.lblCoinNameSell.Text = "(coin name)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unit";
            // 
            // btnUnitBuy
            // 
            this.btnUnitBuy.Location = new System.Drawing.Point(46, 28);
            this.btnUnitBuy.Name = "btnUnitBuy";
            this.btnUnitBuy.Size = new System.Drawing.Size(177, 20);
            this.btnUnitBuy.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "(coin name)";
            // 
            // cmbBuy
            // 
            this.cmbBuy.FormattingEnabled = true;
            this.cmbBuy.Location = new System.Drawing.Point(48, 64);
            this.cmbBuy.Name = "cmbBuy";
            this.cmbBuy.Size = new System.Drawing.Size(48, 21);
            this.cmbBuy.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Price";
            // 
            // txbPriceBuy
            // 
            this.txbPriceBuy.Location = new System.Drawing.Point(94, 91);
            this.txbPriceBuy.Name = "txbPriceBuy";
            this.txbPriceBuy.Size = new System.Drawing.Size(129, 20);
            this.txbPriceBuy.TabIndex = 7;
            this.txbPriceBuy.Text = "User input price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total";
            // 
            // lblTotalBuy
            // 
            this.lblTotalBuy.AutoSize = true;
            this.lblTotalBuy.Location = new System.Drawing.Point(50, 134);
            this.lblTotalBuy.Name = "lblTotalBuy";
            this.lblTotalBuy.Size = new System.Drawing.Size(122, 13);
            this.lblTotalBuy.TabIndex = 9;
            this.lblTotalBuy.Text = "xxxxxxxxxxxxxxxxxxxxxxx";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "BTC";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Unit";
            // 
            // btnUnitSell
            // 
            this.btnUnitSell.Location = new System.Drawing.Point(45, 27);
            this.btnUnitSell.Name = "btnUnitSell";
            this.btnUnitSell.Size = new System.Drawing.Size(210, 20);
            this.btnUnitSell.TabIndex = 3;
            // 
            // lblUnitSell
            // 
            this.lblUnitSell.AutoSize = true;
            this.lblUnitSell.Location = new System.Drawing.Point(262, 33);
            this.lblUnitSell.Name = "lblUnitSell";
            this.lblUnitSell.Size = new System.Drawing.Size(62, 13);
            this.lblUnitSell.TabIndex = 4;
            this.lblUnitSell.Text = "(coin name)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Sell when";
            // 
            // cmbSell
            // 
            this.cmbSell.FormattingEnabled = true;
            this.cmbSell.Location = new System.Drawing.Point(73, 67);
            this.cmbSell.Name = "cmbSell";
            this.cmbSell.Size = new System.Drawing.Size(60, 21);
            this.cmbSell.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Total";
            // 
            // lblTotalSell
            // 
            this.lblTotalSell.AutoSize = true;
            this.lblTotalSell.Location = new System.Drawing.Point(44, 136);
            this.lblTotalSell.Name = "lblTotalSell";
            this.lblTotalSell.Size = new System.Drawing.Size(107, 13);
            this.lblTotalSell.TabIndex = 8;
            this.lblTotalSell.Text = "xxxxxxxxxxxxxxxxxxxx";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(240, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "BTC";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 304);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "List coin\'s waiting SELL";
            // 
            // BitTrex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 446);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lblAskData);
            this.Controls.Add(this.lblAsk);
            this.Controls.Add(this.lblLowData);
            this.Controls.Add(this.lblLow);
            this.Controls.Add(this.lblHighData);
            this.Controls.Add(this.lblHigh);
            this.Controls.Add(this.txbBitcoinName);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.btnGetMarketSummary);
            this.Name = "BitTrex";
            this.Text = "Auto Buy/Sell";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetMarketSummary;
        private System.Windows.Forms.TextBox txbResult;
        private System.Windows.Forms.TextBox txbBitcoinName;
        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.Label lblHighData;
        private System.Windows.Forms.Label lblLow;
        private System.Windows.Forms.Label lblLowData;
        private System.Windows.Forms.Label lblAsk;
        private System.Windows.Forms.Label lblAskData;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblCoinNameBuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCoinNameSell;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox btnUnitBuy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBuy;
        private System.Windows.Forms.TextBox txbPriceBuy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalBuy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSell;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblUnitSell;
        private System.Windows.Forms.TextBox btnUnitSell;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotalSell;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
    }
}

