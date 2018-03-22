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
    public partial class TranscriptionController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static TranscriptionController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static TranscriptionController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new TranscriptionController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Retrieve information about a transaction by its TranscriptionSid.
        /// </summary>
        /// <param name="Models.ViewTranscriptionInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string ViewTranscription(Models.ViewTranscriptionInput input)
        {
            Task<string> t = ViewTranscriptionAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve information about a transaction by its TranscriptionSid.
        /// </summary>
        /// <param name="Models.ViewTranscriptionInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> ViewTranscriptionAsync(Models.ViewTranscriptionInput input)
        {
            //validating required parameters
            if (null == input.Transcriptionsid)
                throw new ArgumentNullException("transcriptionsid", "The property \"Transcriptionsid\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/transcriptions/viewtranscription.{ResponseType}");

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
                new KeyValuePair<string, object>( "transcriptionsid", input.Transcriptionsid )
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
        /// Transcribe a message360 recording by its RecordingSid.
        /// </summary>
        /// <param name="Models.RecordingTranscriptionInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string RecordingTranscription(Models.RecordingTranscriptionInput input)
        {
            Task<string> t = RecordingTranscriptionAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Transcribe a message360 recording by its RecordingSid.
        /// </summary>
        /// <param name="Models.RecordingTranscriptionInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> RecordingTranscriptionAsync(Models.RecordingTranscriptionInput input)
        {
            //validating required parameters
            if (null == input.RecordingSid)
                throw new ArgumentNullException("recordingSid", "The property \"RecordingSid\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/transcriptions/recordingtranscription.{ResponseType}");

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
                new KeyValuePair<string, object>( "recordingSid", input.RecordingSid )
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
        /// Transcribe an audio recording from a file.
        /// </summary>
        /// <param name="Models.AudioURLTranscriptionInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string AudioURLTranscription(Models.AudioURLTranscriptionInput input)
        {
            Task<string> t = AudioURLTranscriptionAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Transcribe an audio recording from a file.
        /// </summary>
        /// <param name="Models.AudioURLTranscriptionInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> AudioURLTranscriptionAsync(Models.AudioURLTranscriptionInput input)
        {
            //validating required parameters
            if (null == input.Audiourl)
                throw new ArgumentNullException("audiourl", "The property \"Audiourl\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/transcriptions/audiourltranscription.{ResponseType}");

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
                new KeyValuePair<string, object>( "audiourl", input.Audiourl )
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
        /// Retrieve a list of transcription objects for your Ytel account.
        /// </summary>
        /// <param name="Models.ListTranscriptionInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string ListTranscription(Models.ListTranscriptionInput input)
        {
            Task<string> t = ListTranscriptionAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a list of transcription objects for your Ytel account.
        /// </summary>
        /// <param name="Models.ListTranscriptionInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> ListTranscriptionAsync(Models.ListTranscriptionInput input)
        {
            //validating required parameters
            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/transcriptions/listtranscription.{ResponseType}");

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
                new KeyValuePair<string, object>( "status", (input.Status.HasValue) ? Models.StatusEnumHelper.ToValue(input.Status.Value) : null ),
                new KeyValuePair<string, object>( "dateTranscribed", input.DateTranscribed )
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