/*
 * Message360.PCL
 *
 * This file was automatically generated for message360 by APIMATIC v2.0 ( https://apimatic.io ) on 11/04/2016
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
    public partial class EmailController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static EmailController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static EmailController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new EmailController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Send out an email
        /// </summary>
        /// <param name="to">Required parameter: The to email address</param>
        /// <param name="mfrom">Required parameter: The from email address</param>
        /// <param name="type">Required parameter: email format type, html or text</param>
        /// <param name="subject">Required parameter: Email subject</param>
        /// <param name="message">Required parameter: The body of the email message</param>
        /// <param name="cc">Optional parameter: CC Email address</param>
        /// <param name="bcc">Optional parameter: BCC Email address</param>
        /// <param name="attachment">Optional parameter: File to be attached.File must be less than 7MB.</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateSendEmail(
                string to,
                string mfrom,
                SendEmailAs type,
                string subject,
                string message,
                string cc = null,
                string bcc = null,
                string attachment = null,
                string responseType = "json")
        {
            Task<string> t = CreateSendEmailAsync(to, mfrom, type, subject, message, cc, bcc, attachment, responseType);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Send out an email
        /// </summary>
        /// <param name="to">Required parameter: The to email address</param>
        /// <param name="mfrom">Required parameter: The from email address</param>
        /// <param name="type">Required parameter: email format type, html or text</param>
        /// <param name="subject">Required parameter: Email subject</param>
        /// <param name="message">Required parameter: The body of the email message</param>
        /// <param name="cc">Optional parameter: CC Email address</param>
        /// <param name="bcc">Optional parameter: BCC Email address</param>
        /// <param name="attachment">Optional parameter: File to be attached.File must be less than 7MB.</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateSendEmailAsync(
                string to,
                string mfrom,
                SendEmailAs type,
                string subject,
                string message,
                string cc = null,
                string bcc = null,
                string attachment = null,
                string responseType = "json")
        {
            //validating required parameters
            if (null == to)
                throw new ArgumentNullException("to", "The parameter \"to\" is a required parameter and cannot be null.");

            if (null == mfrom)
                throw new ArgumentNullException("mfrom", "The parameter \"mfrom\" is a required parameter and cannot be null.");

            if (null == subject)
                throw new ArgumentNullException("subject", "The parameter \"subject\" is a required parameter and cannot be null.");

            if (null == message)
                throw new ArgumentNullException("message", "The parameter \"message\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/email/sendemails.{ResponseType}");

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
                { "to", to },
                { "from", mfrom },
                { "type", SendEmailAsHelper.ToValue(type) },
                { "subject", subject },
                { "message", message },
                { "cc", cc },
                { "bcc", bcc },
                { "attachment", attachment }
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
        /// Delete emails from the unsubscribe list
        /// </summary>
        /// <param name="email">Required parameter: The email to remove from the unsubscribe list</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateDeleteUnsubscribes(string email, string responseType = "json")
        {
            Task<string> t = CreateDeleteUnsubscribesAsync(email, responseType);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Delete emails from the unsubscribe list
        /// </summary>
        /// <param name="email">Required parameter: The email to remove from the unsubscribe list</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateDeleteUnsubscribesAsync(string email, string responseType = "json")
        {
            //validating required parameters
            if (null == email)
                throw new ArgumentNullException("email", "The parameter \"email\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/email/deleteunsubscribedemail.{ResponseType}");

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
                { "email", email }
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
        /// List all unsubscribed email addresses
        /// </summary>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <param name="offset">Optional parameter: Starting record of the list</param>
        /// <param name="limit">Optional parameter: Maximum number of records to be returned</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateListUnsubscribes(string responseType = "json", string offset = null, string limit = null)
        {
            Task<string> t = CreateListUnsubscribesAsync(responseType, offset, limit);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// List all unsubscribed email addresses
        /// </summary>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <param name="offset">Optional parameter: Starting record of the list</param>
        /// <param name="limit">Optional parameter: Maximum number of records to be returned</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateListUnsubscribesAsync(string responseType = "json", string offset = null, string limit = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/email/listunsubscribedemail.{ResponseType}");

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
                { "offset", offset },
                { "limit", limit }
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
        /// Add an email to the unsubscribe list
        /// </summary>
        /// <param name="email">Required parameter: The email to add to the unsubscribe list</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public string AddUnsubscribes(string email, string responseType = "json")
        {
            Task<string> t = AddUnsubscribesAsync(email, responseType);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Add an email to the unsubscribe list
        /// </summary>
        /// <param name="email">Required parameter: The email to add to the unsubscribe list</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> AddUnsubscribesAsync(string email, string responseType = "json")
        {
            //validating required parameters
            if (null == email)
                throw new ArgumentNullException("email", "The parameter \"email\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/email/addunsubscribesemail.{ResponseType}");

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
                { "email", email }
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
        /// Deletes a email address marked as spam from the spam list
        /// </summary>
        /// <param name="email">Required parameter: Email address</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateDeleteSpam(string email, string responseType = "json")
        {
            Task<string> t = CreateDeleteSpamAsync(email, responseType);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Deletes a email address marked as spam from the spam list
        /// </summary>
        /// <param name="email">Required parameter: Email address</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateDeleteSpamAsync(string email, string responseType = "json")
        {
            //validating required parameters
            if (null == email)
                throw new ArgumentNullException("email", "The parameter \"email\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/email/deletespamemail.{ResponseType}");

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
                { "email", email }
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
        /// Deletes a blocked email
        /// </summary>
        /// <param name="email">Required parameter: Email address to remove from block list</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateDeleteBlock(string email, string responseType = "json")
        {
            Task<string> t = CreateDeleteBlockAsync(email, responseType);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Deletes a blocked email
        /// </summary>
        /// <param name="email">Required parameter: Email address to remove from block list</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateDeleteBlockAsync(string email, string responseType = "json")
        {
            //validating required parameters
            if (null == email)
                throw new ArgumentNullException("email", "The parameter \"email\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/email/deleteblocksemail.{ResponseType}");

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
                { "email", email }
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
        /// List out all invalid email addresses
        /// </summary>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <param name="offet">Optional parameter: Starting record for listing out emails</param>
        /// <param name="limit">Optional parameter: Maximum number of records to return</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateListInvalid(string responseType = "json", string offet = null, string limit = null)
        {
            Task<string> t = CreateListInvalidAsync(responseType, offet, limit);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// List out all invalid email addresses
        /// </summary>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <param name="offet">Optional parameter: Starting record for listing out emails</param>
        /// <param name="limit">Optional parameter: Maximum number of records to return</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateListInvalidAsync(string responseType = "json", string offet = null, string limit = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/email/listinvalidemail.{ResponseType}");

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
                { "offet", offet },
                { "limit", limit }
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
        /// Delete an email address from the bounced address list
        /// </summary>
        /// <param name="email">Required parameter: The email address to remove from the bounce list</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateDeleteBounces(string email, string responseType = "json")
        {
            Task<string> t = CreateDeleteBouncesAsync(email, responseType);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Delete an email address from the bounced address list
        /// </summary>
        /// <param name="email">Required parameter: The email address to remove from the bounce list</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateDeleteBouncesAsync(string email, string responseType = "json")
        {
            //validating required parameters
            if (null == email)
                throw new ArgumentNullException("email", "The parameter \"email\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/email/deletebouncesemail.{ResponseType}");

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
                { "email", email }
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
        /// List out all email addresses that have bounced
        /// </summary>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <param name="offset">Optional parameter: The record to start the list at</param>
        /// <param name="limit">Optional parameter: The maximum number of records to return</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateListBounces(string responseType = "json", string offset = null, string limit = null)
        {
            Task<string> t = CreateListBouncesAsync(responseType, offset, limit);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// List out all email addresses that have bounced
        /// </summary>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <param name="offset">Optional parameter: The record to start the list at</param>
        /// <param name="limit">Optional parameter: The maximum number of records to return</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateListBouncesAsync(string responseType = "json", string offset = null, string limit = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/email/listbounceemail.{ResponseType}");

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
                { "offset", offset },
                { "limit", limit }
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
        /// List out all email addresses marked as spam
        /// </summary>
        /// <param name="responseType">Required parameter: Response format, xml or json</param>
        /// <param name="offset">Optional parameter: The record number to start the list at</param>
        /// <param name="limit">Optional parameter: Maximum number of records to return</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateListSpam(string responseType, string offset = null, string limit = null)
        {
            Task<string> t = CreateListSpamAsync(responseType, offset, limit);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// List out all email addresses marked as spam
        /// </summary>
        /// <param name="responseType">Required parameter: Response format, xml or json</param>
        /// <param name="offset">Optional parameter: The record number to start the list at</param>
        /// <param name="limit">Optional parameter: Maximum number of records to return</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateListSpamAsync(string responseType, string offset = null, string limit = null)
        {
            //validating required parameters
            if (null == responseType)
                throw new ArgumentNullException("responseType", "The parameter \"responseType\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/email/listspamemail.{ResponseType}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "ResponseType", responseType }
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
                { "offset", offset },
                { "limit", limit }
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
        /// Outputs email addresses on your blocklist
        /// </summary>
        /// <param name="offset">Optional parameter: Where to start in the output list</param>
        /// <param name="limit">Optional parameter: Maximum number of records to return</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateListBlocks(string offset = null, string limit = null, string responseType = "json")
        {
            Task<string> t = CreateListBlocksAsync(offset, limit, responseType);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Outputs email addresses on your blocklist
        /// </summary>
        /// <param name="offset">Optional parameter: Where to start in the output list</param>
        /// <param name="limit">Optional parameter: Maximum number of records to return</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateListBlocksAsync(string offset = null, string limit = null, string responseType = "json")
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/email/listblockemail.{ResponseType}");

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
                { "offset", offset },
                { "limit", limit }
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