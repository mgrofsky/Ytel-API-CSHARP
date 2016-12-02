/*
 * Message360.PCL
 *
 * This file was automatically generated for message360 by APIMATIC v2.0 ( https://apimatic.io ) on 12/02/2016
 */
using System;
using message360.Controllers;
using message360.Http.Client;

namespace message360
{
    public partial class Message360Client
    {

        /// <summary>
        /// Singleton access to Conference controller
        /// </summary>
        public ConferenceController Conference
        {
            get
            {
                return ConferenceController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Email controller
        /// </summary>
        public EmailController Email
        {
            get
            {
                return EmailController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to NumberVerification controller
        /// </summary>
        public NumberVerificationController NumberVerification
        {
            get
            {
                return NumberVerificationController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Carrier controller
        /// </summary>
        public CarrierController Carrier
        {
            get
            {
                return CarrierController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Call controller
        /// </summary>
        public CallController Call
        {
            get
            {
                return CallController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to SMS controller
        /// </summary>
        public SMSController SMS
        {
            get
            {
                return SMSController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Account controller
        /// </summary>
        public AccountController Account
        {
            get
            {
                return AccountController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to WebRTC controller
        /// </summary>
        public WebRTCController WebRTC
        {
            get
            {
                return WebRTCController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to SubAccount controller
        /// </summary>
        public SubAccountController SubAccount
        {
            get
            {
                return SubAccountController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Address controller
        /// </summary>
        public AddressController Address
        {
            get
            {
                return AddressController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to PhoneNumber controller
        /// </summary>
        public PhoneNumberController PhoneNumber
        {
            get
            {
                return PhoneNumberController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Recording controller
        /// </summary>
        public RecordingController Recording
        {
            get
            {
                return RecordingController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Transcription controller
        /// </summary>
        public TranscriptionController Transcription
        {
            get
            {
                return TranscriptionController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Usage controller
        /// </summary>
        public UsageController Usage
        {
            get
            {
                return UsageController.Instance;
            }
        }
        /// <summary>
        /// The shared http client to use for all API calls
        /// </summary>
        public IHttpClient SharedHttpClient
        {
            get
            {
                return BaseController.ClientInstance;
            }
            set
            {
                BaseController.ClientInstance = value;
            }        
        }
        
        /// <summary>
        /// Default constructor
        /// </summary>
        public Message360Client() { }

        /// <summary>
        /// Client initialization constructor
        /// </summary>
        public Message360Client(string basicAuthUserName, string basicAuthPassword)
        {
            Configuration.BasicAuthUserName = basicAuthUserName;
            Configuration.BasicAuthPassword = basicAuthPassword;
        }
    }
}