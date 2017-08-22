using Common;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bittrex
{
    public class PublicAPI : ServiceProxyBase
    {
        private static volatile PublicAPI _instance;
        private static readonly object SyncRoot = new Object();

        public static PublicAPI Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (SyncRoot)
                {
                    if (_instance == null)
                        _instance = new PublicAPI();
                }
                return _instance;
            }
        }
        private PublicAPI(string token = "") : base(ConfigurationManager.AppSettings["BittrexApiUrl"], token)
        {

        }

        public GetMarketSummaryResponse GetMarketSummary(string market)
        {
            var request = BuildGetRequest(string.Format("public/getmarketsummary?market={0}", market), DataFormat.Json);
            var apiResult = Execute<ApiCallResponse<List<GetMarketSummaryResponse>>>(request);
            if (apiResult != null && apiResult.result.Count > 0)
                return apiResult.result.FirstOrDefault();
            return null;
        }

        #region Market API
        /// <summary>
        /// Buy and return an order id for canceling afterward
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="market"></param>
        /// <param name="quantity"></param>
        /// <param name="price"></param>
        /// <returns></returns>
        public OrderResponse PlaceBuyOrder(string apiKey, string market, decimal quantity, decimal price)
        {
            var request = BuildGetRequest(string.Format("market/buylimit?apikey={0}&market={1}&quantity={2}&rate={3}", apiKey, market, quantity, price), DataFormat.Json);
            var apiResult = Execute<ApiCallResponse<OrderResponse>>(request);
            return apiResult.result;
        }

        /// <summary>
        /// Used to place an sell order in a specific market.
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="market"></param>
        /// <param name="quantity"></param>
        /// <param name="price"></param>
        /// <returns></returns>
        public OrderResponse PlaceSellOrder(string apiKey, string market, decimal quantity, decimal price)
        {
            var request = BuildGetRequest(string.Format("market/selllimit?apikey={0}&market={1}&quantity={2}&rate={3}", apiKey, market, quantity, price), DataFormat.Json);
            var apiResult = Execute<ApiCallResponse<OrderResponse>>(request);
            return apiResult.result;
        }

        /// <summary>
        /// Used to cancel a buy or sell order.
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="uuid"></param>
        /// <returns></returns>
        public bool CancelOrder(string apiKey, string uuid)
        {
            try
            {
                var request = BuildGetRequest(string.Format("market/cancel?apikey={0}&uuid={1}", apiKey, uuid), DataFormat.Json);
                var apiResult = Execute<ApiCallResponse<OrderResponse>>(request);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// Get all orders that you currently have opened. 
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="market"></param>
        /// <returns></returns>
        public GetOpenOrdersResponse GetOpenOrders(string apiKey, string market)
        {
            var request = BuildGetRequest(string.Format("market/getopenorders?apikey={0}&market={1}", apiKey, market), DataFormat.Json);
            var apiResult = Execute<ApiCallResponse<GetOpenOrdersResponse>>(request);
            return apiResult.result;
        }

        #endregion

        #region Account API
        public AccountBalance GetBalance(string apiKey, string market)
        {
            var request = BuildGetRequest(string.Format("account/getbalance?apikey={0}&currency={1}", apiKey, market), DataFormat.Json);
            var apiResult = Execute<ApiCallResponse<AccountBalance>>(request);
            return apiResult.result;
        }

        public GetBalancesResponse GetBalances(string apiKey)
        {
            var request = BuildGetRequest(string.Format("account/getbalances?apikey={0}", apiKey), DataFormat.Json);
            var apiResult = Execute<ApiCallResponse<GetBalancesResponse>>(request);
            return apiResult.result;
        }

        public GetOrderHistoryResponse GetOrderHistory(string market, int count = 20)
        {
            var request = BuildGetRequest(string.Format("account/getorderhistory?market={0}&?count={1}", market, count), DataFormat.Json);
            var apiResult = Execute<ApiCallResponse<GetOrderHistoryResponse>>(request);
            return apiResult.result;
        }

        public CompletedOrder GetOrderHistory(string uuid)
        {
            var request = BuildGetRequest(string.Format("account/getorder?uuid={0}", uuid), DataFormat.Json);
            var apiResult = Execute<ApiCallResponse<CompletedOrder>>(request);
            return apiResult.result;
        }
        #endregion
    }
}
