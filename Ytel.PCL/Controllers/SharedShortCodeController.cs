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
    public partial class SharedShortCodeController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static SharedShortCodeController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static SharedShortCodeController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new SharedShortCodeController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// View a Shared ShortCode Template
        /// </summary>
        /// <param name="Models.ViewTemplateInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string ViewTemplate(Models.ViewTemplateInput input)
        {
            Task<string> t = ViewTemplateAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// View a Shared ShortCode Template
        /// </summary>
        /// <param name="Models.ViewTemplateInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> ViewTemplateAsync(Models.ViewTemplateInput input)
        {
            //validating required parameters
            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/template/view.{ResponseType}");

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
                new KeyValuePair<string, object>( "TemplateId", input.TemplateId )
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
        /// View a ShortCode Message
        /// </summary>
        /// <param name="Models.ViewSharedShortcodesInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string ViewSharedShortcodes(Models.ViewSharedShortcodesInput input)
        {
            Task<string> t = ViewSharedShortcodesAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// View a ShortCode Message
        /// </summary>
        /// <param name="Models.ViewSharedShortcodesInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> ViewSharedShortcodesAsync(Models.ViewSharedShortcodesInput input)
        {
            //validating required parameters
            if (null == input.Messagesid)
                throw new ArgumentNullException("messagesid", "The property \"Messagesid\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/shortcode/viewsms.{ResponseType}");

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
                new KeyValuePair<string, object>( "messagesid", input.Messagesid )
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
        /// List ShortCode Messages
        /// </summary>
        /// <param name="Models.ListOutboundSharedShortcodesInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string ListOutboundSharedShortcodes(Models.ListOutboundSharedShortcodesInput input)
        {
            Task<string> t = ListOutboundSharedShortcodesAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// List ShortCode Messages
        /// </summary>
        /// <param name="Models.ListOutboundSharedShortcodesInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> ListOutboundSharedShortcodesAsync(Models.ListOutboundSharedShortcodesInput input)
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
                new KeyValuePair<string, object>( "page", input.Page ),
                new KeyValuePair<string, object>( "pagesize", input.Pagesize ),
                new KeyValuePair<string, object>( "Shortcode", input.Shortcode ),
                new KeyValuePair<string, object>( "to", input.To ),
                new KeyValuePair<string, object>( "datesent", input.Datesent )
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
        /// List All Inbound ShortCode
        /// </summary>
        /// <param name="Models.ListInboundSharedShortcodesInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string ListInboundSharedShortcodes(Models.ListInboundSharedShortcodesInput input)
        {
            Task<string> t = ListInboundSharedShortcodesAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// List All Inbound ShortCode
        /// </summary>
        /// <param name="Models.ListInboundSharedShortcodesInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> ListInboundSharedShortcodesAsync(Models.ListInboundSharedShortcodesInput input)
        {
            //validating required parameters
            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/shortcode/getinboundsms.{ResponseType}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "ResponseType", input.ResponseType }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "Datecreated", input.Datecreated }
            },ArrayDeserializationFormat,ParameterSeparator);


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
                new KeyValuePair<string, object>( "from", input.From ),
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
        /// Send an SMS from a Ytel ShortCode
        /// </summary>
        /// <param name="Models.SendSharedShortcodeInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string SendSharedShortcode(Models.SendSharedShortcodeInput input)
        {
            Task<string> t = SendSharedShortcodeAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Send an SMS from a Ytel ShortCode
        /// </summary>
        /// <param name="Models.SendSharedShortcodeInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> SendSharedShortcodeAsync(Models.SendSharedShortcodeInput input)
        {
            //validating required parameters
            if (null == input.Shortcode)
                throw new ArgumentNullException("shortcode", "The property \"Shortcode\" in the input object cannot be null.");

            if (null == input.To)
                throw new ArgumentNullException("to", "The property \"To\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            if (null == input.Data)
                throw new ArgumentNullException("data", "The property \"Data\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/shortcode/sendsms.{ResponseType}");

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
                new KeyValuePair<string, object>( "templateid", input.Templateid ),
                new KeyValuePair<string, object>( "data", input.Data ),
                new KeyValuePair<string, object>( "Method", (input.Method.HasValue) ? Models.HttpActionEnumHelper.ToValue(input.Method.Value) : "GET" ),
                new KeyValuePair<string, object>( "MessageStatusCallback", input.MessageStatusCallback )
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
        /// List Shortcode Templates by Type
        /// </summary>
        /// <param name="Models.ListTemplatesInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string ListTemplates(Models.ListTemplatesInput input)
        {
            Task<string> t = ListTemplatesAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// List Shortcode Templates by Type
        /// </summary>
        /// <param name="Models.ListTemplatesInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> ListTemplatesAsync(Models.ListTemplatesInput input)
        {
            //validating required parameters
            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/template/lists.{ResponseType}");

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
                new KeyValuePair<string, object>( "type", input.Type ),
                new KeyValuePair<string, object>( "page", input.Page ),
                new KeyValuePair<string, object>( "pagesize", input.Pagesize ),
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
        /// View a set of properties for a single keyword.
        /// </summary>
        /// <param name="Models.ViewKeywordInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string ViewKeyword(Models.ViewKeywordInput input)
        {
            Task<string> t = ViewKeywordAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// View a set of properties for a single keyword.
        /// </summary>
        /// <param name="Models.ViewKeywordInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> ViewKeywordAsync(Models.ViewKeywordInput input)
        {
            //validating required parameters
            if (null == input.Keywordid)
                throw new ArgumentNullException("keywordid", "The property \"Keywordid\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/keyword/view.{ResponseType}");

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
                new KeyValuePair<string, object>( "Keywordid", input.Keywordid )
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
        /// Retrieve a list of keywords associated with your Ytel account.
        /// </summary>
        /// <param name="Models.ListKeywordInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string ListKeyword(Models.ListKeywordInput input)
        {
            Task<string> t = ListKeywordAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a list of keywords associated with your Ytel account.
        /// </summary>
        /// <param name="Models.ListKeywordInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> ListKeywordAsync(Models.ListKeywordInput input)
        {
            //validating required parameters
            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/keyword/lists.{ResponseType}");

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
                new KeyValuePair<string, object>( "Keyword", input.Keyword ),
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
        /// The response returned here contains all resource properties associated with the given Shortcode.
        /// </summary>
        /// <param name="Models.ViewAssignementInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string ViewAssignement(Models.ViewAssignementInput input)
        {
            Task<string> t = ViewAssignementAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// The response returned here contains all resource properties associated with the given Shortcode.
        /// </summary>
        /// <param name="Models.ViewAssignementInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> ViewAssignementAsync(Models.ViewAssignementInput input)
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
            _queryBuilder.Append("/shortcode/viewshortcode.{ResponseType}");

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
        /// Retrieve a list of shortcode assignment associated with your Ytel account.
        /// </summary>
        /// <param name="Models.ListAssignmentInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string ListAssignment(Models.ListAssignmentInput input)
        {
            Task<string> t = ListAssignmentAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a list of shortcode assignment associated with your Ytel account.
        /// </summary>
        /// <param name="Models.ListAssignmentInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> ListAssignmentAsync(Models.ListAssignmentInput input)
        {
            //validating required parameters
            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/shortcode/listshortcode.{ResponseType}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "ResponseType", input.ResponseType }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "Shortcode", input.Shortcode }
            },ArrayDeserializationFormat,ParameterSeparator);


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
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="Models.UpdateAssignmentInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string UpdateAssignment(Models.UpdateAssignmentInput input)
        {
            Task<string> t = UpdateAssignmentAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="Models.UpdateAssignmentInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> UpdateAssignmentAsync(Models.UpdateAssignmentInput input)
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
            _queryBuilder.Append("/shortcode/updateshortcode.{ResponseType}");

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
                new KeyValuePair<string, object>( "CallbackUrl", input.CallbackUrl ),
                new KeyValuePair<string, object>( "CallbackMethod", (input.CallbackMethod.HasValue) ? Models.HttpActionEnumHelper.ToValue(input.CallbackMethod.Value) : null ),
                new KeyValuePair<string, object>( "FallbackUrl", input.FallbackUrl ),
                new KeyValuePair<string, object>( "FallbackUrlMethod", (input.FallbackUrlMethod.HasValue) ? Models.HttpActionEnumHelper.ToValue(input.FallbackUrlMethod.Value) : null )
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