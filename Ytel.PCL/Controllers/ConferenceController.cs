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
    public partial class ConferenceController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static ConferenceController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static ConferenceController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new ConferenceController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Deaf Mute Participant
        /// </summary>
        /// <param name="Models.DeafMuteParticipantInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string DeafMuteParticipant(Models.DeafMuteParticipantInput input)
        {
            Task<string> t = DeafMuteParticipantAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Deaf Mute Participant
        /// </summary>
        /// <param name="Models.DeafMuteParticipantInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> DeafMuteParticipantAsync(Models.DeafMuteParticipantInput input)
        {
            //validating required parameters
            if (null == input.ConferenceSid)
                throw new ArgumentNullException("conferenceSid", "The property \"ConferenceSid\" in the input object cannot be null.");

            if (null == input.ParticipantSid)
                throw new ArgumentNullException("participantSid", "The property \"ParticipantSid\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/conferences/deafMuteParticipant.{ResponseType}");

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
                new KeyValuePair<string, object>( "conferenceSid", input.ConferenceSid ),
                new KeyValuePair<string, object>( "ParticipantSid", input.ParticipantSid ),
                new KeyValuePair<string, object>( "Muted", input.Muted ),
                new KeyValuePair<string, object>( "Deaf", input.Deaf )
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
        /// Retrieve information about a participant by its ParticipantSid.
        /// </summary>
        /// <param name="Models.ViewParticipantInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string ViewParticipant(Models.ViewParticipantInput input)
        {
            Task<string> t = ViewParticipantAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve information about a participant by its ParticipantSid.
        /// </summary>
        /// <param name="Models.ViewParticipantInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> ViewParticipantAsync(Models.ViewParticipantInput input)
        {
            //validating required parameters
            if (null == input.ConferenceSid)
                throw new ArgumentNullException("conferenceSid", "The property \"ConferenceSid\" in the input object cannot be null.");

            if (null == input.ParticipantSid)
                throw new ArgumentNullException("participantSid", "The property \"ParticipantSid\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/conferences/viewParticipant.{ResponseType}");

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
                new KeyValuePair<string, object>( "ConferenceSid", input.ConferenceSid ),
                new KeyValuePair<string, object>( "ParticipantSid", input.ParticipantSid )
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
        /// Retrieve information about a conference by its ConferenceSid.
        /// </summary>
        /// <param name="Models.ViewConferenceInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string ViewConference(Models.ViewConferenceInput input)
        {
            Task<string> t = ViewConferenceAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve information about a conference by its ConferenceSid.
        /// </summary>
        /// <param name="Models.ViewConferenceInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> ViewConferenceAsync(Models.ViewConferenceInput input)
        {
            //validating required parameters
            if (null == input.ConferenceSid)
                throw new ArgumentNullException("conferenceSid", "The property \"ConferenceSid\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/conferences/viewconference.{ResponseType}");

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
                new KeyValuePair<string, object>( "ConferenceSid", input.ConferenceSid )
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
        /// Add Participant in conference 
        /// </summary>
        /// <param name="Models.AddParticipantInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string AddParticipant(Models.AddParticipantInput input)
        {
            Task<string> t = AddParticipantAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Add Participant in conference 
        /// </summary>
        /// <param name="Models.AddParticipantInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> AddParticipantAsync(Models.AddParticipantInput input)
        {
            //validating required parameters
            if (null == input.ConferenceSid)
                throw new ArgumentNullException("conferenceSid", "The property \"ConferenceSid\" in the input object cannot be null.");

            if (null == input.ParticipantNumber)
                throw new ArgumentNullException("participantNumber", "The property \"ParticipantNumber\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/conferences/addParticipant.{ResponseType}");

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
                new KeyValuePair<string, object>( "ConferenceSid", input.ConferenceSid ),
                new KeyValuePair<string, object>( "ParticipantNumber", input.ParticipantNumber ),
                new KeyValuePair<string, object>( "Muted", input.Muted ),
                new KeyValuePair<string, object>( "Deaf", input.Deaf )
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
        /// Here you can experiment with initiating a conference call through Ytel and view the request response generated when doing so.
        /// </summary>
        /// <param name="Models.CreateConferenceInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateConference(Models.CreateConferenceInput input)
        {
            Task<string> t = CreateConferenceAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Here you can experiment with initiating a conference call through Ytel and view the request response generated when doing so.
        /// </summary>
        /// <param name="Models.CreateConferenceInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateConferenceAsync(Models.CreateConferenceInput input)
        {
            //validating required parameters
            if (null == input.From)
                throw new ArgumentNullException("mfrom", "The property \"From\" in the input object cannot be null.");

            if (null == input.To)
                throw new ArgumentNullException("to", "The property \"To\" in the input object cannot be null.");

            if (null == input.Url)
                throw new ArgumentNullException("url", "The property \"Url\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/conferences/createConference.{ResponseType}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "ResponseType", input.ResponseType }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "Url", input.Url }
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
                new KeyValuePair<string, object>( "From", input.From ),
                new KeyValuePair<string, object>( "To", input.To ),
                new KeyValuePair<string, object>( "Method", (input.Method.HasValue) ? Models.HttpActionEnumHelper.ToValue(input.Method.Value) : "POST" ),
                new KeyValuePair<string, object>( "StatusCallBackUrl", input.StatusCallBackUrl ),
                new KeyValuePair<string, object>( "StatusCallBackMethod", (input.StatusCallBackMethod.HasValue) ? Models.HttpActionEnumHelper.ToValue(input.StatusCallBackMethod.Value) : null ),
                new KeyValuePair<string, object>( "FallbackUrl", input.FallbackUrl ),
                new KeyValuePair<string, object>( "FallbackMethod", (input.FallbackMethod.HasValue) ? Models.HttpActionEnumHelper.ToValue(input.FallbackMethod.Value) : null ),
                new KeyValuePair<string, object>( "Record", input.Record ),
                new KeyValuePair<string, object>( "RecordCallBackUrl", input.RecordCallBackUrl ),
                new KeyValuePair<string, object>( "RecordCallBackMethod", (input.RecordCallBackMethod.HasValue) ? Models.HttpActionEnumHelper.ToValue(input.RecordCallBackMethod.Value) : null ),
                new KeyValuePair<string, object>( "ScheduleTime", input.ScheduleTime ),
                new KeyValuePair<string, object>( "Timeout", input.Timeout )
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
        /// Remove a participant from a conference.
        /// </summary>
        /// <param name="Models.HangupParticipantInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string HangupParticipant(Models.HangupParticipantInput input)
        {
            Task<string> t = HangupParticipantAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Remove a participant from a conference.
        /// </summary>
        /// <param name="Models.HangupParticipantInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> HangupParticipantAsync(Models.HangupParticipantInput input)
        {
            //validating required parameters
            if (null == input.ConferenceSid)
                throw new ArgumentNullException("conferenceSid", "The property \"ConferenceSid\" in the input object cannot be null.");

            if (null == input.ParticipantSid)
                throw new ArgumentNullException("participantSid", "The property \"ParticipantSid\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/conferences/hangupParticipant.{ResponseType}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "ResponseType", input.ResponseType }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "ParticipantSid", input.ParticipantSid }
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
                new KeyValuePair<string, object>( "ConferenceSid", input.ConferenceSid )
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
        /// Play an audio file during a conference.
        /// </summary>
        /// <param name="Models.PlayConferenceAudioInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string PlayConferenceAudio(Models.PlayConferenceAudioInput input)
        {
            Task<string> t = PlayConferenceAudioAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Play an audio file during a conference.
        /// </summary>
        /// <param name="Models.PlayConferenceAudioInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> PlayConferenceAudioAsync(Models.PlayConferenceAudioInput input)
        {
            //validating required parameters
            if (null == input.ConferenceSid)
                throw new ArgumentNullException("conferenceSid", "The property \"ConferenceSid\" in the input object cannot be null.");

            if (null == input.ParticipantSid)
                throw new ArgumentNullException("participantSid", "The property \"ParticipantSid\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/conferences/playAudio.{ResponseType}");

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
                new KeyValuePair<string, object>( "ConferenceSid", input.ConferenceSid ),
                new KeyValuePair<string, object>( "ParticipantSid", input.ParticipantSid ),
                new KeyValuePair<string, object>( "AudioUrl", Models.AudioFormatEnumHelper.ToValue(input.AudioUrl) )
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
        /// Retrieve a list of participants for an in-progress conference.
        /// </summary>
        /// <param name="Models.ListParticipantInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string ListParticipant(Models.ListParticipantInput input)
        {
            Task<string> t = ListParticipantAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a list of participants for an in-progress conference.
        /// </summary>
        /// <param name="Models.ListParticipantInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> ListParticipantAsync(Models.ListParticipantInput input)
        {
            //validating required parameters
            if (null == input.ConferenceSid)
                throw new ArgumentNullException("conferenceSid", "The property \"ConferenceSid\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/conferences/listParticipant.{ResponseType}");

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
                new KeyValuePair<string, object>( "ConferenceSid", input.ConferenceSid ),
                new KeyValuePair<string, object>( "Page", input.Page ),
                new KeyValuePair<string, object>( "Pagesize", input.Pagesize ),
                new KeyValuePair<string, object>( "Muted", input.Muted ),
                new KeyValuePair<string, object>( "Deaf", input.Deaf )
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
        /// Retrieve a list of conference objects.
        /// </summary>
        /// <param name="Models.ListConferenceInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string ListConference(Models.ListConferenceInput input)
        {
            Task<string> t = ListConferenceAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a list of conference objects.
        /// </summary>
        /// <param name="Models.ListConferenceInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> ListConferenceAsync(Models.ListConferenceInput input)
        {
            //validating required parameters
            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/conferences/listconference.{ResponseType}");

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
                new KeyValuePair<string, object>( "FriendlyName", input.FriendlyName ),
                new KeyValuePair<string, object>( "DateCreated", input.DateCreated )
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