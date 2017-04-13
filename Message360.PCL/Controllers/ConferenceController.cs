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
        /// <param name="CreateDeafMuteParticipantInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateDeafMuteParticipant(CreateDeafMuteParticipantInput input)
        {
            Task<string> t = CreateDeafMuteParticipantAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Deaf Mute Participant
        /// </summary>
        /// <param name="CreateDeafMuteParticipantInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateDeafMuteParticipantAsync(CreateDeafMuteParticipantInput input)
        {
            //validating required parameters
            if (null == input.ConferenceSid)
                throw new ArgumentNullException("conferenceSid", "The property \"ConferenceSid\" in the input object cannot be null.");

            if (null == input.ParticipantSid)
                throw new ArgumentNullException("participantSid", "The property \"ParticipantSid\" in the input object cannot be null.");

            //the base uri for api requestss
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
                { "user-agent", "message360-api" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "conferenceSid", input.ConferenceSid ),
                new KeyValuePair<string, object>( "ParticipantSid", input.ParticipantSid ),
                new KeyValuePair<string, object>( "Muted", input.Muted ),
                new KeyValuePair<string, object>( "Deaf", input.Deaf )
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
        /// List Conference
        /// </summary>
        /// <param name="CreateListConferenceInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateListConference(CreateListConferenceInput input)
        {
            Task<string> t = CreateListConferenceAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// List Conference
        /// </summary>
        /// <param name="CreateListConferenceInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateListConferenceAsync(CreateListConferenceInput input)
        {
            //the base uri for api requestss
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
                { "user-agent", "message360-api" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "Page", input.Page ),
                new KeyValuePair<string, object>( "PageSize", input.PageSize ),
                new KeyValuePair<string, object>( "FriendlyName", input.FriendlyName ),
                new KeyValuePair<string, object>( "Status", (input.Status.HasValue) ? InterruptedCallStatusEnumHelper.ToValue(input.Status.Value) : null ),
                new KeyValuePair<string, object>( "DateCreated", input.DateCreated ),
                new KeyValuePair<string, object>( "DateUpdated", input.DateUpdated )
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
        /// View Conference
        /// </summary>
        /// <param name="CreateViewConferenceInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateViewConference(CreateViewConferenceInput input)
        {
            Task<string> t = CreateViewConferenceAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// View Conference
        /// </summary>
        /// <param name="CreateViewConferenceInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateViewConferenceAsync(CreateViewConferenceInput input)
        {
            //validating required parameters
            if (null == input.Conferencesid)
                throw new ArgumentNullException("conferencesid", "The property \"Conferencesid\" in the input object cannot be null.");

            //the base uri for api requestss
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
                { "user-agent", "message360-api" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "conferencesid", input.Conferencesid )
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
        /// Add Participant in conference 
        /// </summary>
        /// <param name="AddParticipantInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string AddParticipant(AddParticipantInput input)
        {
            Task<string> t = AddParticipantAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Add Participant in conference 
        /// </summary>
        /// <param name="AddParticipantInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> AddParticipantAsync(AddParticipantInput input)
        {
            //validating required parameters
            if (null == input.Conferencesid)
                throw new ArgumentNullException("conferencesid", "The property \"Conferencesid\" in the input object cannot be null.");

            if (null == input.Participantnumber)
                throw new ArgumentNullException("participantnumber", "The property \"Participantnumber\" in the input object cannot be null.");

            //the base uri for api requestss
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
                { "user-agent", "message360-api" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "conferencesid", input.Conferencesid ),
                new KeyValuePair<string, object>( "participantnumber", input.Participantnumber ),
                new KeyValuePair<string, object>( "tocountrycode", input.Tocountrycode ),
                new KeyValuePair<string, object>( "muted", input.Muted ),
                new KeyValuePair<string, object>( "deaf", input.Deaf )
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
        /// List Participant
        /// </summary>
        /// <param name="CreateListParticipantInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateListParticipant(CreateListParticipantInput input)
        {
            Task<string> t = CreateListParticipantAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// List Participant
        /// </summary>
        /// <param name="CreateListParticipantInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateListParticipantAsync(CreateListParticipantInput input)
        {
            //validating required parameters
            if (null == input.ConferenceSid)
                throw new ArgumentNullException("conferenceSid", "The property \"ConferenceSid\" in the input object cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/conferences/listparticipant.{ResponseType}");

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
                new KeyValuePair<string, object>( "ConferenceSid", input.ConferenceSid ),
                new KeyValuePair<string, object>( "Page", input.Page ),
                new KeyValuePair<string, object>( "Pagesize", input.Pagesize ),
                new KeyValuePair<string, object>( "Muted", input.Muted ),
                new KeyValuePair<string, object>( "Deaf", input.Deaf )
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
        /// View Participant
        /// </summary>
        /// <param name="CreateViewParticipantInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateViewParticipant(CreateViewParticipantInput input)
        {
            Task<string> t = CreateViewParticipantAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// View Participant
        /// </summary>
        /// <param name="CreateViewParticipantInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateViewParticipantAsync(CreateViewParticipantInput input)
        {
            //validating required parameters
            if (null == input.ConferenceSid)
                throw new ArgumentNullException("conferenceSid", "The property \"ConferenceSid\" in the input object cannot be null.");

            if (null == input.ParticipantSid)
                throw new ArgumentNullException("participantSid", "The property \"ParticipantSid\" in the input object cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/conferences/viewparticipant.{ResponseType}");

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
                new KeyValuePair<string, object>( "ConferenceSid", input.ConferenceSid ),
                new KeyValuePair<string, object>( "ParticipantSid", input.ParticipantSid )
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