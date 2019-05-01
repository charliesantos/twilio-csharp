/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Serverless.V1.Service.Environment 
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// Retrieve a list of all Variables.
    /// </summary>
    public class ReadVariableOptions : ReadOptions<VariableResource> 
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Environment Sid.
        /// </summary>
        public string PathEnvironmentSid { get; }

        /// <summary>
        /// Construct a new ReadVariableOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathEnvironmentSid"> Environment Sid. </param>
        public ReadVariableOptions(string pathServiceSid, string pathEnvironmentSid)
        {
            PathServiceSid = pathServiceSid;
            PathEnvironmentSid = pathEnvironmentSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// Retrieve a specific Variable.
    /// </summary>
    public class FetchVariableOptions : IOptions<VariableResource> 
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Environment Sid.
        /// </summary>
        public string PathEnvironmentSid { get; }
        /// <summary>
        /// Variable Sid.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchVariableOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathEnvironmentSid"> Environment Sid. </param>
        /// <param name="pathSid"> Variable Sid. </param>
        public FetchVariableOptions(string pathServiceSid, string pathEnvironmentSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathEnvironmentSid = pathEnvironmentSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// Create a new Variable.
    /// </summary>
    public class CreateVariableOptions : IOptions<VariableResource> 
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Environment Sid.
        /// </summary>
        public string PathEnvironmentSid { get; }
        /// <summary>
        /// A string by which this Variable can be referenced.
        /// </summary>
        public string Key { get; }
        /// <summary>
        /// A string that contains the actual value of this Variable.
        /// </summary>
        public string Value { get; }

        /// <summary>
        /// Construct a new CreateVariableOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathEnvironmentSid"> Environment Sid. </param>
        /// <param name="key"> A string by which this Variable can be referenced. </param>
        /// <param name="value"> A string that contains the actual value of this Variable. </param>
        public CreateVariableOptions(string pathServiceSid, string pathEnvironmentSid, string key, string value)
        {
            PathServiceSid = pathServiceSid;
            PathEnvironmentSid = pathEnvironmentSid;
            Key = key;
            Value = value;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Key != null)
            {
                p.Add(new KeyValuePair<string, string>("Key", Key));
            }

            if (Value != null)
            {
                p.Add(new KeyValuePair<string, string>("Value", Value));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// Update a specific Variable.
    /// </summary>
    public class UpdateVariableOptions : IOptions<VariableResource> 
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Environment Sid.
        /// </summary>
        public string PathEnvironmentSid { get; }
        /// <summary>
        /// Variable Sid.
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// A string by which this Variable can be referenced.
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// A string that contains the actual value of this Variable.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Construct a new UpdateVariableOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathEnvironmentSid"> Environment Sid. </param>
        /// <param name="pathSid"> Variable Sid. </param>
        public UpdateVariableOptions(string pathServiceSid, string pathEnvironmentSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathEnvironmentSid = pathEnvironmentSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Key != null)
            {
                p.Add(new KeyValuePair<string, string>("Key", Key));
            }

            if (Value != null)
            {
                p.Add(new KeyValuePair<string, string>("Value", Value));
            }

            return p;
        }
    }

}