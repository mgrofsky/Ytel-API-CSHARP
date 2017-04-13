/*
 * Message360.PCL
 *
 * This file was automatically generated for message360 by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using APIMATIC.SDK.Common;
using APIMATIC.SDK.Http.Request;
using APIMATIC.SDK.Http.Response;
using APIMATIC.SDK.Http.Client;
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
        /// Update Phone Number Details
        /// </summary>
        /// <param name="UpdatePhoneNumberInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string UpdatePhoneNumber(UpdatePhoneNumberInput input)
        {
            Task<string> t = UpdatePhoneNumberAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Update Phone Number Details
        /// </summary>
        /// <param name="UpdatePhoneNumberInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> UpdatePhoneNumberAsync(UpdatePhoneNumberInput input)
        {
            //validating required parameters
            if (null == input.PhoneNumber)
                throw new ArgumentNullException("phoneNumber", "The property \"PhoneNumber\" in the input object cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/incomingphone/updatenumber.{ResponseType}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "ResponseType", input.ResponseType }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "message360-api" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "PhoneNumber", input.PhoneNumber ),
                new KeyValuePair<string, object>( "FriendlyName", input.FriendlyName ),
                new KeyValuePair<string, object>( "VoiceUrl", input.VoiceUrl ),
                new KeyValuePair<string, object>( "VoiceMethod", (input.VoiceMethod.HasValue) ? HttpActionEnumHelper.ToValue(input.VoiceMethod.Value) : null ),
                new KeyValuePair<string, object>( "VoiceFallbackUrl", input.VoiceFallbackUrl ),
                new KeyValuePair<string, object>( "VoiceFallbackMethod", (input.VoiceFallbackMethod.HasValue) ? HttpActionEnumHelper.ToValue(input.VoiceFallbackMethod.Value) : null ),
                new KeyValuePair<string, object>( "HangupCallback", input.HangupCallback ),
                new KeyValuePair<string, object>( "HangupCallbackMethod", (input.HangupCallbackMethod.HasValue) ? HttpActionEnumHelper.ToValue(input.HangupCallbackMethod.Value) : null ),
                new KeyValuePair<string, object>( "HeartbeatUrl", input.HeartbeatUrl ),
                new KeyValuePair<string, object>( "HeartbeatMethod", (input.HeartbeatMethod.HasValue) ? HttpActionEnumHelper.ToValue(input.HeartbeatMethod.Value) : null ),
                new KeyValuePair<string, object>( "SmsUrl", input.SmsUrl ),
                new KeyValuePair<string, object>( "SmsMethod", (input.SmsMethod.HasValue) ? HttpActionEnumHelper.ToValue(input.SmsMethod.Value) : null ),
                new KeyValuePair<string, object>( "SmsFallbackUrl", input.SmsFallbackUrl ),
                new KeyValuePair<string, object>( "SmsFallbackMethod", (input.SmsFallbackMethod.HasValue) ? HttpActionEnumHelper.ToValue(input.SmsFallbackMethod.Value) : null )
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
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
        /// <param name="CreateBuyNumberInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateBuyNumber(CreateBuyNumberInput input)
        {
            Task<string> t = CreateBuyNumberAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Buy Phone Number 
        /// </summary>
        /// <param name="CreateBuyNumberInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateBuyNumberAsync(CreateBuyNumberInput input)
        {
            //validating required parameters
            if (null == input.PhoneNumber)
                throw new ArgumentNullException("phoneNumber", "The property \"PhoneNumber\" in the input object cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/incomingphone/buynumber.{ResponseType}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "ResponseType", input.ResponseType }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "message360-api" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "PhoneNumber", input.PhoneNumber )
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
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
        /// <param name="CreateReleaseNumberInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateReleaseNumber(CreateReleaseNumberInput input)
        {
            Task<string> t = CreateReleaseNumberAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Release number from account
        /// </summary>
        /// <param name="CreateReleaseNumberInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateReleaseNumberAsync(CreateReleaseNumberInput input)
        {
            //validating required parameters
            if (null == input.PhoneNumber)
                throw new ArgumentNullException("phoneNumber", "The property \"PhoneNumber\" in the input object cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/incomingphone/releasenumber.{ResponseType}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "ResponseType", input.ResponseType }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "message360-api" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "PhoneNumber", input.PhoneNumber )
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
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
        /// <param name="CreateViewNumberDetailsInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateViewNumberDetails(CreateViewNumberDetailsInput input)
        {
            Task<string> t = CreateViewNumberDetailsAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get Phone Number Details
        /// </summary>
        /// <param name="CreateViewNumberDetailsInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateViewNumberDetailsAsync(CreateViewNumberDetailsInput input)
        {
            //validating required parameters
            if (null == input.PhoneNumber)
                throw new ArgumentNullException("phoneNumber", "The property \"PhoneNumber\" in the input object cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/incomingphone/viewnumber.{ResponseType}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "ResponseType", input.ResponseType }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "message360-api" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "PhoneNumber", input.PhoneNumber )
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
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
        /// <param name="CreateListNumberInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateListNumber(CreateListNumberInput input)
        {
            Task<string> t = CreateListNumberAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// List Account's Phone number details
        /// </summary>
        /// <param name="CreateListNumberInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateListNumberAsync(CreateListNumberInput input)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/incomingphone/listnumber.{ResponseType}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "ResponseType", input.ResponseType }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "message360-api" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "Page", input.Page ),
                new KeyValuePair<string, object>( "PageSize", input.PageSize ),
                new KeyValuePair<string, object>( "NumberType", (input.NumberType.HasValue) ? NumberTypeEnumHelper.ToValue(input.NumberType.Value) : null ),
                new KeyValuePair<string, object>( "FriendlyName", input.FriendlyName )
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
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
        /// Available Phone Number
        /// </summary>
        /// <param name="CreateAvailablePhoneNumberInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateAvailablePhoneNumber(CreateAvailablePhoneNumberInput input)
        {
            Task<string> t = CreateAvailablePhoneNumberAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Available Phone Number
        /// </summary>
        /// <param name="CreateAvailablePhoneNumberInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateAvailablePhoneNumberAsync(CreateAvailablePhoneNumberInput input)
        {
            //validating required parameters
            if (null == input.AreaCode)
                throw new ArgumentNullException("areaCode", "The property \"AreaCode\" in the input object cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/incomingphone/availablenumber.{ResponseType}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "ResponseType", input.ResponseType }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "message360-api" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "NumberType", NumberTypeEnumHelper.ToValue(input.NumberType) ),
                new KeyValuePair<string, object>( "AreaCode", input.AreaCode ),
                new KeyValuePair<string, object>( "PageSize", input.PageSize )
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
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