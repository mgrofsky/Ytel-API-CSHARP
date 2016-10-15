/*
 * Message360.PCL
 *
 * This file was automatically generated for message360 by APIMATIC v2.0 ( https://apimatic.io ) on 10/15/2016
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
        /// View Participant
        /// </summary>
        /// <param name="conferenceSid">Required parameter: unique conference sid</param>
        /// <param name="participantSid">Required parameter: Example: </param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateViewParticipant(string conferenceSid, string participantSid, string responseType = "json")
        {
            Task<string> t = CreateViewParticipantAsync(conferenceSid, participantSid, responseType);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// View Participant
        /// </summary>
        /// <param name="conferenceSid">Required parameter: unique conference sid</param>
        /// <param name="participantSid">Required parameter: Example: </param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateViewParticipantAsync(string conferenceSid, string participantSid, string responseType = "json")
        {
            //validating required parameters
            if (null == conferenceSid)
                throw new ArgumentNullException("conferenceSid", "The parameter \"conferenceSid\" is a required parameter and cannot be null.");

            if (null == participantSid)
                throw new ArgumentNullException("participantSid", "The parameter \"participantSid\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/conferences/viewparticipant.{ResponseType}");

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
                { "ConferenceSid", conferenceSid },
                { "ParticipantSid", participantSid }
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
        /// List Participant
        /// </summary>
        /// <param name="conferenceSid">Required parameter: unique conference sid</param>
        /// <param name="page">Optional parameter: page number</param>
        /// <param name="pagesize">Optional parameter: Example: </param>
        /// <param name="muted">Optional parameter: Example: </param>
        /// <param name="deaf">Optional parameter: Example: </param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateListParticipant(
                string conferenceSid,
                int? page = null,
                int? pagesize = null,
                bool? muted = null,
                bool? deaf = null,
                string responseType = "json")
        {
            Task<string> t = CreateListParticipantAsync(conferenceSid, page, pagesize, muted, deaf, responseType);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// List Participant
        /// </summary>
        /// <param name="conferenceSid">Required parameter: unique conference sid</param>
        /// <param name="page">Optional parameter: page number</param>
        /// <param name="pagesize">Optional parameter: Example: </param>
        /// <param name="muted">Optional parameter: Example: </param>
        /// <param name="deaf">Optional parameter: Example: </param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateListParticipantAsync(
                string conferenceSid,
                int? page = null,
                int? pagesize = null,
                bool? muted = null,
                bool? deaf = null,
                string responseType = "json")
        {
            //validating required parameters
            if (null == conferenceSid)
                throw new ArgumentNullException("conferenceSid", "The parameter \"conferenceSid\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/conferences/listparticipant.{ResponseType}");

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
                { "ConferenceSid", conferenceSid },
                { "Page", page },
                { "Pagesize", pagesize },
                { "Muted", muted },
                { "Deaf", deaf }
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
        /// Add Participant in conference 
        /// </summary>
        /// <param name="conferencesid">Required parameter: Unique Conference Sid</param>
        /// <param name="participantnumber">Required parameter: Particiant Number</param>
        /// <param name="tocountrycode">Required parameter: Example: </param>
        /// <param name="muted">Optional parameter: Example: </param>
        /// <param name="deaf">Optional parameter: Example: </param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public string AddParticipant(
                string conferencesid,
                string participantnumber,
                int tocountrycode,
                bool? muted = null,
                bool? deaf = null,
                string responseType = "json")
        {
            Task<string> t = AddParticipantAsync(conferencesid, participantnumber, tocountrycode, muted, deaf, responseType);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Add Participant in conference 
        /// </summary>
        /// <param name="conferencesid">Required parameter: Unique Conference Sid</param>
        /// <param name="participantnumber">Required parameter: Particiant Number</param>
        /// <param name="tocountrycode">Required parameter: Example: </param>
        /// <param name="muted">Optional parameter: Example: </param>
        /// <param name="deaf">Optional parameter: Example: </param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> AddParticipantAsync(
                string conferencesid,
                string participantnumber,
                int tocountrycode,
                bool? muted = null,
                bool? deaf = null,
                string responseType = "json")
        {
            //validating required parameters
            if (null == conferencesid)
                throw new ArgumentNullException("conferencesid", "The parameter \"conferencesid\" is a required parameter and cannot be null.");

            if (null == participantnumber)
                throw new ArgumentNullException("participantnumber", "The parameter \"participantnumber\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/conferences/addParticipant.{ResponseType}");

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
                { "conferencesid", conferencesid },
                { "participantnumber", participantnumber },
                { "tocountrycode", tocountrycode },
                { "muted", muted },
                { "deaf", deaf }
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
        /// View Conference
        /// </summary>
        /// <param name="conferencesid">Required parameter: The unique identifier of each conference resource</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateViewConference(string conferencesid, string responseType = "json")
        {
            Task<string> t = CreateViewConferenceAsync(conferencesid, responseType);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// View Conference
        /// </summary>
        /// <param name="conferencesid">Required parameter: The unique identifier of each conference resource</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateViewConferenceAsync(string conferencesid, string responseType = "json")
        {
            //validating required parameters
            if (null == conferencesid)
                throw new ArgumentNullException("conferencesid", "The parameter \"conferencesid\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/conferences/viewconference.{ResponseType}");

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
                { "conferencesid", conferencesid }
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
        /// List Conference
        /// </summary>
        /// <param name="page">Optional parameter: Which page of the overall response will be returned. Zero indexed</param>
        /// <param name="pageSize">Optional parameter: Number of individual resources listed in the response per page</param>
        /// <param name="friendlyName">Optional parameter: Only return conferences with the specified FriendlyName</param>
        /// <param name="status">Optional parameter: Example: </param>
        /// <param name="dateCreated">Optional parameter: Example: </param>
        /// <param name="dateUpdated">Optional parameter: Example: </param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateListConference(
                int? page = null,
                int? pageSize = null,
                string friendlyName = null,
                InterruptedCallStatusEnum? status = null,
                string dateCreated = null,
                string dateUpdated = null,
                string responseType = "json")
        {
            Task<string> t = CreateListConferenceAsync(page, pageSize, friendlyName, status, dateCreated, dateUpdated, responseType);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// List Conference
        /// </summary>
        /// <param name="page">Optional parameter: Which page of the overall response will be returned. Zero indexed</param>
        /// <param name="pageSize">Optional parameter: Number of individual resources listed in the response per page</param>
        /// <param name="friendlyName">Optional parameter: Only return conferences with the specified FriendlyName</param>
        /// <param name="status">Optional parameter: Example: </param>
        /// <param name="dateCreated">Optional parameter: Example: </param>
        /// <param name="dateUpdated">Optional parameter: Example: </param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateListConferenceAsync(
                int? page = null,
                int? pageSize = null,
                string friendlyName = null,
                InterruptedCallStatusEnum? status = null,
                string dateCreated = null,
                string dateUpdated = null,
                string responseType = "json")
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/conferences/listconference.{ResponseType}");

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
                { "FriendlyName", friendlyName },
                { "Status", (status.HasValue) ? InterruptedCallStatusEnumHelper.ToValue(status.Value) : null },
                { "DateCreated", dateCreated },
                { "DateUpdated", dateUpdated }
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