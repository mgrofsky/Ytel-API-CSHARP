/*
 * Ytel.PCL
 *
 * This file was automatically generated for ytel by APIMATIC v2.0 ( https://apimatic.io )
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

namespace ytel.Controllers
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
        /// Retrieve a list of available phone numbers that can be purchased and used for your Ytel account.
        /// </summary>
        /// <param name="Models.AvailablePhoneNumberInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string AvailablePhoneNumber(Models.AvailablePhoneNumberInput input)
        {
            Task<string> t = AvailablePhoneNumberAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a list of available phone numbers that can be purchased and used for your Ytel account.
        /// </summary>
        /// <param name="Models.AvailablePhoneNumberInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> AvailablePhoneNumberAsync(Models.AvailablePhoneNumberInput input)
        {
            //validating required parameters
            if (null == input.Areacode)
                throw new ArgumentNullException("areacode", "The property \"Areacode\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
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
                { "user-agent", "ytel-api" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "numbertype", Models.NumberTypeEnumHelper.ToValue(input.Numbertype) ),
                new KeyValuePair<string, object>( "areacode", input.Areacode ),
                new KeyValuePair<string, object>( "pagesize", input.Pagesize )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

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
        /// Remove a purchased Ytel number from your account.
        /// </summary>
        /// <param name="Models.MassReleaseNumberInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string MassReleaseNumber(Models.MassReleaseNumberInput input)
        {
            Task<string> t = MassReleaseNumberAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Remove a purchased Ytel number from your account.
        /// </summary>
        /// <param name="Models.MassReleaseNumberInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> MassReleaseNumberAsync(Models.MassReleaseNumberInput input)
        {
            //validating required parameters
            if (null == input.PhoneNumber)
                throw new ArgumentNullException("phoneNumber", "The property \"PhoneNumber\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/incomingphone/massreleasenumber.{ResponseType}");

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
                { "user-agent", "ytel-api" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "PhoneNumber", input.PhoneNumber )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

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
        /// Retrieve the details for a phone number by its number.
        /// </summary>
        /// <param name="Models.ViewNumberDetailsInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string ViewNumberDetails(Models.ViewNumberDetailsInput input)
        {
            Task<string> t = ViewNumberDetailsAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve the details for a phone number by its number.
        /// </summary>
        /// <param name="Models.ViewNumberDetailsInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> ViewNumberDetailsAsync(Models.ViewNumberDetailsInput input)
        {
            //validating required parameters
            if (null == input.PhoneNumber)
                throw new ArgumentNullException("phoneNumber", "The property \"PhoneNumber\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
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
                { "user-agent", "ytel-api" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "PhoneNumber", input.PhoneNumber )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

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
        /// Remove a purchased Ytel number from your account.
        /// </summary>
        /// <param name="Models.ReleaseNumberInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string ReleaseNumber(Models.ReleaseNumberInput input)
        {
            Task<string> t = ReleaseNumberAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Remove a purchased Ytel number from your account.
        /// </summary>
        /// <param name="Models.ReleaseNumberInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> ReleaseNumberAsync(Models.ReleaseNumberInput input)
        {
            //validating required parameters
            if (null == input.PhoneNumber)
                throw new ArgumentNullException("phoneNumber", "The property \"PhoneNumber\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
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
                { "user-agent", "ytel-api" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "PhoneNumber", input.PhoneNumber )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

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
        /// Purchase a phone number to be used with your Ytel account
        /// </summary>
        /// <param name="Models.BuyNumberInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string BuyNumber(Models.BuyNumberInput input)
        {
            Task<string> t = BuyNumberAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Purchase a phone number to be used with your Ytel account
        /// </summary>
        /// <param name="Models.BuyNumberInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> BuyNumberAsync(Models.BuyNumberInput input)
        {
            //validating required parameters
            if (null == input.PhoneNumber)
                throw new ArgumentNullException("phoneNumber", "The property \"PhoneNumber\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
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
                { "user-agent", "ytel-api" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "PhoneNumber", input.PhoneNumber )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

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
        /// Update properties for a Ytel number that has been purchased for your account. Refer to the parameters list for the list of properties that can be updated.
        /// </summary>
        /// <param name="Models.UpdatePhoneNumberInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string UpdatePhoneNumber(Models.UpdatePhoneNumberInput input)
        {
            Task<string> t = UpdatePhoneNumberAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Update properties for a Ytel number that has been purchased for your account. Refer to the parameters list for the list of properties that can be updated.
        /// </summary>
        /// <param name="Models.UpdatePhoneNumberInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> UpdatePhoneNumberAsync(Models.UpdatePhoneNumberInput input)
        {
            //validating required parameters
            if (null == input.PhoneNumber)
                throw new ArgumentNullException("phoneNumber", "The property \"PhoneNumber\" in the input object cannot be null.");

            if (null == input.VoiceUrl)
                throw new ArgumentNullException("voiceUrl", "The property \"VoiceUrl\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
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
                { "user-agent", "ytel-api" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "PhoneNumber", input.PhoneNumber ),
                new KeyValuePair<string, object>( "VoiceUrl", input.VoiceUrl ),
                new KeyValuePair<string, object>( "FriendlyName", input.FriendlyName ),
                new KeyValuePair<string, object>( "VoiceMethod", (input.VoiceMethod.HasValue) ? Models.HttpActionEnumHelper.ToValue(input.VoiceMethod.Value) : null ),
                new KeyValuePair<string, object>( "VoiceFallbackUrl", input.VoiceFallbackUrl ),
                new KeyValuePair<string, object>( "VoiceFallbackMethod", (input.VoiceFallbackMethod.HasValue) ? Models.HttpActionEnumHelper.ToValue(input.VoiceFallbackMethod.Value) : null ),
                new KeyValuePair<string, object>( "HangupCallback", input.HangupCallback ),
                new KeyValuePair<string, object>( "HangupCallbackMethod", (input.HangupCallbackMethod.HasValue) ? Models.HttpActionEnumHelper.ToValue(input.HangupCallbackMethod.Value) : null ),
                new KeyValuePair<string, object>( "HeartbeatUrl", input.HeartbeatUrl ),
                new KeyValuePair<string, object>( "HeartbeatMethod", (input.HeartbeatMethod.HasValue) ? Models.HttpActionEnumHelper.ToValue(input.HeartbeatMethod.Value) : null ),
                new KeyValuePair<string, object>( "SmsUrl", input.SmsUrl ),
                new KeyValuePair<string, object>( "SmsMethod", (input.SmsMethod.HasValue) ? Models.HttpActionEnumHelper.ToValue(input.SmsMethod.Value) : null ),
                new KeyValuePair<string, object>( "SmsFallbackUrl", input.SmsFallbackUrl ),
                new KeyValuePair<string, object>( "SmsFallbackMethod", (input.SmsFallbackMethod.HasValue) ? Models.HttpActionEnumHelper.ToValue(input.SmsFallbackMethod.Value) : null )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

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
        /// Transfer phone number that has been purchased for from one account to another account.
        /// </summary>
        /// <param name="Models.TransferNumberInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string TransferNumber(Models.TransferNumberInput input)
        {
            Task<string> t = TransferNumberAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Transfer phone number that has been purchased for from one account to another account.
        /// </summary>
        /// <param name="Models.TransferNumberInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> TransferNumberAsync(Models.TransferNumberInput input)
        {
            //validating required parameters
            if (null == input.Phonenumber)
                throw new ArgumentNullException("phonenumber", "The property \"Phonenumber\" in the input object cannot be null.");

            if (null == input.Fromaccountsid)
                throw new ArgumentNullException("fromaccountsid", "The property \"Fromaccountsid\" in the input object cannot be null.");

            if (null == input.Toaccountsid)
                throw new ArgumentNullException("toaccountsid", "The property \"Toaccountsid\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/incomingphone/transferphonenumbers.{ResponseType}");

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
                { "user-agent", "ytel-api" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "phonenumber", input.Phonenumber ),
                new KeyValuePair<string, object>( "fromaccountsid", input.Fromaccountsid ),
                new KeyValuePair<string, object>( "toaccountsid", input.Toaccountsid )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

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
        /// Retrieve a list of purchased phones numbers associated with your Ytel account.
        /// </summary>
        /// <param name="Models.ListNumberInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string ListNumber(Models.ListNumberInput input)
        {
            Task<string> t = ListNumberAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a list of purchased phones numbers associated with your Ytel account.
        /// </summary>
        /// <param name="Models.ListNumberInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> ListNumberAsync(Models.ListNumberInput input)
        {
            //validating required parameters
            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
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
                { "user-agent", "ytel-api" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "Page", input.Page ),
                new KeyValuePair<string, object>( "PageSize", input.PageSize ),
                new KeyValuePair<string, object>( "NumberType", (input.NumberType.HasValue) ? Models.NumberTypeEnumHelper.ToValue(input.NumberType.Value) : null ),
                new KeyValuePair<string, object>( "FriendlyName", input.FriendlyName )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

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
        /// Update properties for a Ytel numbers that has been purchased for your account. Refer to the parameters list for the list of properties that can be updated.
        /// </summary>
        /// <param name="Models.MassUpdateNumberInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string MassUpdateNumber(Models.MassUpdateNumberInput input)
        {
            Task<string> t = MassUpdateNumberAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Update properties for a Ytel numbers that has been purchased for your account. Refer to the parameters list for the list of properties that can be updated.
        /// </summary>
        /// <param name="Models.MassUpdateNumberInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> MassUpdateNumberAsync(Models.MassUpdateNumberInput input)
        {
            //validating required parameters
            if (null == input.PhoneNumber)
                throw new ArgumentNullException("phoneNumber", "The property \"PhoneNumber\" in the input object cannot be null.");

            if (null == input.VoiceUrl)
                throw new ArgumentNullException("voiceUrl", "The property \"VoiceUrl\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/incomingphone/massupdatenumber.{ResponseType}");

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
                { "user-agent", "ytel-api" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "PhoneNumber", input.PhoneNumber ),
                new KeyValuePair<string, object>( "VoiceUrl", input.VoiceUrl ),
                new KeyValuePair<string, object>( "FriendlyName", input.FriendlyName ),
                new KeyValuePair<string, object>( "VoiceMethod", (input.VoiceMethod.HasValue) ? Models.HttpActionEnumHelper.ToValue(input.VoiceMethod.Value) : null ),
                new KeyValuePair<string, object>( "VoiceFallbackUrl", input.VoiceFallbackUrl ),
                new KeyValuePair<string, object>( "VoiceFallbackMethod", (input.VoiceFallbackMethod.HasValue) ? Models.HttpActionEnumHelper.ToValue(input.VoiceFallbackMethod.Value) : null ),
                new KeyValuePair<string, object>( "HangupCallback", input.HangupCallback ),
                new KeyValuePair<string, object>( "HangupCallbackMethod", (input.HangupCallbackMethod.HasValue) ? Models.HttpActionEnumHelper.ToValue(input.HangupCallbackMethod.Value) : null ),
                new KeyValuePair<string, object>( "HeartbeatUrl", input.HeartbeatUrl ),
                new KeyValuePair<string, object>( "HeartbeatMethod", (input.HeartbeatMethod.HasValue) ? Models.HttpActionEnumHelper.ToValue(input.HeartbeatMethod.Value) : null ),
                new KeyValuePair<string, object>( "SmsUrl", input.SmsUrl ),
                new KeyValuePair<string, object>( "SmsMethod", (input.SmsMethod.HasValue) ? Models.HttpActionEnumHelper.ToValue(input.SmsMethod.Value) : null ),
                new KeyValuePair<string, object>( "SmsFallbackUrl", input.SmsFallbackUrl ),
                new KeyValuePair<string, object>( "SmsFallbackMethod", (input.SmsFallbackMethod.HasValue) ? Models.HttpActionEnumHelper.ToValue(input.SmsFallbackMethod.Value) : null )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

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
        /// Get DID Score Number
        /// </summary>
        /// <param name="Models.GetDIDScoreNumberInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string GetDIDScoreNumber(Models.GetDIDScoreNumberInput input)
        {
            Task<string> t = GetDIDScoreNumberAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get DID Score Number
        /// </summary>
        /// <param name="Models.GetDIDScoreNumberInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetDIDScoreNumberAsync(Models.GetDIDScoreNumberInput input)
        {
            //validating required parameters
            if (null == input.Phonenumber)
                throw new ArgumentNullException("phonenumber", "The property \"Phonenumber\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/incomingphone/getdidscore.{ResponseType}");

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
                { "user-agent", "ytel-api" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "Phonenumber", input.Phonenumber )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

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
        /// Purchase a selected number of DID's from specific area codes to be used with your Ytel account.
        /// </summary>
        /// <param name="Models.BulkBuyNumberInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string BulkBuyNumber(Models.BulkBuyNumberInput input)
        {
            Task<string> t = BulkBuyNumberAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Purchase a selected number of DID's from specific area codes to be used with your Ytel account.
        /// </summary>
        /// <param name="Models.BulkBuyNumberInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> BulkBuyNumberAsync(Models.BulkBuyNumberInput input)
        {
            //validating required parameters
            if (null == input.AreaCode)
                throw new ArgumentNullException("areaCode", "The property \"AreaCode\" in the input object cannot be null.");

            if (null == input.Quantity)
                throw new ArgumentNullException("quantity", "The property \"Quantity\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/incomingphone/bulkbuy.{ResponseType}");

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
                { "user-agent", "ytel-api" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "NumberType", Models.NumberTypeEnumHelper.ToValue(input.NumberType) ),
                new KeyValuePair<string, object>( "AreaCode", input.AreaCode ),
                new KeyValuePair<string, object>( "Quantity", input.Quantity ),
                new KeyValuePair<string, object>( "Leftover", input.Leftover )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

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