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
    public partial class ShortCodeController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static ShortCodeController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static ShortCodeController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new ShortCodeController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="Models.SendDedicatedShortcodeInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string SendDedicatedShortcode(Models.SendDedicatedShortcodeInput input)
        {
            Task<string> t = SendDedicatedShortcodeAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="Models.SendDedicatedShortcodeInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> SendDedicatedShortcodeAsync(Models.SendDedicatedShortcodeInput input)
        {
            //validating required parameters
            if (null == input.Body)
                throw new ArgumentNullException("body", "The property \"Body\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/dedicatedshortcode/sendsms.{ResponseType}");

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
                new KeyValuePair<string, object>( "shortcode", input.Shortcode ),
                new KeyValuePair<string, object>( "to", input.To ),
                new KeyValuePair<string, object>( "body", input.Body ),
                new KeyValuePair<string, object>( "method", (input.Method.HasValue) ? Models.HttpActionEnumHelper.ToValue(input.Method.Value) : null ),
                new KeyValuePair<string, object>( "messagestatuscallback", input.Messagestatuscallback )
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
        /// View a single Sms Short Code message.
        /// </summary>
        /// <param name="Models.ViewShortcodeInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string ViewShortcode(Models.ViewShortcodeInput input)
        {
            Task<string> t = ViewShortcodeAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// View a single Sms Short Code message.
        /// </summary>
        /// <param name="Models.ViewShortcodeInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> ViewShortcodeAsync(Models.ViewShortcodeInput input)
        {
            //validating required parameters
            if (null == input.MessageSid)
                throw new ArgumentNullException("messageSid", "The property \"MessageSid\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/shortcode/viewsms..{ResponseType}");

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
                new KeyValuePair<string, object>( "MessageSid", input.MessageSid )
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
        /// Retrieve a list of Short Code message objects.
        /// </summary>
        /// <param name="Models.ListShortcodeInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string ListShortcode(Models.ListShortcodeInput input)
        {
            Task<string> t = ListShortcodeAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a list of Short Code message objects.
        /// </summary>
        /// <param name="Models.ListShortcodeInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> ListShortcodeAsync(Models.ListShortcodeInput input)
        {
            //validating required parameters
            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/shortcode/listsms.{ResponseType}");

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
                new KeyValuePair<string, object>( "Shortcode", input.Shortcode ),
                new KeyValuePair<string, object>( "To", input.To ),
                new KeyValuePair<string, object>( "DateSent", input.DateSent ),
                new KeyValuePair<string, object>( "Page", input.Page ),
                new KeyValuePair<string, object>( "PageSize", input.PageSize )
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
        /// Retrive a list of inbound Sms Short Code messages associated with your Ytel account.
        /// </summary>
        /// <param name="Models.ListInboundShortcodeInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string ListInboundShortcode(Models.ListInboundShortcodeInput input)
        {
            Task<string> t = ListInboundShortcodeAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrive a list of inbound Sms Short Code messages associated with your Ytel account.
        /// </summary>
        /// <param name="Models.ListInboundShortcodeInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> ListInboundShortcodeAsync(Models.ListInboundShortcodeInput input)
        {
            //validating required parameters
            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/dedicatedshortcode/getinboundsms.{ResponseType}");

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
                new KeyValuePair<string, object>( "page", input.Page ),
                new KeyValuePair<string, object>( "pagesize", input.Pagesize ),
                new KeyValuePair<string, object>( "From", input.From ),
                new KeyValuePair<string, object>( "Shortcode", input.Shortcode ),
                new KeyValuePair<string, object>( "Datecreated", input.Datecreated )
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
        /// Retrieve a single Short Code object by its shortcode assignment.
        /// </summary>
        /// <param name="Models.ViewDedicatedShortcodeAssignmentInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string ViewDedicatedShortcodeAssignment(Models.ViewDedicatedShortcodeAssignmentInput input)
        {
            Task<string> t = ViewDedicatedShortcodeAssignmentAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a single Short Code object by its shortcode assignment.
        /// </summary>
        /// <param name="Models.ViewDedicatedShortcodeAssignmentInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> ViewDedicatedShortcodeAssignmentAsync(Models.ViewDedicatedShortcodeAssignmentInput input)
        {
            //validating required parameters
            if (null == input.Shortcode)
                throw new ArgumentNullException("shortcode", "The property \"Shortcode\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/dedicatedshortcode/viewshortcode.{ResponseType}");

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
                new KeyValuePair<string, object>( "Shortcode", input.Shortcode )
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
        /// Update a dedicated shortcode.
        /// </summary>
        /// <param name="Models.UpdateDedicatedShortCodeAssignmentInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string UpdateDedicatedShortCodeAssignment(Models.UpdateDedicatedShortCodeAssignmentInput input)
        {
            Task<string> t = UpdateDedicatedShortCodeAssignmentAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Update a dedicated shortcode.
        /// </summary>
        /// <param name="Models.UpdateDedicatedShortCodeAssignmentInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> UpdateDedicatedShortCodeAssignmentAsync(Models.UpdateDedicatedShortCodeAssignmentInput input)
        {
            //validating required parameters
            if (null == input.Shortcode)
                throw new ArgumentNullException("shortcode", "The property \"Shortcode\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/dedicatedshortcode/updateshortcode.{ResponseType}");

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
                new KeyValuePair<string, object>( "Shortcode", input.Shortcode ),
                new KeyValuePair<string, object>( "FriendlyName", input.FriendlyName ),
                new KeyValuePair<string, object>( "CallbackMethod", input.CallbackMethod ),
                new KeyValuePair<string, object>( "CallbackUrl", input.CallbackUrl ),
                new KeyValuePair<string, object>( "FallbackMethod", input.FallbackMethod ),
                new KeyValuePair<string, object>( "FallbackUrl", input.FallbackUrl )
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
        /// Retrieve a list of Short Code assignment associated with your Ytel account.
        /// </summary>
        /// <param name="Models.ListShortCodeAssignmentInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string ListShortCodeAssignment(Models.ListShortCodeAssignmentInput input)
        {
            Task<string> t = ListShortCodeAssignmentAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a list of Short Code assignment associated with your Ytel account.
        /// </summary>
        /// <param name="Models.ListShortCodeAssignmentInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> ListShortCodeAssignmentAsync(Models.ListShortCodeAssignmentInput input)
        {
            //validating required parameters
            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/dedicatedshortcode/listshortcode.{ResponseType}");

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
                new KeyValuePair<string, object>( "Shortcode", input.Shortcode ),
                new KeyValuePair<string, object>( "page", input.Page ),
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

    }
} 