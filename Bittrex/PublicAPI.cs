using Common;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

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

        public List<GetMarketResponse> GetMarket()
        {
            var request = BuildGetRequest(string.Format("public/getmarkets"), DataFormat.Json);
            var apiResult = Execute<ApiCallResponse<List<GetMarketResponse>>>(request);
            if (apiResult != null && apiResult.result != null)
                return apiResult.result;
            return null;
        }

        public GetMarketSummaryResponse GetMarketSummary(string market)
        {
            var request = BuildGetRequest(string.Format("public/getmarketsummary?market={0}", market), DataFormat.Json);
            var apiResult = Execute<ApiCallResponse<List<GetMarketSummaryResponse>>>(request);
            if (apiResult != null && apiResult.result != null)
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
            long epochTicks = new DateTime(1970, 1, 1).Ticks;
            long unixTime = ((DateTime.UtcNow.Ticks - epochTicks) / TimeSpan.TicksPerSecond);
            var request = BuildGetRequest(string.Format("market/buylimit?apikey={0}&market={1}&quantity={2}&rate={3}&nonce={4}", apiKey, market, quantity, price, unixTime), DataFormat.Json);
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
            long epochTicks = new DateTime(1970, 1, 1).Ticks;
            long unixTime = ((DateTime.UtcNow.Ticks - epochTicks) / TimeSpan.TicksPerSecond);
            var request = BuildGetRequest(string.Format("market/selllimit?apikey={0}&market={1}&quantity={2}&rate={3}&nonce={4}", apiKey, market, quantity, price, unixTime), DataFormat.Json);
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
            long epochTicks = new DateTime(1970, 1, 1).Ticks;
            long unixTime = ((DateTime.UtcNow.Ticks - epochTicks) / TimeSpan.TicksPerSecond);
            var request = BuildGetRequest(string.Format("account/getbalance?apikey={0}&currency={1}&nonce={2}", apiKey, market, unixTime), DataFormat.Json);
            var apiResult = Execute<ApiCallResponse<AccountBalance>>(request);
            return apiResult.result;
        }

        public GetBalancesResponse GetBalances(string apiKey, long unixTime)
        {
            var request = BuildGetRequest(string.Format("account/getbalances?apikey={0}&nonce={1}", apiKey, unixTime), DataFormat.Json);
            var apiResult = Execute<ApiCallResponse<GetBalancesResponse>>(request);
            return apiResult.result;
        }

        /*
        public GetOrderHistoryResponse GetOrderHistory(string market, int count = 20)
        {
            var request = BuildGetRequest(string.Format("account/getorderhistory?market={0}&?count={1}", market, count), DataFormat.Json);
            var apiResult = Execute<ApiCallResponse<GetOrderHistoryResponse>>(request);
            return apiResult.result;
        }
        */

        public GetOrderHistoryResponse GetOrderHistory(string apiKey,long unixTime)
        {
            var request = BuildGetRequest(string.Format("account/getorderhistory?apikey={0}&nonce={1}",apiKey,unixTime), DataFormat.Json);
            var apiResult = Execute<ApiCallResponse<GetOrderHistoryResponse>>(request);
            return apiResult.result;
        }

        public CompletedOrder GetCompleteOrderHistory(string uuid, long unixTime)
        {
            var request = BuildGetRequest(string.Format("account/getorder?uuid={0}&nonce={2}", uuid, unixTime), DataFormat.Json);
            var apiResult = Execute<ApiCallResponse<CompletedOrder>>(request);
            return apiResult.result;
        }
        #endregion
    }
}
