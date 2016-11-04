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
        /// <param name="callsid">Required parameter: Call Sid id for particular Call</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateViewCall(string callsid, string responseType = "json")
        {
            Task<string> t = CreateViewCallAsync(callsid, responseType);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// View Call Response
        /// </summary>
        /// <param name="callsid">Required parameter: Call Sid id for particular Call</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateViewCallAsync(string callsid, string responseType = "json")
        {
            //validating required parameters
            if (null == callsid)
                throw new ArgumentNullException("callsid", "The parameter \"callsid\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/calls/viewcalls.{ResponseType}");

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
                { "callsid", callsid }
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
        /// You can experiment with initiating a call through Message360 and view the request response generated when doing so and get the response in json
        /// </summary>
        /// <param name="fromCountryCode">Required parameter: from country code</param>
        /// <param name="mfrom">Required parameter: This number to display on Caller ID as calling</param>
        /// <param name="toCountryCode">Required parameter: To cuntry code number</param>
        /// <param name="to">Required parameter: To number</param>
        /// <param name="url">Required parameter: URL requested once the call connects</param>
        /// <param name="method">Optional parameter: Specifies the HTTP method used to request the required URL once call connects.</param>
        /// <param name="statusCallBackUrl">Optional parameter: specifies the HTTP methodlinkclass used to request StatusCallbackUrl.</param>
        /// <param name="statusCallBackMethod">Optional parameter: Specifies the HTTP methodlinkclass used to request StatusCallbackUrl.</param>
        /// <param name="fallBackUrl">Optional parameter: URL requested if the initial Url parameter fails or encounters an error</param>
        /// <param name="fallBackMethod">Optional parameter: Specifies the HTTP method used to request the required FallbackUrl once call connects.</param>
        /// <param name="heartBeatUrl">Optional parameter: URL that can be requested every 60 seconds during the call to notify of elapsed tim</param>
        /// <param name="heartBeatMethod">Optional parameter: Specifies the HTTP method used to request HeartbeatUrl.</param>
        /// <param name="timeout">Optional parameter: Time (in seconds) Message360 should wait while the call is ringing before canceling the call</param>
        /// <param name="playDtmf">Optional parameter: DTMF Digits to play to the call once it connects. 0-9, #, or *</param>
        /// <param name="hideCallerId">Optional parameter: Specifies if the caller id will be hidden</param>
        /// <param name="record">Optional parameter: Specifies if the call should be recorded</param>
        /// <param name="recordCallBackUrl">Optional parameter: Recording parameters will be sent here upon completion</param>
        /// <param name="recordCallBackMethod">Optional parameter: Method used to request the RecordCallback URL.</param>
        /// <param name="transcribe">Optional parameter: Specifies if the call recording should be transcribed</param>
        /// <param name="transcribeCallBackUrl">Optional parameter: Transcription parameters will be sent here upon completion</param>
        /// <param name="ifMachine">Optional parameter: How Message360 should handle the receiving numbers voicemail machine</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateMakeCall(
                string fromCountryCode,
                string mfrom,
                string toCountryCode,
                string to,
                string url,
                HttpAction? method = null,
                string statusCallBackUrl = null,
                HttpAction? statusCallBackMethod = null,
                string fallBackUrl = null,
                HttpAction? fallBackMethod = null,
                string heartBeatUrl = null,
                bool? heartBeatMethod = null,
                int? timeout = null,
                string playDtmf = null,
                bool? hideCallerId = null,
                bool? record = null,
                string recordCallBackUrl = null,
                HttpAction? recordCallBackMethod = null,
                bool? transcribe = null,
                string transcribeCallBackUrl = null,
                IfMachine? ifMachine = null,
                string responseType = "json")
        {
            Task<string> t = CreateMakeCallAsync(fromCountryCode, mfrom, toCountryCode, to, url, method, statusCallBackUrl, statusCallBackMethod, fallBackUrl, fallBackMethod, heartBeatUrl, heartBeatMethod, timeout, playDtmf, hideCallerId, record, recordCallBackUrl, recordCallBackMethod, transcribe, transcribeCallBackUrl, ifMachine, responseType);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// You can experiment with initiating a call through Message360 and view the request response generated when doing so and get the response in json
        /// </summary>
        /// <param name="fromCountryCode">Required parameter: from country code</param>
        /// <param name="mfrom">Required parameter: This number to display on Caller ID as calling</param>
        /// <param name="toCountryCode">Required parameter: To cuntry code number</param>
        /// <param name="to">Required parameter: To number</param>
        /// <param name="url">Required parameter: URL requested once the call connects</param>
        /// <param name="method">Optional parameter: Specifies the HTTP method used to request the required URL once call connects.</param>
        /// <param name="statusCallBackUrl">Optional parameter: specifies the HTTP methodlinkclass used to request StatusCallbackUrl.</param>
        /// <param name="statusCallBackMethod">Optional parameter: Specifies the HTTP methodlinkclass used to request StatusCallbackUrl.</param>
        /// <param name="fallBackUrl">Optional parameter: URL requested if the initial Url parameter fails or encounters an error</param>
        /// <param name="fallBackMethod">Optional parameter: Specifies the HTTP method used to request the required FallbackUrl once call connects.</param>
        /// <param name="heartBeatUrl">Optional parameter: URL that can be requested every 60 seconds during the call to notify of elapsed tim</param>
        /// <param name="heartBeatMethod">Optional parameter: Specifies the HTTP method used to request HeartbeatUrl.</param>
        /// <param name="timeout">Optional parameter: Time (in seconds) Message360 should wait while the call is ringing before canceling the call</param>
        /// <param name="playDtmf">Optional parameter: DTMF Digits to play to the call once it connects. 0-9, #, or *</param>
        /// <param name="hideCallerId">Optional parameter: Specifies if the caller id will be hidden</param>
        /// <param name="record">Optional parameter: Specifies if the call should be recorded</param>
        /// <param name="recordCallBackUrl">Optional parameter: Recording parameters will be sent here upon completion</param>
        /// <param name="recordCallBackMethod">Optional parameter: Method used to request the RecordCallback URL.</param>
        /// <param name="transcribe">Optional parameter: Specifies if the call recording should be transcribed</param>
        /// <param name="transcribeCallBackUrl">Optional parameter: Transcription parameters will be sent here upon completion</param>
        /// <param name="ifMachine">Optional parameter: How Message360 should handle the receiving numbers voicemail machine</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateMakeCallAsync(
                string fromCountryCode,
                string mfrom,
                string toCountryCode,
                string to,
                string url,
                HttpAction? method = null,
                string statusCallBackUrl = null,
                HttpAction? statusCallBackMethod = null,
                string fallBackUrl = null,
                HttpAction? fallBackMethod = null,
                string heartBeatUrl = null,
                bool? heartBeatMethod = null,
                int? timeout = null,
                string playDtmf = null,
                bool? hideCallerId = null,
                bool? record = null,
                string recordCallBackUrl = null,
                HttpAction? recordCallBackMethod = null,
                bool? transcribe = null,
                string transcribeCallBackUrl = null,
                IfMachine? ifMachine = null,
                string responseType = "json")
        {
            //validating required parameters
            if (null == fromCountryCode)
                throw new ArgumentNullException("fromCountryCode", "The parameter \"fromCountryCode\" is a required parameter and cannot be null.");

            if (null == mfrom)
                throw new ArgumentNullException("mfrom", "The parameter \"mfrom\" is a required parameter and cannot be null.");

            if (null == toCountryCode)
                throw new ArgumentNullException("toCountryCode", "The parameter \"toCountryCode\" is a required parameter and cannot be null.");

            if (null == to)
                throw new ArgumentNullException("to", "The parameter \"to\" is a required parameter and cannot be null.");

            if (null == url)
                throw new ArgumentNullException("url", "The parameter \"url\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/calls/makecall.{ResponseType}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "ResponseType", (null != responseType) ? responseType : "json" }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "Method", (method.HasValue) ? HttpActionHelper.ToValue(method.Value) : null }
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
                { "FromCountryCode", fromCountryCode },
                { "From", mfrom },
                { "ToCountryCode", toCountryCode },
                { "To", to },
                { "Url", url },
                { "StatusCallBackUrl", statusCallBackUrl },
                { "StatusCallBackMethod", (statusCallBackMethod.HasValue) ? HttpActionHelper.ToValue(statusCallBackMethod.Value) : null },
                { "FallBackUrl", fallBackUrl },
                { "FallBackMethod", (fallBackMethod.HasValue) ? HttpActionHelper.ToValue(fallBackMethod.Value) : null },
                { "HeartBeatUrl", heartBeatUrl },
                { "HeartBeatMethod", heartBeatMethod },
                { "Timeout", timeout },
                { "PlayDtmf", playDtmf },
                { "HideCallerId", hideCallerId },
                { "Record", record },
                { "RecordCallBackUrl", recordCallBackUrl },
                { "RecordCallBackMethod", (recordCallBackMethod.HasValue) ? HttpActionHelper.ToValue(recordCallBackMethod.Value) : null },
                { "Transcribe", transcribe },
                { "TranscribeCallBackUrl", transcribeCallBackUrl },
                { "IfMachine", (ifMachine.HasValue) ? IfMachineHelper.ToValue(ifMachine.Value) : null }
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
        /// Play Dtmf and send the Digit
        /// </summary>
        /// <param name="length">Required parameter: Time limit in seconds for audio play back</param>
        /// <param name="direction">Required parameter: The leg of the call audio will be played to</param>
        /// <param name="loop">Required parameter: Repeat audio playback indefinitely</param>
        /// <param name="mix">Required parameter: If false, all other audio will be muted</param>
        /// <param name="callSid">Optional parameter: The unique identifier of each call resource</param>
        /// <param name="audioUrl">Optional parameter: URL to sound that should be played. You also can add more than one audio file using semicolons e.g. http://example.com/audio1.mp3;http://example.com/audio2.wav</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public string CreatePlayAudio(
                int length,
                Direction direction,
                bool loop,
                bool mix,
                string callSid = null,
                string audioUrl = null,
                string responseType = "json")
        {
            Task<string> t = CreatePlayAudioAsync(length, direction, loop, mix, callSid, audioUrl, responseType);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Play Dtmf and send the Digit
        /// </summary>
        /// <param name="length">Required parameter: Time limit in seconds for audio play back</param>
        /// <param name="direction">Required parameter: The leg of the call audio will be played to</param>
        /// <param name="loop">Required parameter: Repeat audio playback indefinitely</param>
        /// <param name="mix">Required parameter: If false, all other audio will be muted</param>
        /// <param name="callSid">Optional parameter: The unique identifier of each call resource</param>
        /// <param name="audioUrl">Optional parameter: URL to sound that should be played. You also can add more than one audio file using semicolons e.g. http://example.com/audio1.mp3;http://example.com/audio2.wav</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreatePlayAudioAsync(
                int length,
                Direction direction,
                bool loop,
                bool mix,
                string callSid = null,
                string audioUrl = null,
                string responseType = "json")
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/calls/playaudios.{ResponseType}");

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
                { "Length", length },
                { "Direction", DirectionHelper.ToValue(direction) },
                { "Loop", loop },
                { "Mix", mix },
                { "CallSid", callSid },
                { "AudioUrl", audioUrl }
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
        /// Record a Call
        /// </summary>
        /// <param name="callSid">Required parameter: The unique identifier of each call resource</param>
        /// <param name="record">Required parameter: Set true to initiate recording or false to terminate recording</param>
        /// <param name="direction">Optional parameter: The leg of the call to record</param>
        /// <param name="timeLimit">Optional parameter: Time in seconds the recording duration should not exceed</param>
        /// <param name="callBackUrl">Optional parameter: URL consulted after the recording completes</param>
        /// <param name="fileformat">Optional parameter: Format of the recording file. Can be .mp3 or .wav</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateRecordCall(
                string callSid,
                bool record,
                Direction? direction = null,
                int? timeLimit = null,
                string callBackUrl = null,
                AudioFormat? fileformat = null,
                string responseType = "json")
        {
            Task<string> t = CreateRecordCallAsync(callSid, record, direction, timeLimit, callBackUrl, fileformat, responseType);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Record a Call
        /// </summary>
        /// <param name="callSid">Required parameter: The unique identifier of each call resource</param>
        /// <param name="record">Required parameter: Set true to initiate recording or false to terminate recording</param>
        /// <param name="direction">Optional parameter: The leg of the call to record</param>
        /// <param name="timeLimit">Optional parameter: Time in seconds the recording duration should not exceed</param>
        /// <param name="callBackUrl">Optional parameter: URL consulted after the recording completes</param>
        /// <param name="fileformat">Optional parameter: Format of the recording file. Can be .mp3 or .wav</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateRecordCallAsync(
                string callSid,
                bool record,
                Direction? direction = null,
                int? timeLimit = null,
                string callBackUrl = null,
                AudioFormat? fileformat = null,
                string responseType = "json")
        {
            //validating required parameters
            if (null == callSid)
                throw new ArgumentNullException("callSid", "The parameter \"callSid\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/calls/recordcalls.{ResponseType}");

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
                { "CallSid", callSid },
                { "Record", record },
                { "Direction", (direction.HasValue) ? DirectionHelper.ToValue(direction.Value) : null },
                { "TimeLimit", timeLimit },
                { "CallBackUrl", callBackUrl },
                { "Fileformat", (fileformat.HasValue) ? AudioFormatHelper.ToValue(fileformat.Value) : null }
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
        /// Voice Effect
        /// </summary>
        /// <param name="callSid">Required parameter: Example: </param>
        /// <param name="audioDirection">Optional parameter: Example: </param>
        /// <param name="pitchSemiTones">Optional parameter: value between -14 and 14</param>
        /// <param name="pitchOctaves">Optional parameter: value between -1 and 1</param>
        /// <param name="pitch">Optional parameter: value greater than 0</param>
        /// <param name="rate">Optional parameter: value greater than 0</param>
        /// <param name="tempo">Optional parameter: value greater than 0</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateVoiceEffect(
                string callSid,
                AudioDirection? audioDirection = null,
                double? pitchSemiTones = null,
                double? pitchOctaves = null,
                double? pitch = null,
                double? rate = null,
                double? tempo = null,
                string responseType = "json")
        {
            Task<string> t = CreateVoiceEffectAsync(callSid, audioDirection, pitchSemiTones, pitchOctaves, pitch, rate, tempo, responseType);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Voice Effect
        /// </summary>
        /// <param name="callSid">Required parameter: Example: </param>
        /// <param name="audioDirection">Optional parameter: Example: </param>
        /// <param name="pitchSemiTones">Optional parameter: value between -14 and 14</param>
        /// <param name="pitchOctaves">Optional parameter: value between -1 and 1</param>
        /// <param name="pitch">Optional parameter: value greater than 0</param>
        /// <param name="rate">Optional parameter: value greater than 0</param>
        /// <param name="tempo">Optional parameter: value greater than 0</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateVoiceEffectAsync(
                string callSid,
                AudioDirection? audioDirection = null,
                double? pitchSemiTones = null,
                double? pitchOctaves = null,
                double? pitch = null,
                double? rate = null,
                double? tempo = null,
                string responseType = "json")
        {
            //validating required parameters
            if (null == callSid)
                throw new ArgumentNullException("callSid", "The parameter \"callSid\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/calls/voiceeffect.{ResponseType}");

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
                { "CallSid", callSid },
                { "AudioDirection", (audioDirection.HasValue) ? AudioDirectionHelper.ToValue(audioDirection.Value) : null },
                { "PitchSemiTones", pitchSemiTones },
                { "PitchOctaves", pitchOctaves },
                { "Pitch", pitch },
                { "Rate", rate },
                { "Tempo", tempo }
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
        /// Play Dtmf and send the Digit
        /// </summary>
        /// <param name="callSid">Required parameter: The unique identifier of each call resource</param>
        /// <param name="playDtmf">Required parameter: DTMF digits to play to the call. 0-9, #, *, W, or w</param>
        /// <param name="playDtmfDirection">Optional parameter: The leg of the call DTMF digits should be sent to</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateSendDigit(
                string callSid,
                string playDtmf,
                Direction? playDtmfDirection = null,
                string responseType = "json")
        {
            Task<string> t = CreateSendDigitAsync(callSid, playDtmf, playDtmfDirection, responseType);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Play Dtmf and send the Digit
        /// </summary>
        /// <param name="callSid">Required parameter: The unique identifier of each call resource</param>
        /// <param name="playDtmf">Required parameter: DTMF digits to play to the call. 0-9, #, *, W, or w</param>
        /// <param name="playDtmfDirection">Optional parameter: The leg of the call DTMF digits should be sent to</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateSendDigitAsync(
                string callSid,
                string playDtmf,
                Direction? playDtmfDirection = null,
                string responseType = "json")
        {
            //validating required parameters
            if (null == callSid)
                throw new ArgumentNullException("callSid", "The parameter \"callSid\" is a required parameter and cannot be null.");

            if (null == playDtmf)
                throw new ArgumentNullException("playDtmf", "The parameter \"playDtmf\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/calls/senddigits.{ResponseType}");

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
                { "CallSid", callSid },
                { "PlayDtmf", playDtmf },
                { "PlayDtmfDirection", (playDtmfDirection.HasValue) ? DirectionHelper.ToValue(playDtmfDirection.Value) : null }
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
        /// Interrupt the Call by Call Sid
        /// </summary>
        /// <param name="callSid">Required parameter: Call SId</param>
        /// <param name="url">Optional parameter: URL the in-progress call will be redirected to</param>
        /// <param name="method">Optional parameter: The method used to request the above Url parameter</param>
        /// <param name="status">Optional parameter: Status to set the in-progress call to</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateInterruptedCall(
                string callSid,
                string url = null,
                HttpAction? method = null,
                InterruptedCallStatus? status = null,
                string responseType = "json")
        {
            Task<string> t = CreateInterruptedCallAsync(callSid, url, method, status, responseType);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Interrupt the Call by Call Sid
        /// </summary>
        /// <param name="callSid">Required parameter: Call SId</param>
        /// <param name="url">Optional parameter: URL the in-progress call will be redirected to</param>
        /// <param name="method">Optional parameter: The method used to request the above Url parameter</param>
        /// <param name="status">Optional parameter: Status to set the in-progress call to</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateInterruptedCallAsync(
                string callSid,
                string url = null,
                HttpAction? method = null,
                InterruptedCallStatus? status = null,
                string responseType = "json")
        {
            //validating required parameters
            if (null == callSid)
                throw new ArgumentNullException("callSid", "The parameter \"callSid\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/calls/interruptcalls.{ResponseType}");

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
                { "CallSid", callSid },
                { "Url", url },
                { "Method", (method.HasValue) ? HttpActionHelper.ToValue(method.Value) : null },
                { "Status", (status.HasValue) ? InterruptedCallStatusHelper.ToValue(status.Value) : null }
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
        /// A list of calls associated with your Message360 account
        /// </summary>
        /// <param name="page">Optional parameter: Which page of the overall response will be returned. Zero indexed</param>
        /// <param name="pageSize">Optional parameter: Number of individual resources listed in the response per page</param>
        /// <param name="to">Optional parameter: Only list calls to this number</param>
        /// <param name="mfrom">Optional parameter: Only list calls from this number</param>
        /// <param name="dateCreated">Optional parameter: Only list calls starting within the specified date range</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the void response from the API call</return>
        public void CreateListCalls(
                string page = null,
                string pageSize = null,
                string to = null,
                string mfrom = null,
                string dateCreated = null,
                string responseType = "json")
        {
            Task t = CreateListCallsAsync(page, pageSize, to, mfrom, dateCreated, responseType);
            Task.WaitAll(t);
        }

        /// <summary>
        /// A list of calls associated with your Message360 account
        /// </summary>
        /// <param name="page">Optional parameter: Which page of the overall response will be returned. Zero indexed</param>
        /// <param name="pageSize">Optional parameter: Number of individual resources listed in the response per page</param>
        /// <param name="to">Optional parameter: Only list calls to this number</param>
        /// <param name="mfrom">Optional parameter: Only list calls from this number</param>
        /// <param name="dateCreated">Optional parameter: Only list calls starting within the specified date range</param>
        /// <param name="responseType">Optional parameter: Response format, xml or json</param>
        /// <return>Returns the void response from the API call</return>
        public async Task CreateListCallsAsync(
                string page = null,
                string pageSize = null,
                string to = null,
                string mfrom = null,
                string dateCreated = null,
                string responseType = "json")
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/calls/listcalls.{ResponseType}");

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
                { "To", to },
                { "From", mfrom },
                { "DateCreated", dateCreated }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

        }

    }
} 