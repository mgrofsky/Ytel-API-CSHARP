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
    public partial class AreaMailController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static AreaMailController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static AreaMailController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new AreaMailController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Create a new AreaMail object.
        /// </summary>
        /// <param name="Models.CreateAreaMailInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateAreaMail(Models.CreateAreaMailInput input)
        {
            Task<string> t = CreateAreaMailAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Create a new AreaMail object.
        /// </summary>
        /// <param name="Models.CreateAreaMailInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateAreaMailAsync(Models.CreateAreaMailInput input)
        {
            //validating required parameters
            if (null == input.Routes)
                throw new ArgumentNullException("routes", "The property \"Routes\" in the input object cannot be null.");

            if (null == input.Attachbyid)
                throw new ArgumentNullException("attachbyid", "The property \"Attachbyid\" in the input object cannot be null.");

            if (null == input.Front)
                throw new ArgumentNullException("front", "The property \"Front\" in the input object cannot be null.");

            if (null == input.Back)
                throw new ArgumentNullException("back", "The property \"Back\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/areamail/create.{ResponseType}");

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
                new KeyValuePair<string, object>( "routes", input.Routes ),
                new KeyValuePair<string, object>( "attachbyid", input.Attachbyid ),
                new KeyValuePair<string, object>( "front", input.Front ),
                new KeyValuePair<string, object>( "back", input.Back ),
                new KeyValuePair<string, object>( "description", input.Description ),
                new KeyValuePair<string, object>( "targettype", input.Targettype ),
                new KeyValuePair<string, object>( "htmldata", input.Htmldata )
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
        /// Retrieve an AreaMail object by its AreaMailId.
        /// </summary>
        /// <param name="Models.ViewAreaMailInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string ViewAreaMail(Models.ViewAreaMailInput input)
        {
            Task<string> t = ViewAreaMailAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve an AreaMail object by its AreaMailId.
        /// </summary>
        /// <param name="Models.ViewAreaMailInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> ViewAreaMailAsync(Models.ViewAreaMailInput input)
        {
            //validating required parameters
            if (null == input.Areamailid)
                throw new ArgumentNullException("areamailid", "The property \"Areamailid\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/areamail/view.{ResponseType}");

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
                new KeyValuePair<string, object>( "areamailid", input.Areamailid )
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
        /// Retrieve a list of AreaMail objects.
        /// </summary>
        /// <param name="Models.ListAreaMailInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string ListAreaMail(Models.ListAreaMailInput input)
        {
            Task<string> t = ListAreaMailAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a list of AreaMail objects.
        /// </summary>
        /// <param name="Models.ListAreaMailInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> ListAreaMailAsync(Models.ListAreaMailInput input)
        {
            //validating required parameters
            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/areamail/lists.{ResponseType}");

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
                new KeyValuePair<string, object>( "areamailsid", input.Areamailsid ),
                new KeyValuePair<string, object>( "dateCreated", input.DateCreated )
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
        /// Remove an AreaMail object by its AreaMailId.
        /// </summary>
        /// <param name="Models.DeleteAreaMailInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string DeleteAreaMail(Models.DeleteAreaMailInput input)
        {
            Task<string> t = DeleteAreaMailAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Remove an AreaMail object by its AreaMailId.
        /// </summary>
        /// <param name="Models.DeleteAreaMailInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> DeleteAreaMailAsync(Models.DeleteAreaMailInput input)
        {
            //validating required parameters
            if (null == input.Areamailid)
                throw new ArgumentNullException("areamailid", "The property \"Areamailid\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/areamail/delete.{ResponseType}");

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
                new KeyValuePair<string, object>( "areamailid", input.Areamailid )
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