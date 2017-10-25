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
            this.txbResult = new System.Windows.Forms.TextBox();
            this.txbBitcoinName = new System.Windows.Forms.TextBox();
            this.lblHigh = new System.Windows.Forms.Label();
            this.lblHighData = new System.Windows.Forms.Label();
            this.lblLow = new System.Windows.Forms.Label();
            this.lblLowData = new System.Windows.Forms.Label();
            this.lblAsk = new System.Windows.Forms.Label();
            this.lblAskData = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblcoinNameBuy1 = new System.Windows.Forms.Label();
            this.lblTotalBuy = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnValueBTCtoBuy = new System.Windows.Forms.TextBox();
            this.lblcoinName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPerProfitSell = new System.Windows.Forms.Label();
            this.txbProfitSell = new System.Windows.Forms.TextBox();
            this.lblTotalSell = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCoinNameSell = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnGetBalances = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAvailableBalanceBTC = new System.Windows.Forms.Label();
            this.Bid = new System.Windows.Forms.Label();
            this.lblBidData = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbListCoinInBittrex = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.txbBitcoinName.Location = new System.Drawing.Point(6, 3);
            this.txbBitcoinName.Name = "txbBitcoinName";
            this.txbBitcoinName.Size = new System.Drawing.Size(10, 20);
            this.txbBitcoinName.TabIndex = 2;
            this.txbBitcoinName.Visible = false;
            // 
            // lblHigh
            // 
            this.lblHigh.AutoSize = true;
            this.lblHigh.Location = new System.Drawing.Point(428, 25);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(44, 13);
            this.lblHigh.TabIndex = 3;
            this.lblHigh.Text = "24 High";
            // 
            // lblHighData
            // 
            this.lblHighData.AutoSize = true;
            this.lblHighData.Location = new System.Drawing.Point(503, 25);
            this.lblHighData.Name = "lblHighData";
            this.lblHighData.Size = new System.Drawing.Size(0, 13);
            this.lblHighData.TabIndex = 4;
            // 
            // lblLow
            // 
            this.lblLow.AutoSize = true;
            this.lblLow.Location = new System.Drawing.Point(431, 50);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(42, 13);
            this.lblLow.TabIndex = 5;
            this.lblLow.Text = "24 Low";
            // 
            // lblLowData
            // 
            this.lblLowData.AutoSize = true;
            this.lblLowData.Location = new System.Drawing.Point(503, 49);
            this.lblLowData.Name = "lblLowData";
            this.lblLowData.Size = new System.Drawing.Size(0, 13);
            this.lblLowData.TabIndex = 6;
            // 
            // lblAsk
            // 
            this.lblAsk.AutoSize = true;
            this.lblAsk.Location = new System.Drawing.Point(447, 75);
            this.lblAsk.Name = "lblAsk";
            this.lblAsk.Size = new System.Drawing.Size(25, 13);
            this.lblAsk.TabIndex = 7;
            this.lblAsk.Text = "Ask";
            this.lblAsk.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAskData
            // 
            this.lblAskData.AutoSize = true;
            this.lblAskData.Location = new System.Drawing.Point(505, 75);
            this.lblAskData.Name = "lblAskData";
            this.lblAskData.Size = new System.Drawing.Size(0, 13);
            this.lblAskData.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "after buy:";
            // 
            // lblcoinNameBuy1
            // 
            this.lblcoinNameBuy1.AutoSize = true;
            this.lblcoinNameBuy1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcoinNameBuy1.Location = new System.Drawing.Point(122, 82);
            this.lblcoinNameBuy1.Name = "lblcoinNameBuy1";
            this.lblcoinNameBuy1.Size = new System.Drawing.Size(22, 16);
            this.lblcoinNameBuy1.TabIndex = 10;
            this.lblcoinNameBuy1.Text = "xx";
            // 
            // lblTotalBuy
            // 
            this.lblTotalBuy.AutoSize = true;
            this.lblTotalBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBuy.Location = new System.Drawing.Point(21, 105);
            this.lblTotalBuy.Name = "lblTotalBuy";
            this.lblTotalBuy.Size = new System.Drawing.Size(22, 17);
            this.lblTotalBuy.TabIndex = 9;
            this.lblTotalBuy.Text = "xx";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total quantity of coin\'s ";
            // 
            // btnValueBTCtoBuy
            // 
            this.btnValueBTCtoBuy.Location = new System.Drawing.Point(47, 46);
            this.btnValueBTCtoBuy.Name = "btnValueBTCtoBuy";
            this.btnValueBTCtoBuy.Size = new System.Drawing.Size(177, 20);
            this.btnValueBTCtoBuy.TabIndex = 3;
            this.btnValueBTCtoBuy.TextChanged += new System.EventHandler(this.btnValueBTCtoBuy_TextChanged);
            // 
            // lblcoinName
            // 
            this.lblcoinName.AutoSize = true;
            this.lblcoinName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcoinName.Location = new System.Drawing.Point(171, 15);
            this.lblcoinName.Name = "lblcoinName";
            this.lblcoinName.Size = new System.Drawing.Size(22, 16);
            this.lblcoinName.TabIndex = 2;
            this.lblcoinName.Text = "xx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input BTC you want to buy ";
            // 
            // lblPerProfitSell
            // 
            this.lblPerProfitSell.AutoSize = true;
            this.lblPerProfitSell.Location = new System.Drawing.Point(212, 47);
            this.lblPerProfitSell.Name = "lblPerProfitSell";
            this.lblPerProfitSell.Size = new System.Drawing.Size(15, 13);
            this.lblPerProfitSell.TabIndex = 11;
            this.lblPerProfitSell.Text = "%";
            // 
            // txbProfitSell
            // 
            this.txbProfitSell.Location = new System.Drawing.Point(163, 44);
            this.txbProfitSell.Name = "txbProfitSell";
            this.txbProfitSell.Size = new System.Drawing.Size(43, 20);
            this.txbProfitSell.TabIndex = 10;
            this.txbProfitSell.Text = "5";
            this.txbProfitSell.TextChanged += new System.EventHandler(this.txbProfitSellTextChanged_TextChanged);
            // 
            // lblTotalSell
            // 
            this.lblTotalSell.AutoSize = true;
            this.lblTotalSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSell.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTotalSell.Location = new System.Drawing.Point(10, 105);
            this.lblTotalSell.Name = "lblTotalSell";
            this.lblTotalSell.Size = new System.Drawing.Size(22, 16);
            this.lblTotalSell.TabIndex = 8;
            this.lblTotalSell.Text = "xx";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "BTC Value after SELL:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Sell when profit increase: ";
            // 
            // lblCoinNameSell
            // 
            this.lblCoinNameSell.AutoSize = true;
            this.lblCoinNameSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoinNameSell.ForeColor = System.Drawing.Color.Blue;
            this.lblCoinNameSell.Location = new System.Drawing.Point(353, 122);
            this.lblCoinNameSell.Name = "lblCoinNameSell";
            this.lblCoinNameSell.Size = new System.Drawing.Size(24, 18);
            this.lblCoinNameSell.TabIndex = 1;
            this.lblCoinNameSell.Text = "xx";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(311, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "SELL";
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
            // btnGetBalances
            // 
            this.btnGetBalances.Location = new System.Drawing.Point(12, 61);
            this.btnGetBalances.Name = "btnGetBalances";
            this.btnGetBalances.Size = new System.Drawing.Size(150, 23);
            this.btnGetBalances.TabIndex = 12;
            this.btnGetBalances.Text = "Get Balances";
            this.btnGetBalances.UseVisualStyleBackColor = true;
            this.btnGetBalances.Click += new System.EventHandler(this.btnGetBalances_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "BTC-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "AVAILABLE BALANCE BTC: ";
            // 
            // lblAvailableBalanceBTC
            // 
            this.lblAvailableBalanceBTC.AutoSize = true;
            this.lblAvailableBalanceBTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableBalanceBTC.Location = new System.Drawing.Point(149, 124);
            this.lblAvailableBalanceBTC.Name = "lblAvailableBalanceBTC";
            this.lblAvailableBalanceBTC.Size = new System.Drawing.Size(22, 16);
            this.lblAvailableBalanceBTC.TabIndex = 15;
            this.lblAvailableBalanceBTC.Text = "xx";
            // 
            // Bid
            // 
            this.Bid.AutoSize = true;
            this.Bid.Location = new System.Drawing.Point(448, 99);
            this.Bid.Name = "Bid";
            this.Bid.Size = new System.Drawing.Size(22, 13);
            this.Bid.TabIndex = 16;
            this.Bid.Text = "Bid";
            this.Bid.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblBidData
            // 
            this.lblBidData.AutoSize = true;
            this.lblBidData.Location = new System.Drawing.Point(505, 98);
            this.lblBidData.Name = "lblBidData";
            this.lblBidData.Size = new System.Drawing.Size(0, 13);
            this.lblBidData.TabIndex = 17;
            this.lblBidData.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblcoinName);
            this.groupBox1.Controls.Add(this.btnValueBTCtoBuy);
            this.groupBox1.Controls.Add(this.lblcoinNameBuy1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblTotalBuy);
            this.groupBox1.Location = new System.Drawing.Point(12, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 167);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotalSell);
            this.groupBox2.Controls.Add(this.lblPerProfitSell);
            this.groupBox2.Controls.Add(this.txbProfitSell);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(311, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 167);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // cmbListCoinInBittrex
            // 
            this.cmbListCoinInBittrex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbListCoinInBittrex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbListCoinInBittrex.FormattingEnabled = true;
            this.cmbListCoinInBittrex.Location = new System.Drawing.Point(38, 23);
            this.cmbListCoinInBittrex.Name = "cmbListCoinInBittrex";
            this.cmbListCoinInBittrex.Size = new System.Drawing.Size(121, 21);
            this.cmbListCoinInBittrex.TabIndex = 22;
            this.cmbListCoinInBittrex.SelectedIndexChanged += new System.EventHandler(this.cmbListCoinInBittrex_SelectedChange);
            // 
            // BitTrex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 446);
            this.Controls.Add(this.cmbListCoinInBittrex);
            this.Controls.Add(this.lblBidData);
            this.Controls.Add(this.Bid);
            this.Controls.Add(this.lblAvailableBalanceBTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblCoinNameSell);
            this.Controls.Add(this.btnGetBalances);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblAskData);
            this.Controls.Add(this.lblAsk);
            this.Controls.Add(this.lblLowData);
            this.Controls.Add(this.lblLow);
            this.Controls.Add(this.lblHighData);
            this.Controls.Add(this.lblHigh);
            this.Controls.Add(this.txbBitcoinName);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "BitTrex";
            this.Text = "Auto Buy/Sell";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbResult;
        private System.Windows.Forms.TextBox txbBitcoinName;
        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.Label lblHighData;
        private System.Windows.Forms.Label lblLow;
        private System.Windows.Forms.Label lblLowData;
        private System.Windows.Forms.Label lblAsk;
        private System.Windows.Forms.Label lblAskData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCoinNameSell;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox btnValueBTCtoBuy;
        private System.Windows.Forms.Label lblcoinName;
        private System.Windows.Forms.Label lblcoinNameBuy1;
        private System.Windows.Forms.Label lblTotalBuy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalSell;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnGetBalances;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblPerProfitSell;
        private System.Windows.Forms.TextBox txbProfitSell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAvailableBalanceBTC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Bid;
        private System.Windows.Forms.Label lblBidData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbListCoinInBittrex;
    }
}

