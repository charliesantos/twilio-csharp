/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Serverless.V1.Service.Asset 
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// Retrieve a list of all Asset Versions.
    /// </summary>
    public class ReadAssetVersionOptions : ReadOptions<AssetVersionResource> 
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Asset Sid.
        /// </summary>
        public string PathAssetSid { get; }

        /// <summary>
        /// Construct a new ReadAssetVersionOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathAssetSid"> Asset Sid. </param>
        public ReadAssetVersionOptions(string pathServiceSid, string pathAssetSid)
        {
            PathServiceSid = pathServiceSid;
            PathAssetSid = pathAssetSid;
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
    /// Retrieve a specific Asset Version.
    /// </summary>
    public class FetchAssetVersionOptions : IOptions<AssetVersionResource> 
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Asset Sid.
        /// </summary>
        public string PathAssetSid { get; }
        /// <summary>
        /// Asset Version Sid.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchAssetVersionOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathAssetSid"> Asset Sid. </param>
        /// <param name="pathSid"> Asset Version Sid. </param>
        public FetchAssetVersionOptions(string pathServiceSid, string pathAssetSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathAssetSid = pathAssetSid;
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
    /// Create a new Asset Version.
    /// </summary>
    public class CreateAssetVersionOptions : IOptions<AssetVersionResource> 
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Asset Sid.
        /// </summary>
        public string PathAssetSid { get; }
        /// <summary>
        /// The URL-friendly string by which this Asset Version can be referenced.
        /// </summary>
        public string Path { get; }
        /// <summary>
        /// The access control which determines how the Asset Version can be accessed.
        /// </summary>
        public AssetVersionResource.VisibilityEnum Visibility { get; }

        /// <summary>
        /// Construct a new CreateAssetVersionOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathAssetSid"> Asset Sid. </param>
        /// <param name="path"> The URL-friendly string by which this Asset Version can be referenced. </param>
        /// <param name="visibility"> The access control which determines how the Asset Version can be accessed. </param>
        public CreateAssetVersionOptions(string pathServiceSid, 
                                         string pathAssetSid, 
                                         string path, 
                                         AssetVersionResource.VisibilityEnum visibility)
        {
            PathServiceSid = pathServiceSid;
            PathAssetSid = pathAssetSid;
            Path = path;
            Visibility = visibility;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Path != null)
            {
                p.Add(new KeyValuePair<string, string>("Path", Path));
            }

            if (Visibility != null)
            {
                p.Add(new KeyValuePair<string, string>("Visibility", Visibility.ToString()));
            }

            return p;
        }
    }

}