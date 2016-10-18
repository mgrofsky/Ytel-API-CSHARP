/*
 * Message360.PCL
 *
 * This file was automatically generated for message360 by APIMATIC v2.0 ( https://apimatic.io ) on 10/18/2016
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using message360;
using message360.Http.Request;
using message360.Http.Response;
using message360.Http.Client;
using message360.Exceptions;
using message360.Models;

namespace message360.Controllers
{
    public partial class UsageController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static UsageController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static UsageController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new UsageController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Get all usage 
        /// </summary>
        /// <param name="productCode">Required parameter: Product Code</param>
        /// <param name="startDate">Required parameter: Start Usage Date</param>
        /// <param name="endDate">Required parameter: End Usage Date</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateListUsage(
                string productCode,
                string startDate,
                string endDate,
                string responseType = "json")
        {
            Task<string> t = CreateListUsageAsync(productCode, startDate, endDate, responseType);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Get all usage 
        /// </summary>
        /// <param name="productCode">Required parameter: Product Code</param>
        /// <param name="startDate">Required parameter: Start Usage Date</param>
        /// <param name="endDate">Required parameter: End Usage Date</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateListUsageAsync(
                string productCode,
                string startDate,
                string endDate,
                string responseType = "json")
        {
            //validating required parameters
            if (null == productCode)
                throw new ArgumentNullException("productCode", "The parameter \"productCode\" is a required parameter and cannot be null.");

            if (null == startDate)
                throw new ArgumentNullException("startDate", "The parameter \"startDate\" is a required parameter and cannot be null.");

            if (null == endDate)
                throw new ArgumentNullException("endDate", "The parameter \"endDate\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/usage/listusage.{ResponseType}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "ResponseType", (null != responseType) ? responseType : "json" }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "message360-api" }
            };

            //append form/field parameters
            var _fields = new Dictionary<string,object>()
            {
                { "ProductCode", productCode },
                { "startDate", startDate },
                { "endDate", endDate }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 