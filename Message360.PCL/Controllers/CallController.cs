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
    public partial class CallController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static CallController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static CallController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new CallController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// View Call Response
        /// </summary>
        /// <param name="CreateViewCallInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateViewCall(CreateViewCallInput input)
        {
            Task<string> t = CreateViewCallAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// View Call Response
        /// </summary>
        /// <param name="CreateViewCallInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateViewCallAsync(CreateViewCallInput input)
        {
            //validating required parameters
            if (null == input.Callsid)
                throw new ArgumentNullException("callsid", "The property \"Callsid\" in the input object cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/calls/viewcalls.{ResponseType}");

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
            var _fields = new Dictionary<string,object>()
            {
                { "callsid", input.Callsid }
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
        /// Group Call
        /// </summary>
        /// <param name="CreateGroupCallInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateGroupCall(CreateGroupCallInput input)
        {
            Task<string> t = CreateGroupCallAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Group Call
        /// </summary>
        /// <param name="CreateGroupCallInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateGroupCallAsync(CreateGroupCallInput input)
        {
            //validating required parameters
            if (null == input.FromCountryCode)
                throw new ArgumentNullException("fromCountryCode", "The property \"FromCountryCode\" in the input object cannot be null.");

            if (null == input.From)
                throw new ArgumentNullException("mfrom", "The property \"From\" in the input object cannot be null.");

            if (null == input.ToCountryCode)
                throw new ArgumentNullException("toCountryCode", "The property \"ToCountryCode\" in the input object cannot be null.");

            if (null == input.To)
                throw new ArgumentNullException("to", "The property \"To\" in the input object cannot be null.");

            if (null == input.Url)
                throw new ArgumentNullException("url", "The property \"Url\" in the input object cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/calls/groupcall.{ResponseType}");

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
            var _fields = new Dictionary<string,object>()
            {
                { "FromCountryCode", input.FromCountryCode },
                { "From", input.From },
                { "ToCountryCode", input.ToCountryCode },
                { "To", input.To },
                { "Url", input.Url },
                { "Method", (input.Method.HasValue) ? HttpActionHelper.ToValue(input.Method.Value) : null },
                { "StatusCallBackUrl", input.StatusCallBackUrl },
                { "StatusCallBackMethod", (input.StatusCallBackMethod.HasValue) ? HttpActionHelper.ToValue(input.StatusCallBackMethod.Value) : null },
                { "FallBackUrl", input.FallBackUrl },
                { "FallBackMethod", (input.FallBackMethod.HasValue) ? HttpActionHelper.ToValue(input.FallBackMethod.Value) : null },
                { "HeartBeatUrl", input.HeartBeatUrl },
                { "HeartBeatMethod", (input.HeartBeatMethod.HasValue) ? HttpActionHelper.ToValue(input.HeartBeatMethod.Value) : null },
                { "Timeout", input.Timeout },
                { "PlayDtmf", input.PlayDtmf },
                { "HideCallerId", input.HideCallerId },
                { "Record", input.Record },
                { "RecordCallBackUrl", input.RecordCallBackUrl },
                { "RecordCallBackMethod", (input.RecordCallBackMethod.HasValue) ? HttpActionHelper.ToValue(input.RecordCallBackMethod.Value) : null },
                { "Transcribe", input.Transcribe },
                { "TranscribeCallBackUrl", input.TranscribeCallBackUrl }
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
        /// Voice Effect
        /// </summary>
        /// <param name="CreateVoiceEffectInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateVoiceEffect(CreateVoiceEffectInput input)
        {
            Task<string> t = CreateVoiceEffectAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Voice Effect
        /// </summary>
        /// <param name="CreateVoiceEffectInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateVoiceEffectAsync(CreateVoiceEffectInput input)
        {
            //validating required parameters
            if (null == input.CallSid)
                throw new ArgumentNullException("callSid", "The property \"CallSid\" in the input object cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/calls/voiceeffect.{ResponseType}");

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
            var _fields = new Dictionary<string,object>()
            {
                { "CallSid", input.CallSid },
                { "AudioDirection", (input.AudioDirection.HasValue) ? AudioDirectionHelper.ToValue(input.AudioDirection.Value) : null },
                { "PitchSemiTones", input.PitchSemiTones },
                { "PitchOctaves", input.PitchOctaves },
                { "Pitch", input.Pitch },
                { "Rate", input.Rate },
                { "Tempo", input.Tempo }
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
        /// Record a Call
        /// </summary>
        /// <param name="CreateRecordCallInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateRecordCall(CreateRecordCallInput input)
        {
            Task<string> t = CreateRecordCallAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Record a Call
        /// </summary>
        /// <param name="CreateRecordCallInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateRecordCallAsync(CreateRecordCallInput input)
        {
            //validating required parameters
            if (null == input.CallSid)
                throw new ArgumentNullException("callSid", "The property \"CallSid\" in the input object cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/calls/recordcalls.{ResponseType}");

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
            var _fields = new Dictionary<string,object>()
            {
                { "CallSid", input.CallSid },
                { "Record", input.Record },
                { "Direction", (input.Direction.HasValue) ? DirectionHelper.ToValue(input.Direction.Value) : null },
                { "TimeLimit", input.TimeLimit },
                { "CallBackUrl", input.CallBackUrl },
                { "Fileformat", (input.Fileformat.HasValue) ? AudioFormatHelper.ToValue(input.Fileformat.Value) : null }
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
        /// Play Dtmf and send the Digit
        /// </summary>
        /// <param name="CreatePlayAudioInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string CreatePlayAudio(CreatePlayAudioInput input)
        {
            Task<string> t = CreatePlayAudioAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Play Dtmf and send the Digit
        /// </summary>
        /// <param name="CreatePlayAudioInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreatePlayAudioAsync(CreatePlayAudioInput input)
        {
            //validating required parameters
            if (null == input.CallSid)
                throw new ArgumentNullException("callSid", "The property \"CallSid\" in the input object cannot be null.");

            if (null == input.AudioUrl)
                throw new ArgumentNullException("audioUrl", "The property \"AudioUrl\" in the input object cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/calls/playaudios.{ResponseType}");

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
            var _fields = new Dictionary<string,object>()
            {
                { "CallSid", input.CallSid },
                { "AudioUrl", input.AudioUrl },
                { "Length", input.Length },
                { "Direction", (input.Direction.HasValue) ? DirectionHelper.ToValue(input.Direction.Value) : null },
                { "Loop", input.Loop },
                { "Mix", input.Mix }
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
        /// A list of calls associated with your Message360 account
        /// </summary>
        /// <param name="CreateListCallsInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateListCalls(CreateListCallsInput input)
        {
            Task<string> t = CreateListCallsAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// A list of calls associated with your Message360 account
        /// </summary>
        /// <param name="CreateListCallsInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateListCallsAsync(CreateListCallsInput input)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/calls/listcalls.{ResponseType}");

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
            var _fields = new Dictionary<string,object>()
            {
                { "Page", input.Page },
                { "PageSize", input.PageSize },
                { "To", input.To },
                { "From", input.From },
                { "DateCreated", input.DateCreated }
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
        /// Interrupt the Call by Call Sid
        /// </summary>
        /// <param name="CreateInterruptedCallInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateInterruptedCall(CreateInterruptedCallInput input)
        {
            Task<string> t = CreateInterruptedCallAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Interrupt the Call by Call Sid
        /// </summary>
        /// <param name="CreateInterruptedCallInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateInterruptedCallAsync(CreateInterruptedCallInput input)
        {
            //validating required parameters
            if (null == input.CallSid)
                throw new ArgumentNullException("callSid", "The property \"CallSid\" in the input object cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/calls/interruptcalls.{ResponseType}");

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
            var _fields = new Dictionary<string,object>()
            {
                { "CallSid", input.CallSid },
                { "Url", input.Url },
                { "Method", (input.Method.HasValue) ? HttpActionHelper.ToValue(input.Method.Value) : null },
                { "Status", (input.Status.HasValue) ? InterruptedCallStatusHelper.ToValue(input.Status.Value) : null }
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
        /// Play Dtmf and send the Digit
        /// </summary>
        /// <param name="CreateSendDigitInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateSendDigit(CreateSendDigitInput input)
        {
            Task<string> t = CreateSendDigitAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Play Dtmf and send the Digit
        /// </summary>
        /// <param name="CreateSendDigitInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateSendDigitAsync(CreateSendDigitInput input)
        {
            //validating required parameters
            if (null == input.CallSid)
                throw new ArgumentNullException("callSid", "The property \"CallSid\" in the input object cannot be null.");

            if (null == input.PlayDtmf)
                throw new ArgumentNullException("playDtmf", "The property \"PlayDtmf\" in the input object cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/calls/senddigits.{ResponseType}");

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
            var _fields = new Dictionary<string,object>()
            {
                { "CallSid", input.CallSid },
                { "PlayDtmf", input.PlayDtmf },
                { "PlayDtmfDirection", (input.PlayDtmfDirection.HasValue) ? DirectionHelper.ToValue(input.PlayDtmfDirection.Value) : null }
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
        /// You can experiment with initiating a call through Message360 and view the request response generated when doing so and get the response in json
        /// </summary>
        /// <param name="CreateMakeCallInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateMakeCall(CreateMakeCallInput input)
        {
            Task<string> t = CreateMakeCallAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// You can experiment with initiating a call through Message360 and view the request response generated when doing so and get the response in json
        /// </summary>
        /// <param name="CreateMakeCallInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateMakeCallAsync(CreateMakeCallInput input)
        {
            //validating required parameters
            if (null == input.FromCountryCode)
                throw new ArgumentNullException("fromCountryCode", "The property \"FromCountryCode\" in the input object cannot be null.");

            if (null == input.From)
                throw new ArgumentNullException("mfrom", "The property \"From\" in the input object cannot be null.");

            if (null == input.ToCountryCode)
                throw new ArgumentNullException("toCountryCode", "The property \"ToCountryCode\" in the input object cannot be null.");

            if (null == input.To)
                throw new ArgumentNullException("to", "The property \"To\" in the input object cannot be null.");

            if (null == input.Url)
                throw new ArgumentNullException("url", "The property \"Url\" in the input object cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/calls/makecall.{ResponseType}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "ResponseType", input.ResponseType }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "Method", (input.Method.HasValue) ? HttpActionHelper.ToValue(input.Method.Value) : null }
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
                { "FromCountryCode", input.FromCountryCode },
                { "From", input.From },
                { "ToCountryCode", input.ToCountryCode },
                { "To", input.To },
                { "Url", input.Url },
                { "StatusCallBackUrl", input.StatusCallBackUrl },
                { "StatusCallBackMethod", (input.StatusCallBackMethod.HasValue) ? HttpActionHelper.ToValue(input.StatusCallBackMethod.Value) : null },
                { "FallBackUrl", input.FallBackUrl },
                { "FallBackMethod", (input.FallBackMethod.HasValue) ? HttpActionHelper.ToValue(input.FallBackMethod.Value) : null },
                { "HeartBeatUrl", input.HeartBeatUrl },
                { "HeartBeatMethod", input.HeartBeatMethod },
                { "Timeout", input.Timeout },
                { "PlayDtmf", input.PlayDtmf },
                { "HideCallerId", input.HideCallerId },
                { "Record", input.Record },
                { "RecordCallBackUrl", input.RecordCallBackUrl },
                { "RecordCallBackMethod", (input.RecordCallBackMethod.HasValue) ? HttpActionHelper.ToValue(input.RecordCallBackMethod.Value) : null },
                { "Transcribe", input.Transcribe },
                { "TranscribeCallBackUrl", input.TranscribeCallBackUrl },
                { "IfMachine", (input.IfMachine.HasValue) ? IfMachineHelper.ToValue(input.IfMachine.Value) : null }
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