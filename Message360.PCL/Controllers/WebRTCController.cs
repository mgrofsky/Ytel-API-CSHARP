/*
 * Message360.PCL
 *
 * This file was automatically generated for message360 by APIMATIC v2.0 ( https://apimatic.io ) on 12/08/2016
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
using message360;
using message360.Utilities;
using message360.Http.Request;
using message360.Http.Response;
using message360.Http.Client;
using message360.Exceptions;
using message360.Models;

namespace message360.Controllers
{
    public partial class WebRTCController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static WebRTCController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static WebRTCController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new WebRTCController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// message360 webrtc
        /// </summary>
        /// <param name="CreateTokenInput">Object containing request parameters</param>
        /// <return>Returns the void response from the API call</return>
        public void CreateToken(CreateTokenInput input)
        {
            Task t = CreateTokenAsync(input);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// message360 webrtc
        /// </summary>
        /// <param name="CreateTokenInput">Object containing request parameters</param>
        /// <return>Returns the void response from the API call</return>
        public async Task CreateTokenAsync(CreateTokenInput input)
        {
            //validating required parameters
            if (null == input.AccountSid)
                throw new ArgumentNullException("accountSid", "The property \"AccountSid\" in the input object cannot be null.");

            if (null == input.AuthToken)
                throw new ArgumentNullException("authToken", "The property \"AuthToken\" in the input object cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/webrtc/createToken.json");


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
                { "account_sid", input.AccountSid },
                { "auth_token", input.AuthToken }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="CreateCheckFundsInput">Object containing request parameters</param>
        /// <return>Returns the void response from the API call</return>
        public void CreateCheckFunds(CreateCheckFundsInput input)
        {
            Task t = CreateCheckFundsAsync(input);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="CreateCheckFundsInput">Object containing request parameters</param>
        /// <return>Returns the void response from the API call</return>
        public async Task CreateCheckFundsAsync(CreateCheckFundsInput input)
        {
            //validating required parameters
            if (null == input.AccountSid)
                throw new ArgumentNullException("accountSid", "The property \"AccountSid\" in the input object cannot be null.");

            if (null == input.AuthToken)
                throw new ArgumentNullException("authToken", "The property \"AuthToken\" in the input object cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/webrtc/checkFunds.json");


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
                { "account_sid", input.AccountSid },
                { "auth_token", input.AuthToken }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

        }

        /// <summary>
        /// Authenticate a message360 number for use
        /// </summary>
        /// <param name="CreateAuthenticateNumberInput">Object containing request parameters</param>
        /// <return>Returns the void response from the API call</return>
        public void CreateAuthenticateNumber(CreateAuthenticateNumberInput input)
        {
            Task t = CreateAuthenticateNumberAsync(input);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Authenticate a message360 number for use
        /// </summary>
        /// <param name="CreateAuthenticateNumberInput">Object containing request parameters</param>
        /// <return>Returns the void response from the API call</return>
        public async Task CreateAuthenticateNumberAsync(CreateAuthenticateNumberInput input)
        {
            //validating required parameters
            if (null == input.PhoneNumber)
                throw new ArgumentNullException("phoneNumber", "The property \"PhoneNumber\" in the input object cannot be null.");

            if (null == input.AccountSid)
                throw new ArgumentNullException("accountSid", "The property \"AccountSid\" in the input object cannot be null.");

            if (null == input.AuthToken)
                throw new ArgumentNullException("authToken", "The property \"AuthToken\" in the input object cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/webrtc/authenticateNumber.json");


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
                { "phone_number", input.PhoneNumber },
                { "account_sid", input.AccountSid },
                { "auth_token", input.AuthToken }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

        }

    }
} 