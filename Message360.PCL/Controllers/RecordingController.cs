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
    public partial class RecordingController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static RecordingController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static RecordingController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new RecordingController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Delete Recording Record
        /// </summary>
        /// <param name="recordingSid">Required parameter: Unique Recording Sid to be delete</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateDeleteRecording(string recordingSid, string responseType = "json")
        {
            Task<string> t = CreateDeleteRecordingAsync(recordingSid, responseType);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Delete Recording Record
        /// </summary>
        /// <param name="recordingSid">Required parameter: Unique Recording Sid to be delete</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateDeleteRecordingAsync(string recordingSid, string responseType = "json")
        {
            //validating required parameters
            if (null == recordingSid)
                throw new ArgumentNullException("recordingSid", "The parameter \"recordingSid\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/recording/deleterecording.{ResponseType}");

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
                { "RecordingSid", recordingSid }
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
        /// View a specific Recording
        /// </summary>
        /// <param name="recordingSid">Required parameter: Search Recording sid</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateViewRecording(string recordingSid, string responseType = "json")
        {
            Task<string> t = CreateViewRecordingAsync(recordingSid, responseType);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// View a specific Recording
        /// </summary>
        /// <param name="recordingSid">Required parameter: Search Recording sid</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateViewRecordingAsync(string recordingSid, string responseType = "json")
        {
            //validating required parameters
            if (null == recordingSid)
                throw new ArgumentNullException("recordingSid", "The parameter \"recordingSid\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/recording/viewrecording.{ResponseType}");

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
                { "RecordingSid", recordingSid }
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
        /// List out Recordings
        /// </summary>
        /// <param name="page">Optional parameter: Which page of the overall response will be returned. Zero indexed</param>
        /// <param name="pageSize">Optional parameter: Number of individual resources listed in the response per page</param>
        /// <param name="dateCreated">Optional parameter: Example: </param>
        /// <param name="callSid">Optional parameter: Example: </param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateListRecording(
                int? page = null,
                int? pageSize = null,
                string dateCreated = null,
                string callSid = null,
                string responseType = "json")
        {
            Task<string> t = CreateListRecordingAsync(page, pageSize, dateCreated, callSid, responseType);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// List out Recordings
        /// </summary>
        /// <param name="page">Optional parameter: Which page of the overall response will be returned. Zero indexed</param>
        /// <param name="pageSize">Optional parameter: Number of individual resources listed in the response per page</param>
        /// <param name="dateCreated">Optional parameter: Example: </param>
        /// <param name="callSid">Optional parameter: Example: </param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateListRecordingAsync(
                int? page = null,
                int? pageSize = null,
                string dateCreated = null,
                string callSid = null,
                string responseType = "json")
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/recording/listrecording.{ResponseType}");

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
                { "DateCreated", dateCreated },
                { "CallSid", callSid }
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