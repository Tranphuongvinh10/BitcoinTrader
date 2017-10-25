using Bittrex;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitcoinTrader
{
    public partial class BitTrex : Form
    {
        public BitTrex()
        {
            InitializeComponent();
            PublicAPI.Instance.Token = apiSecret;
           // var result = PublicAPI.Instance.GetMarket();

            List<GetMarketResponse> coinnameList = new List<GetMarketResponse>();
            coinnameList.Add(PublicAPI.Instance.GetMarket());
          //  coinnameList.Add(new coinname { name = "rob", coinnameID = "32" });
          // coinnameList.Add(new coinname { name = "annie", coinnameID = "24" });
          //coinnameList.Add(new coinname { name = "paul", coinnameID = "19" });

            cmbListCoinInBittrex.DataSource = coinnameList;
            cmbListCoinInBittrex.DisplayMember = "MarketCurrency";
            //cmbListCoinInBittrex.ValueMember = "coinnameID";
        }

        public const string apiKey = "8347ad35f0294f199073dd186339741f";
        public const string apiSecret = "9575361a56af42fda4fc14ca298f78aa";
        public const long epochTicks = 1;
        public const long unixTime = 1;


        public string FormatAllProperties(object obj)
        {
            string returnValue = string.Empty;
            var allProperties = obj.GetType().GetProperties();
            foreach (var pro in allProperties)
            {
                returnValue += string.Format("{0} : {1}", pro.Name, obj.GetType().GetProperty(pro.Name).GetValue(obj)) + Environment.NewLine;
            }
            return returnValue;
        }

        private void btnGetBalances_Click(object sender, EventArgs e)
        {
            long epochTicks = new DateTime(1970, 1, 1).Ticks;
            long unixTime = ((DateTime.UtcNow.Ticks - epochTicks) / TimeSpan.TicksPerSecond);


            var coinNameBuy = txbBitcoinName.Text;
            var coinFullNameBuy = "";
            if (txbBitcoinName.Text.Contains("BTC-"))
            {
                coinFullNameBuy = txbBitcoinName.Text;
            }
            else
            {
                coinFullNameBuy = "BTC-" + txbBitcoinName.Text;
            }
            PublicAPI.Instance.Token = apiSecret;
            // var result = PublicAPI.Instance.GetBalances("8347ad35f0294f199073dd186339741f", unixTime);
            var result = PublicAPI.Instance.GetBalance(apiKey, "BTC", unixTime);
            //check if Available of BTC > 0 then begin preparing to BUY
            if (result.Available >= 0)
            {
                var coinInfoBuy = PublicAPI.Instance.GetMarketSummary(coinFullNameBuy);
                if (coinInfoBuy != null)
                {
                    decimal askBuy = coinInfoBuy.Ask;
                    decimal quantityBuy = 0;
                    decimal quantitySell = 0;
                    quantityBuy = (result.Available / askBuy) * 999 / 1000;
                    //Begin Buy coin
                    quantitySell = quantityBuy;
                    BuyCoin(apiKey, coinFullNameBuy, quantityBuy, askBuy, unixTime);

                    var coinInfoSell = PublicAPI.Instance.GetBalance(apiKey, coinNameBuy, unixTime);
                    if (coinInfoSell.Available >= (decimal)(0.0005))
                    {

                        //Get order history of SELL coin                                 
                        var orderInfoSell = PublicAPI.Instance.GetOrderHistory(apiKey, unixTime);
                        for (int i = 0; i < orderInfoSell.Count; i++)
                        {
                            if (orderInfoSell[i].OrderType.ToString().ToLower() == "limit_buy" && orderInfoSell[i].Exchange == "BTC-GNO")
                            {
                                if ((txbProfitSell.Text) != null)
                                {
                                    //calculate profit and SELL coin
                                    var profitSell = orderInfoSell[i].PricePerUnit + orderInfoSell[i].PricePerUnit * Decimal.Parse(txbProfitSell.Text) / 100;
                                    SellCoin(apiKey, coinFullNameBuy, quantitySell, profitSell, unixTime);
                                }
                            }
                        }
                    }

                }
            }

        }

        public void BuyCoin(string apiKey, string coinFullNameBuy, decimal quantityBuy, decimal askBuy, long unixTime)
        {
            // var completedBuy = PublicAPI.Instance.PlaceBuyOrder(apiKey, coinFullNameBuy, quantityBuy, askBuy, unixTime);
        }
        public void SellCoin(string apiKey, string coinFullNameSell, decimal quantitySell, decimal price, long unixTime)
        {
            //  var completedBuy = PublicAPI.Instance.PlaceBuyOrder(apiKey, coinFullNameSell, quantitySell, price, unixTime);
        }
        public void CancelCoin()
        {

        }

        /// <summary>
        /// Get available balance btc of user
        /// </summary>
        /// <returns></returns>
        public string AvailableBalanceBTC()
        {
            long epochTicks = new DateTime(1970, 1, 1).Ticks;
            long unixTime = ((DateTime.UtcNow.Ticks - epochTicks) / TimeSpan.TicksPerSecond);
            PublicAPI.Instance.Token = apiSecret;
            var resultBTC = PublicAPI.Instance.GetBalance(apiKey, "BTC", unixTime);
            if (resultBTC != null)
            {
                return resultBTC.Available.ToString();
            }
            return "0";
        }

        /// <summary>
        /// This function to calculate quantity of coin need to BUY
        /// </summary>
        /// <param name="availableBalanceBTC"></param>
        /// <param name="coinNameBuy"></param>
        /// <returns></returns>
        public string TotalQuantityCoinBuy(string availableBalanceBTC, string coinNameBuy)
        {
            var result = PublicAPI.Instance.GetMarketSummary(coinNameBuy);
            if (result != null)
            {
                return (Decimal.Parse(availableBalanceBTC) / result.Ask * 999 / 1000).ToString();
            }
            return "0";
        }

        public string ValueProfitSell(string pricePerUnit, string perProfit)
        {

            //calculate profit and SELL coin
            if (pricePerUnit != null && perProfit != null)
            {
                return ((Decimal.Parse(pricePerUnit) + Decimal.Parse(pricePerUnit) * Decimal.Parse(perProfit) / 100 )* Decimal.Parse(lblTotalBuy.Text)).ToString();
            }
            return "0";
        }
        private void txbBitcoinName_TextChanged(object sender, EventArgs e)
        {
            long epochTicks = new DateTime(1970, 1, 1).Ticks;
            long unixTime = ((DateTime.UtcNow.Ticks - epochTicks) / TimeSpan.TicksPerSecond);
            lblcoinName.Text = txbBitcoinName.Text;
            var coinFullName = "";
            var coinName = txbBitcoinName.Text;
            if (txbBitcoinName.Text.Contains("BTC-"))
            {
                coinFullName = txbBitcoinName.Text;
            }
            else
            {
                coinFullName = "BTC-" + txbBitcoinName.Text;
            }

            var result = PublicAPI.Instance.GetMarketSummary(coinFullName);
            if (result != null)
            {
                // txbResult.Text = FormatAllProperties(result);
                lblHighData.Text = result.High.ToString();
                lblLowData.Text = result.Low.ToString();
                lblAskData.Text = result.Ask.ToString();
                lblBidData.Text = result.Bid.ToString();
                lblAvailableBalanceBTC.Text = AvailableBalanceBTC();
                btnValueBTCtoBuy.Text = lblAvailableBalanceBTC.Text;
                lblTotalBuy.Text = TotalQuantityCoinBuy(lblAvailableBalanceBTC.Text, coinFullName);
                lblcoinNameBuy1.Text = coinName;
                lblTotalSell.Text = ValueProfitSell(lblAskData.Text, txbProfitSell.Text);
                lblCoinNameSell.Text = coinFullName.ToUpper();

            }
            else
            {
                lblHighData.Text = string.Empty;
                lblLowData.Text = string.Empty;
                lblAskData.Text = string.Empty;
                lblTotalBuy.Text = string.Empty;
                lblTotalSell.Text = string.Empty;
                lblBidData.Text = string.Empty;
                lblCoinNameSell.Text = string.Empty;
            }

        }

        private void btnValueBTCtoBuy_TextChanged(object sender, EventArgs e)
        {
            lblTotalBuy.Text = TotalQuantityCoinBuy(btnValueBTCtoBuy.Text, "BTC-" + txbBitcoinName.Text);
            lblTotalSell.Text = ValueProfitSell(lblAskData.Text, txbProfitSell.Text);

        }

        private void btnValueBTCtoBuy_TextLeave(object sender, EventArgs e)
        {
            // lblTotalBuy.Text = TotalQuantityCoinBuy(btnValueBTCtoBuy.Text, "BTC-" + txbBitcoinName.Text);
        }

        private void txbProfitSellTextChanged_TextChanged(object sender, EventArgs e)
        {
            lblTotalSell.Text = ValueProfitSell(lblAskData.Text, txbProfitSell.Text);
        }
    }
}
