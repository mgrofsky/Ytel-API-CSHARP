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
    public partial class CarrierController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static CarrierController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static CarrierController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new CarrierController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Get the Carrier Lookup
        /// </summary>
        /// <param name="phonenumber">Required parameter: The number to lookup</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateCarrierLookup(string phonenumber, string responseType = "json")
        {
            Task<string> t = CreateCarrierLookupAsync(phonenumber, responseType);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Get the Carrier Lookup
        /// </summary>
        /// <param name="phonenumber">Required parameter: The number to lookup</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateCarrierLookupAsync(string phonenumber, string responseType = "json")
        {
            //validating required parameters
            if (null == phonenumber)
                throw new ArgumentNullException("phonenumber", "The parameter \"phonenumber\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/carrier/lookup.{ResponseType}");

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
                { "phonenumber", phonenumber }
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

        /// <summary>
        /// Get the All Purchase Number's Carrier lookup
        /// </summary>
        /// <param name="page">Optional parameter: Page Number</param>
        /// <param name="pagesize">Optional parameter: Page Size</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateCarrierLookupList(string page = null, string pagesize = null, string responseType = "json")
        {
            Task<string> t = CreateCarrierLookupListAsync(page, pagesize, responseType);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Get the All Purchase Number's Carrier lookup
        /// </summary>
        /// <param name="page">Optional parameter: Page Number</param>
        /// <param name="pagesize">Optional parameter: Page Size</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateCarrierLookupListAsync(string page = null, string pagesize = null, string responseType = "json")
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/carrier/lookuplist.{ResponseType}");

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
                { "page", page },
                { "pagesize", pagesize }
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