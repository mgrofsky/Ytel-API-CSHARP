/*
 * Message360.PCL
 *
 * This file was automatically generated for message360 by APIMATIC v2.0 ( https://apimatic.io ) on 11/04/2016
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
    public partial class PhoneNumberController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static PhoneNumberController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static PhoneNumberController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new PhoneNumberController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Available Phone Number
        /// </summary>
        /// <param name="numberType">Required parameter: Number type either SMS,Voice or all</param>
        /// <param name="areaCode">Required parameter: Phone Number Area Code</param>
        /// <param name="pageSize">Optional parameter: Page Size</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateAvailablePhoneNumber(
                string numberType,
                string areaCode,
                int? pageSize = null,
                string responseType = "json")
        {
            Task<string> t = CreateAvailablePhoneNumberAsync(numberType, areaCode, pageSize, responseType);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Available Phone Number
        /// </summary>
        /// <param name="numberType">Required parameter: Number type either SMS,Voice or all</param>
        /// <param name="areaCode">Required parameter: Phone Number Area Code</param>
        /// <param name="pageSize">Optional parameter: Page Size</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateAvailablePhoneNumberAsync(
                string numberType,
                string areaCode,
                int? pageSize = null,
                string responseType = "json")
        {
            //validating required parameters
            if (null == numberType)
                throw new ArgumentNullException("numberType", "The parameter \"numberType\" is a required parameter and cannot be null.");

            if (null == areaCode)
                throw new ArgumentNullException("areaCode", "The parameter \"areaCode\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/incomingphone/availablenumber.{ResponseType}");

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
                { "NumberType", numberType },
                { "AreaCode", areaCode },
                { "PageSize", pageSize }
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
        /// List Account's Phone number details
        /// </summary>
        /// <param name="page">Optional parameter: Which page of the overall response will be returned. Zero indexed</param>
        /// <param name="pageSize">Optional parameter: Number of individual resources listed in the response per page</param>
        /// <param name="numberType">Optional parameter: Example: </param>
        /// <param name="friendlyName">Optional parameter: Example: </param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateListNumber(
                int? page = null,
                int? pageSize = null,
                string numberType = null,
                string friendlyName = null,
                string responseType = "json")
        {
            Task<string> t = CreateListNumberAsync(page, pageSize, numberType, friendlyName, responseType);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// List Account's Phone number details
        /// </summary>
        /// <param name="page">Optional parameter: Which page of the overall response will be returned. Zero indexed</param>
        /// <param name="pageSize">Optional parameter: Number of individual resources listed in the response per page</param>
        /// <param name="numberType">Optional parameter: Example: </param>
        /// <param name="friendlyName">Optional parameter: Example: </param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateListNumberAsync(
                int? page = null,
                int? pageSize = null,
                string numberType = null,
                string friendlyName = null,
                string responseType = "json")
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/incomingphone/listnumber.{ResponseType}");

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
                { "Page", page },
                { "PageSize", pageSize },
                { "NumberType", numberType },
                { "FriendlyName", friendlyName }
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
        /// Release number from account
        /// </summary>
        /// <param name="phoneNumber">Required parameter: Phone number to be relase</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateReleaseNumber(string phoneNumber, string responseType = "json")
        {
            Task<string> t = CreateReleaseNumberAsync(phoneNumber, responseType);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Release number from account
        /// </summary>
        /// <param name="phoneNumber">Required parameter: Phone number to be relase</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateReleaseNumberAsync(string phoneNumber, string responseType = "json")
        {
            //validating required parameters
            if (null == phoneNumber)
                throw new ArgumentNullException("phoneNumber", "The parameter \"phoneNumber\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/incomingphone/releasenumber.{ResponseType}");

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
                { "PhoneNumber", phoneNumber }
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
        /// Buy Phone Number 
        /// </summary>
        /// <param name="phoneNumber">Required parameter: Phone number to be purchase</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateBuyNumber(string phoneNumber, string responseType = "json")
        {
            Task<string> t = CreateBuyNumberAsync(phoneNumber, responseType);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Buy Phone Number 
        /// </summary>
        /// <param name="phoneNumber">Required parameter: Phone number to be purchase</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateBuyNumberAsync(string phoneNumber, string responseType = "json")
        {
            //validating required parameters
            if (null == phoneNumber)
                throw new ArgumentNullException("phoneNumber", "The parameter \"phoneNumber\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/incomingphone/buynumber.{ResponseType}");

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
                { "PhoneNumber", phoneNumber }
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
        /// Get Phone Number Details
        /// </summary>
        /// <param name="phoneNumber">Required parameter: Get Phone number Detail</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateViewNumberDetails(string phoneNumber, string responseType = "json")
        {
            Task<string> t = CreateViewNumberDetailsAsync(phoneNumber, responseType);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Get Phone Number Details
        /// </summary>
        /// <param name="phoneNumber">Required parameter: Get Phone number Detail</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateViewNumberDetailsAsync(string phoneNumber, string responseType = "json")
        {
            //validating required parameters
            if (null == phoneNumber)
                throw new ArgumentNullException("phoneNumber", "The parameter \"phoneNumber\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/incomingphone/viewnumber.{ResponseType}");

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
                { "PhoneNumber", phoneNumber }
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
        /// Update Phone Number Details
        /// </summary>
        /// <param name="phoneNumber">Required parameter: Example: </param>
        /// <param name="friendlyName">Optional parameter: Example: </param>
        /// <param name="voiceUrl">Optional parameter: URL requested once the call connects</param>
        /// <param name="voiceMethod">Optional parameter: Example: </param>
        /// <param name="voiceFallbackUrl">Optional parameter: URL requested if the voice URL is not available</param>
        /// <param name="voiceFallbackMethod">Optional parameter: Example: </param>
        /// <param name="hangupCallback">Optional parameter: Example: </param>
        /// <param name="hangupCallbackMethod">Optional parameter: Example: </param>
        /// <param name="heartbeatUrl">Optional parameter: URL requested once the call connects</param>
        /// <param name="heartbeatMethod">Optional parameter: URL that can be requested every 60 seconds during the call to notify of elapsed time</param>
        /// <param name="smsUrl">Optional parameter: URL requested when an SMS is received</param>
        /// <param name="smsMethod">Optional parameter: Example: </param>
        /// <param name="smsFallbackUrl">Optional parameter: URL requested once the call connects</param>
        /// <param name="smsFallbackMethod">Optional parameter: URL requested if the sms URL is not available</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public string UpdatePhoneNumber(
                string phoneNumber,
                string friendlyName = null,
                string voiceUrl = null,
                HttpMethod? voiceMethod = null,
                string voiceFallbackUrl = null,
                HttpMethod? voiceFallbackMethod = null,
                string hangupCallback = null,
                HttpMethod? hangupCallbackMethod = null,
                string heartbeatUrl = null,
                HttpMethod? heartbeatMethod = null,
                string smsUrl = null,
                HttpMethod? smsMethod = null,
                string smsFallbackUrl = null,
                HttpMethod? smsFallbackMethod = null,
                string responseType = "json")
        {
            Task<string> t = UpdatePhoneNumberAsync(phoneNumber, friendlyName, voiceUrl, voiceMethod, voiceFallbackUrl, voiceFallbackMethod, hangupCallback, hangupCallbackMethod, heartbeatUrl, heartbeatMethod, smsUrl, smsMethod, smsFallbackUrl, smsFallbackMethod, responseType);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Update Phone Number Details
        /// </summary>
        /// <param name="phoneNumber">Required parameter: Example: </param>
        /// <param name="friendlyName">Optional parameter: Example: </param>
        /// <param name="voiceUrl">Optional parameter: URL requested once the call connects</param>
        /// <param name="voiceMethod">Optional parameter: Example: </param>
        /// <param name="voiceFallbackUrl">Optional parameter: URL requested if the voice URL is not available</param>
        /// <param name="voiceFallbackMethod">Optional parameter: Example: </param>
        /// <param name="hangupCallback">Optional parameter: Example: </param>
        /// <param name="hangupCallbackMethod">Optional parameter: Example: </param>
        /// <param name="heartbeatUrl">Optional parameter: URL requested once the call connects</param>
        /// <param name="heartbeatMethod">Optional parameter: URL that can be requested every 60 seconds during the call to notify of elapsed time</param>
        /// <param name="smsUrl">Optional parameter: URL requested when an SMS is received</param>
        /// <param name="smsMethod">Optional parameter: Example: </param>
        /// <param name="smsFallbackUrl">Optional parameter: URL requested once the call connects</param>
        /// <param name="smsFallbackMethod">Optional parameter: URL requested if the sms URL is not available</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> UpdatePhoneNumberAsync(
                string phoneNumber,
                string friendlyName = null,
                string voiceUrl = null,
                HttpMethod? voiceMethod = null,
                string voiceFallbackUrl = null,
                HttpMethod? voiceFallbackMethod = null,
                string hangupCallback = null,
                HttpMethod? hangupCallbackMethod = null,
                string heartbeatUrl = null,
                HttpMethod? heartbeatMethod = null,
                string smsUrl = null,
                HttpMethod? smsMethod = null,
                string smsFallbackUrl = null,
                HttpMethod? smsFallbackMethod = null,
                string responseType = "json")
        {
            //validating required parameters
            if (null == phoneNumber)
                throw new ArgumentNullException("phoneNumber", "The parameter \"phoneNumber\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/incomingphone/updatenumber.{ResponseType}");

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
                { "PhoneNumber", phoneNumber },
                { "FriendlyName", friendlyName },
                { "VoiceUrl", voiceUrl },
                { "VoiceMethod", (voiceMethod.HasValue) ? HttpMethodHelper.ToValue(voiceMethod.Value) : null },
                { "VoiceFallbackUrl", voiceFallbackUrl },
                { "VoiceFallbackMethod", (voiceFallbackMethod.HasValue) ? HttpMethodHelper.ToValue(voiceFallbackMethod.Value) : null },
                { "HangupCallback", hangupCallback },
                { "HangupCallbackMethod", (hangupCallbackMethod.HasValue) ? HttpMethodHelper.ToValue(hangupCallbackMethod.Value) : null },
                { "HeartbeatUrl", heartbeatUrl },
                { "HeartbeatMethod", (heartbeatMethod.HasValue) ? HttpMethodHelper.ToValue(heartbeatMethod.Value) : null },
                { "SmsUrl", smsUrl },
                { "SmsMethod", (smsMethod.HasValue) ? HttpMethodHelper.ToValue(smsMethod.Value) : null },
                { "SmsFallbackUrl", smsFallbackUrl },
                { "SmsFallbackMethod", (smsFallbackMethod.HasValue) ? HttpMethodHelper.ToValue(smsFallbackMethod.Value) : null }
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