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
        /// You can experiment with initiating a call through Ytel and view the request response generated when doing so and get the response in json
        /// </summary>
        /// <param name="Models.MakeCallInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string MakeCall(Models.MakeCallInput input)
        {
            Task<string> t = MakeCallAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// You can experiment with initiating a call through Ytel and view the request response generated when doing so and get the response in json
        /// </summary>
        /// <param name="Models.MakeCallInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> MakeCallAsync(Models.MakeCallInput input)
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
            _queryBuilder.Append("/calls/makecall.{ResponseType}");

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
                new KeyValuePair<string, object>( "From", input.From ),
                new KeyValuePair<string, object>( "To", input.To ),
                new KeyValuePair<string, object>( "Url", input.Url ),
                new KeyValuePair<string, object>( "Method", (input.Method.HasValue) ? Models.HttpActionEnumHelper.ToValue(input.Method.Value) : null ),
                new KeyValuePair<string, object>( "StatusCallBackUrl", input.StatusCallBackUrl ),
                new KeyValuePair<string, object>( "StatusCallBackMethod", (input.StatusCallBackMethod.HasValue) ? Models.HttpActionEnumHelper.ToValue(input.StatusCallBackMethod.Value) : null ),
                new KeyValuePair<string, object>( "FallBackUrl", input.FallBackUrl ),
                new KeyValuePair<string, object>( "FallBackMethod", (input.FallBackMethod.HasValue) ? Models.HttpActionEnumHelper.ToValue(input.FallBackMethod.Value) : null ),
                new KeyValuePair<string, object>( "HeartBeatUrl", input.HeartBeatUrl ),
                new KeyValuePair<string, object>( "HeartBeatMethod", (input.HeartBeatMethod.HasValue) ? Models.HttpActionEnumHelper.ToValue(input.HeartBeatMethod.Value) : null ),
                new KeyValuePair<string, object>( "Timeout", input.Timeout ),
                new KeyValuePair<string, object>( "PlayDtmf", input.PlayDtmf ),
                new KeyValuePair<string, object>( "HideCallerId", input.HideCallerId ),
                new KeyValuePair<string, object>( "Record", input.Record ),
                new KeyValuePair<string, object>( "RecordCallBackUrl", input.RecordCallBackUrl ),
                new KeyValuePair<string, object>( "RecordCallBackMethod", (input.RecordCallBackMethod.HasValue) ? Models.HttpActionEnumHelper.ToValue(input.RecordCallBackMethod.Value) : null ),
                new KeyValuePair<string, object>( "Transcribe", input.Transcribe ),
                new KeyValuePair<string, object>( "TranscribeCallBackUrl", input.TranscribeCallBackUrl ),
                new KeyValuePair<string, object>( "IfMachine", (input.IfMachine.HasValue) ? Models.IfMachineEnumHelper.ToValue(input.IfMachine.Value) : null ),
                new KeyValuePair<string, object>( "IfMachineUrl", input.IfMachineUrl ),
                new KeyValuePair<string, object>( "IfMachineMethod", (input.IfMachineMethod.HasValue) ? Models.HttpActionEnumHelper.ToValue(input.IfMachineMethod.Value) : null ),
                new KeyValuePair<string, object>( "Feedback", input.Feedback ),
                new KeyValuePair<string, object>( "SurveyId", input.SurveyId )
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
        /// Play Dtmf and send the Digit
        /// </summary>
        /// <param name="Models.PlayAudioInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string PlayAudio(Models.PlayAudioInput input)
        {
            Task<string> t = PlayAudioAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Play Dtmf and send the Digit
        /// </summary>
        /// <param name="Models.PlayAudioInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> PlayAudioAsync(Models.PlayAudioInput input)
        {
            //validating required parameters
            if (null == input.CallSid)
                throw new ArgumentNullException("callSid", "The property \"CallSid\" in the input object cannot be null.");

            if (null == input.AudioUrl)
                throw new ArgumentNullException("audioUrl", "The property \"AudioUrl\" in the input object cannot be null.");

            if (null == input.SayText)
                throw new ArgumentNullException("sayText", "The property \"SayText\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
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
                { "user-agent", "ytel-api" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "CallSid", input.CallSid ),
                new KeyValuePair<string, object>( "AudioUrl", input.AudioUrl ),
                new KeyValuePair<string, object>( "SayText", input.SayText ),
                new KeyValuePair<string, object>( "Length", input.Length ),
                new KeyValuePair<string, object>( "Direction", (input.Direction.HasValue) ? Models.DirectionEnumHelper.ToValue(input.Direction.Value) : null ),
                new KeyValuePair<string, object>( "Mix", input.Mix )
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
        /// Start or stop recording of an in-progress voice call.
        /// </summary>
        /// <param name="Models.RecordCallInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string RecordCall(Models.RecordCallInput input)
        {
            Task<string> t = RecordCallAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Start or stop recording of an in-progress voice call.
        /// </summary>
        /// <param name="Models.RecordCallInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> RecordCallAsync(Models.RecordCallInput input)
        {
            //validating required parameters
            if (null == input.CallSid)
                throw new ArgumentNullException("callSid", "The property \"CallSid\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
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
                { "user-agent", "ytel-api" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "CallSid", input.CallSid ),
                new KeyValuePair<string, object>( "Record", input.Record ),
                new KeyValuePair<string, object>( "Direction", (input.Direction.HasValue) ? Models.DirectionEnumHelper.ToValue(input.Direction.Value) : null ),
                new KeyValuePair<string, object>( "TimeLimit", input.TimeLimit ),
                new KeyValuePair<string, object>( "CallBackUrl", input.CallBackUrl ),
                new KeyValuePair<string, object>( "Fileformat", (input.Fileformat.HasValue) ? Models.AudioFormatEnumHelper.ToValue(input.Fileformat.Value) : null )
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
        /// Add audio voice effects to the an in-progress voice call.
        /// </summary>
        /// <param name="Models.VoiceEffectInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string VoiceEffect(Models.VoiceEffectInput input)
        {
            Task<string> t = VoiceEffectAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Add audio voice effects to the an in-progress voice call.
        /// </summary>
        /// <param name="Models.VoiceEffectInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> VoiceEffectAsync(Models.VoiceEffectInput input)
        {
            //validating required parameters
            if (null == input.CallSid)
                throw new ArgumentNullException("callSid", "The property \"CallSid\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
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
                { "user-agent", "ytel-api" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "CallSid", input.CallSid ),
                new KeyValuePair<string, object>( "AudioDirection", (input.AudioDirection.HasValue) ? Models.AudioDirectionEnumHelper.ToValue(input.AudioDirection.Value) : null ),
                new KeyValuePair<string, object>( "PitchSemiTones", input.PitchSemiTones ),
                new KeyValuePair<string, object>( "PitchOctaves", input.PitchOctaves ),
                new KeyValuePair<string, object>( "Pitch", input.Pitch ),
                new KeyValuePair<string, object>( "Rate", input.Rate ),
                new KeyValuePair<string, object>( "Tempo", input.Tempo )
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
        /// Play Dtmf and send the Digit
        /// </summary>
        /// <param name="Models.SendDigitInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string SendDigit(Models.SendDigitInput input)
        {
            Task<string> t = SendDigitAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Play Dtmf and send the Digit
        /// </summary>
        /// <param name="Models.SendDigitInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> SendDigitAsync(Models.SendDigitInput input)
        {
            //validating required parameters
            if (null == input.CallSid)
                throw new ArgumentNullException("callSid", "The property \"CallSid\" in the input object cannot be null.");

            if (null == input.PlayDtmf)
                throw new ArgumentNullException("playDtmf", "The property \"PlayDtmf\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
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
                { "user-agent", "ytel-api" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "CallSid", input.CallSid ),
                new KeyValuePair<string, object>( "PlayDtmf", input.PlayDtmf ),
                new KeyValuePair<string, object>( "PlayDtmfDirection", (input.PlayDtmfDirection.HasValue) ? Models.DirectionEnumHelper.ToValue(input.PlayDtmfDirection.Value) : null )
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
        /// Interrupt the Call by Call Sid
        /// </summary>
        /// <param name="Models.InterruptedCallInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string InterruptedCall(Models.InterruptedCallInput input)
        {
            Task<string> t = InterruptedCallAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Interrupt the Call by Call Sid
        /// </summary>
        /// <param name="Models.InterruptedCallInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> InterruptedCallAsync(Models.InterruptedCallInput input)
        {
            //validating required parameters
            if (null == input.CallSid)
                throw new ArgumentNullException("callSid", "The property \"CallSid\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
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
                { "user-agent", "ytel-api" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "CallSid", input.CallSid ),
                new KeyValuePair<string, object>( "Url", input.Url ),
                new KeyValuePair<string, object>( "Method", (input.Method.HasValue) ? Models.HttpActionEnumHelper.ToValue(input.Method.Value) : null ),
                new KeyValuePair<string, object>( "Status", (input.Status.HasValue) ? Models.InterruptedCallStatusEnumHelper.ToValue(input.Status.Value) : null )
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
        /// A list of calls associated with your Ytel account
        /// </summary>
        /// <param name="Models.ListCallsInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string ListCalls(Models.ListCallsInput input)
        {
            Task<string> t = ListCallsAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// A list of calls associated with your Ytel account
        /// </summary>
        /// <param name="Models.ListCallsInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> ListCallsAsync(Models.ListCallsInput input)
        {
            //validating required parameters
            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
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
                { "user-agent", "ytel-api" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "Page", input.Page ),
                new KeyValuePair<string, object>( "PageSize", input.PageSize ),
                new KeyValuePair<string, object>( "To", input.To ),
                new KeyValuePair<string, object>( "From", input.From ),
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

        /// <summary>
        /// Initiate an outbound Ringless Voicemail through Ytel.
        /// </summary>
        /// <param name="Models.SendRinglessVMInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string SendRinglessVM(Models.SendRinglessVMInput input)
        {
            Task<string> t = SendRinglessVMAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Initiate an outbound Ringless Voicemail through Ytel.
        /// </summary>
        /// <param name="Models.SendRinglessVMInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> SendRinglessVMAsync(Models.SendRinglessVMInput input)
        {
            //validating required parameters
            if (null == input.From)
                throw new ArgumentNullException("mfrom", "The property \"From\" in the input object cannot be null.");

            if (null == input.RVMCallerId)
                throw new ArgumentNullException("rVMCallerId", "The property \"RVMCallerId\" in the input object cannot be null.");

            if (null == input.To)
                throw new ArgumentNullException("to", "The property \"To\" in the input object cannot be null.");

            if (null == input.VoiceMailURL)
                throw new ArgumentNullException("voiceMailURL", "The property \"VoiceMailURL\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/calls/makervm.{ResponseType}");

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
                new KeyValuePair<string, object>( "From", input.From ),
                new KeyValuePair<string, object>( "RVMCallerId", input.RVMCallerId ),
                new KeyValuePair<string, object>( "To", input.To ),
                new KeyValuePair<string, object>( "VoiceMailURL", input.VoiceMailURL ),
                new KeyValuePair<string, object>( "Method", (input.Method.HasValue) ? Models.HttpActionEnumHelper.ToValue(input.Method.Value) : "GET" ),
                new KeyValuePair<string, object>( "StatusCallBackUrl", input.StatusCallBackUrl ),
                new KeyValuePair<string, object>( "StatsCallBackMethod", (input.StatsCallBackMethod.HasValue) ? Models.HttpActionEnumHelper.ToValue(input.StatsCallBackMethod.Value) : null )
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
        /// Retrieve a single voice call’s information by its CallSid.
        /// </summary>
        /// <param name="Models.ViewCallInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string ViewCall(Models.ViewCallInput input)
        {
            Task<string> t = ViewCallAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a single voice call’s information by its CallSid.
        /// </summary>
        /// <param name="Models.ViewCallInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> ViewCallAsync(Models.ViewCallInput input)
        {
            //validating required parameters
            if (null == input.Callsid)
                throw new ArgumentNullException("callsid", "The property \"Callsid\" in the input object cannot be null.");

            if (null == input.ResponseType)
                throw new ArgumentNullException("responseType", "The property \"ResponseType\" in the input object cannot be null.");

            //the base uri for api requests
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
                { "user-agent", "ytel-api" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "callsid", input.Callsid )
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
        /// Retrieve a single voice call’s information by its CallSid.
        /// </summary>
        /// <param name="callSid">Required parameter: The unique identifier for the voice call.</param>
        /// <param name="responseType">Required parameter: Response type format xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public string ViewCallDetail(string callSid, string responseType)
        {
            Task<string> t = ViewCallDetailAsync(callSid, responseType);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a single voice call’s information by its CallSid.
        /// </summary>
        /// <param name="callSid">Required parameter: The unique identifier for the voice call.</param>
        /// <param name="responseType">Required parameter: Response type format xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> ViewCallDetailAsync(string callSid, string responseType)
        {
            //validating required parameters
            if (null == callSid)
                throw new ArgumentNullException("callSid", "The parameter \"callSid\" is a required parameter and cannot be null.");

            if (null == responseType)
                throw new ArgumentNullException("responseType", "The parameter \"responseType\" is a required parameter and cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/calls/viewcalldetail.{ResponseType}");

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
                { "user-agent", "ytel-api" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "callSid", callSid )
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
        /// Group Call
        /// </summary>
        /// <param name="Models.GroupCallInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string GroupCall(Models.GroupCallInput input)
        {
            Task<string> t = GroupCallAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Group Call
        /// </summary>
        /// <param name="Models.GroupCallInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GroupCallAsync(Models.GroupCallInput input)
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

            if (null == input.GroupConfirmKey)
                throw new ArgumentNullException("groupConfirmKey", "The property \"GroupConfirmKey\" in the input object cannot be null.");

            //the base uri for api requests
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
                { "user-agent", "ytel-api" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "From", input.From ),
                new KeyValuePair<string, object>( "To", input.To ),
                new KeyValuePair<string, object>( "Url", input.Url ),
                new KeyValuePair<string, object>( "GroupConfirmKey", input.GroupConfirmKey ),
                new KeyValuePair<string, object>( "GroupConfirmFile", Models.AudioFormatEnumHelper.ToValue(input.GroupConfirmFile) ),
                new KeyValuePair<string, object>( "Method", (input.Method.HasValue) ? Models.HttpActionEnumHelper.ToValue(input.Method.Value) : null ),
                new KeyValuePair<string, object>( "StatusCallBackUrl", input.StatusCallBackUrl ),
                new KeyValuePair<string, object>( "StatusCallBackMethod", (input.StatusCallBackMethod.HasValue) ? Models.HttpActionEnumHelper.ToValue(input.StatusCallBackMethod.Value) : null ),
                new KeyValuePair<string, object>( "FallBackUrl", input.FallBackUrl ),
                new KeyValuePair<string, object>( "FallBackMethod", (input.FallBackMethod.HasValue) ? Models.HttpActionEnumHelper.ToValue(input.FallBackMethod.Value) : null ),
                new KeyValuePair<string, object>( "HeartBeatUrl", input.HeartBeatUrl ),
                new KeyValuePair<string, object>( "HeartBeatMethod", (input.HeartBeatMethod.HasValue) ? Models.HttpActionEnumHelper.ToValue(input.HeartBeatMethod.Value) : null ),
                new KeyValuePair<string, object>( "Timeout", input.Timeout ),
                new KeyValuePair<string, object>( "PlayDtmf", input.PlayDtmf ),
                new KeyValuePair<string, object>( "HideCallerId", input.HideCallerId ),
                new KeyValuePair<string, object>( "Record", input.Record ),
                new KeyValuePair<string, object>( "RecordCallBackUrl", input.RecordCallBackUrl ),
                new KeyValuePair<string, object>( "RecordCallBackMethod", (input.RecordCallBackMethod.HasValue) ? Models.HttpActionEnumHelper.ToValue(input.RecordCallBackMethod.Value) : null ),
                new KeyValuePair<string, object>( "Transcribe", input.Transcribe ),
                new KeyValuePair<string, object>( "TranscribeCallBackUrl", input.TranscribeCallBackUrl )
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