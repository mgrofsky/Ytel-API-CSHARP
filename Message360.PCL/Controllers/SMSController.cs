/*
 * Message360.PCL
 *
 * This file was automatically generated for message360 by APIMATIC v2.0 ( https://apimatic.io ) on 10/21/2016
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
    public partial class SMSController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static SMSController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static SMSController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new SMSController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Send an SMS from a message360 number
        /// </summary>
        /// <param name="fromcountrycode">Required parameter: From Country Code</param>
        /// <param name="mfrom">Required parameter: SMS enabled Message360 number to send this message from</param>
        /// <param name="tocountrycode">Required parameter: To country code</param>
        /// <param name="to">Required parameter: Number to send the SMS to</param>
        /// <param name="body">Required parameter: Text Message To Send</param>
        /// <param name="method">Optional parameter: Specifies the HTTP method used to request the required URL once SMS sent.</param>
        /// <param name="messagestatuscallback">Optional parameter: URL that can be requested to receive notification when SMS has Sent. A set of default parameters will be sent here once the SMS is finished.</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateSendSMS(
                int fromcountrycode,
                string mfrom,
                int tocountrycode,
                string to,
                string body,
                HttpMethod? method = null,
                string messagestatuscallback = null,
                string responseType = "json")
        {
            Task<string> t = CreateSendSMSAsync(fromcountrycode, mfrom, tocountrycode, to, body, method, messagestatuscallback, responseType);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Send an SMS from a message360 number
        /// </summary>
        /// <param name="fromcountrycode">Required parameter: From Country Code</param>
        /// <param name="mfrom">Required parameter: SMS enabled Message360 number to send this message from</param>
        /// <param name="tocountrycode">Required parameter: To country code</param>
        /// <param name="to">Required parameter: Number to send the SMS to</param>
        /// <param name="body">Required parameter: Text Message To Send</param>
        /// <param name="method">Optional parameter: Specifies the HTTP method used to request the required URL once SMS sent.</param>
        /// <param name="messagestatuscallback">Optional parameter: URL that can be requested to receive notification when SMS has Sent. A set of default parameters will be sent here once the SMS is finished.</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateSendSMSAsync(
                int fromcountrycode,
                string mfrom,
                int tocountrycode,
                string to,
                string body,
                HttpMethod? method = null,
                string messagestatuscallback = null,
                string responseType = "json")
        {
            //validating required parameters
            if (null == mfrom)
                throw new ArgumentNullException("mfrom", "The parameter \"mfrom\" is a required parameter and cannot be null.");

            if (null == to)
                throw new ArgumentNullException("to", "The parameter \"to\" is a required parameter and cannot be null.");

            if (null == body)
                throw new ArgumentNullException("body", "The parameter \"body\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/sms/sendsms.{ResponseType}");

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
                { "fromcountrycode", fromcountrycode },
                { "from", mfrom },
                { "tocountrycode", tocountrycode },
                { "to", to },
                { "body", body },
                { "method", (method.HasValue) ? HttpMethodHelper.ToValue(method.Value) : null },
                { "messagestatuscallback", messagestatuscallback }
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
        /// View Particular SMS
        /// </summary>
        /// <param name="messagesid">Required parameter: Message sid</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateViewSMS(string messagesid, string responseType = "json")
        {
            Task<string> t = CreateViewSMSAsync(messagesid, responseType);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// View Particular SMS
        /// </summary>
        /// <param name="messagesid">Required parameter: Message sid</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateViewSMSAsync(string messagesid, string responseType = "json")
        {
            //validating required parameters
            if (null == messagesid)
                throw new ArgumentNullException("messagesid", "The parameter \"messagesid\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/sms/viewsms.{ResponseType}");

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
                { "messagesid", messagesid }
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
        /// List All SMS
        /// </summary>
        /// <param name="page">Optional parameter: Which page of the overall response will be returned. Zero indexed</param>
        /// <param name="pagesize">Optional parameter: Number of individual resources listed in the response per page</param>
        /// <param name="mfrom">Optional parameter: Messages sent from this number</param>
        /// <param name="to">Optional parameter: Messages sent to this number</param>
        /// <param name="datesent">Optional parameter: Only list SMS messages sent in the specified date range</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateListSMS(
                int? page = null,
                int? pagesize = null,
                string mfrom = null,
                string to = null,
                string datesent = null,
                string responseType = "json")
        {
            Task<string> t = CreateListSMSAsync(page, pagesize, mfrom, to, datesent, responseType);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// List All SMS
        /// </summary>
        /// <param name="page">Optional parameter: Which page of the overall response will be returned. Zero indexed</param>
        /// <param name="pagesize">Optional parameter: Number of individual resources listed in the response per page</param>
        /// <param name="mfrom">Optional parameter: Messages sent from this number</param>
        /// <param name="to">Optional parameter: Messages sent to this number</param>
        /// <param name="datesent">Optional parameter: Only list SMS messages sent in the specified date range</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateListSMSAsync(
                int? page = null,
                int? pagesize = null,
                string mfrom = null,
                string to = null,
                string datesent = null,
                string responseType = "json")
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/sms/listsms.{ResponseType}");

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
                { "pagesize", pagesize },
                { "from", mfrom },
                { "to", to },
                { "datesent", datesent }
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
        /// List All Inbound SMS
        /// </summary>
        /// <param name="page">Optional parameter: Which page of the overall response will be returned. Zero indexed</param>
        /// <param name="pagesize">Optional parameter: Number of individual resources listed in the response per page</param>
        /// <param name="mfrom">Optional parameter: From Number to Inbound SMS</param>
        /// <param name="to">Optional parameter: To Number to get Inbound SMS</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateListInboundSMS(
                int? page = null,
                string pagesize = null,
                string mfrom = null,
                string to = null,
                string responseType = "json")
        {
            Task<string> t = CreateListInboundSMSAsync(page, pagesize, mfrom, to, responseType);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// List All Inbound SMS
        /// </summary>
        /// <param name="page">Optional parameter: Which page of the overall response will be returned. Zero indexed</param>
        /// <param name="pagesize">Optional parameter: Number of individual resources listed in the response per page</param>
        /// <param name="mfrom">Optional parameter: From Number to Inbound SMS</param>
        /// <param name="to">Optional parameter: To Number to get Inbound SMS</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateListInboundSMSAsync(
                int? page = null,
                string pagesize = null,
                string mfrom = null,
                string to = null,
                string responseType = "json")
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/sms/getInboundsms.{ResponseType}");

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
                { "pagesize", pagesize },
                { "from", mfrom },
                { "to", to }
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