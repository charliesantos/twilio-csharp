/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Chat.V2.Service.Channel
{

    /// <summary>
    /// FetchMemberOptions
    /// </summary>
    public class FetchMemberOptions : IOptions<MemberResource>
    {
        /// <summary>
        /// The SID of the Service to fetch the resource from
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the channel the member belongs to
        /// </summary>
        public string PathChannelSid { get; }
        /// <summary>
        /// The SID of the Member resource to fetch
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchMemberOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to fetch the resource from </param>
        /// <param name="pathChannelSid"> The SID of the channel the member belongs to </param>
        /// <param name="pathSid"> The SID of the Member resource to fetch </param>
        public FetchMemberOptions(string pathServiceSid, string pathChannelSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
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
    /// CreateMemberOptions
    /// </summary>
    public class CreateMemberOptions : IOptions<MemberResource>
    {
        /// <summary>
        /// The SID of the Service to create the resource under
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the channel the new member belongs to
        /// </summary>
        public string PathChannelSid { get; }
        /// <summary>
        /// The `identity` value that identifies the new resource's User
        /// </summary>
        public string Identity { get; }
        /// <summary>
        /// The SID of the Role to assign to the member
        /// </summary>
        public string RoleSid { get; set; }
        /// <summary>
        /// The index of the last Message in the Channel the Member has read
        /// </summary>
        public int? LastConsumedMessageIndex { get; set; }
        /// <summary>
        /// The ISO 8601 based timestamp string representing the datetime of the last Message read event for the member within the Channel
        /// </summary>
        public DateTime? LastConsumptionTimestamp { get; set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the resource was created
        /// </summary>
        public DateTime? DateCreated { get; set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the resource was updated
        /// </summary>
        public DateTime? DateUpdated { get; set; }
        /// <summary>
        /// A valid JSON string that contains application-specific data
        /// </summary>
        public string Attributes { get; set; }
        /// <summary>
        /// The X-Twilio-Webhook-Enabled HTTP request header
        /// </summary>
        public MemberResource.WebhookEnabledTypeEnum XTwilioWebhookEnabled { get; set; }

        /// <summary>
        /// Construct a new CreateMemberOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to create the resource under </param>
        /// <param name="pathChannelSid"> The SID of the channel the new member belongs to </param>
        /// <param name="identity"> The `identity` value that identifies the new resource's User </param>
        public CreateMemberOptions(string pathServiceSid, string pathChannelSid, string identity)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
            Identity = identity;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Identity != null)
            {
                p.Add(new KeyValuePair<string, string>("Identity", Identity));
            }

            if (RoleSid != null)
            {
                p.Add(new KeyValuePair<string, string>("RoleSid", RoleSid.ToString()));
            }

            if (LastConsumedMessageIndex != null)
            {
                p.Add(new KeyValuePair<string, string>("LastConsumedMessageIndex", LastConsumedMessageIndex.ToString()));
            }

            if (LastConsumptionTimestamp != null)
            {
                p.Add(new KeyValuePair<string, string>("LastConsumptionTimestamp", Serializers.DateTimeIso8601(LastConsumptionTimestamp)));
            }

            if (DateCreated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreated", Serializers.DateTimeIso8601(DateCreated)));
            }

            if (DateUpdated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateUpdated", Serializers.DateTimeIso8601(DateUpdated)));
            }

            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Attributes));
            }

            return p;
        }

        /// <summary>
        /// Generate the necessary header parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetHeaderParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (XTwilioWebhookEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("X-Twilio-Webhook-Enabled", XTwilioWebhookEnabled.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// ReadMemberOptions
    /// </summary>
    public class ReadMemberOptions : ReadOptions<MemberResource>
    {
        /// <summary>
        /// The SID of the Service to read the resources from
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the channel the member belongs to
        /// </summary>
        public string PathChannelSid { get; }
        /// <summary>
        /// The `identity` value of the resources to read
        /// </summary>
        public List<string> Identity { get; set; }

        /// <summary>
        /// Construct a new ReadMemberOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to read the resources from </param>
        /// <param name="pathChannelSid"> The SID of the channel the member belongs to </param>
        public ReadMemberOptions(string pathServiceSid, string pathChannelSid)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
            Identity = new List<string>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Identity != null)
            {
                p.AddRange(Identity.Select(prop => new KeyValuePair<string, string>("Identity", prop)));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// DeleteMemberOptions
    /// </summary>
    public class DeleteMemberOptions : IOptions<MemberResource>
    {
        /// <summary>
        /// The SID of the Service to delete the resource from
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the channel the Member resource to delete belongs to
        /// </summary>
        public string PathChannelSid { get; }
        /// <summary>
        /// The SID of the Member resource to delete
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The X-Twilio-Webhook-Enabled HTTP request header
        /// </summary>
        public MemberResource.WebhookEnabledTypeEnum XTwilioWebhookEnabled { get; set; }

        /// <summary>
        /// Construct a new DeleteMemberOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to delete the resource from </param>
        /// <param name="pathChannelSid"> The SID of the channel the Member resource to delete belongs to </param>
        /// <param name="pathSid"> The SID of the Member resource to delete </param>
        public DeleteMemberOptions(string pathServiceSid, string pathChannelSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
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

        /// <summary>
        /// Generate the necessary header parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetHeaderParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (XTwilioWebhookEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("X-Twilio-Webhook-Enabled", XTwilioWebhookEnabled.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// UpdateMemberOptions
    /// </summary>
    public class UpdateMemberOptions : IOptions<MemberResource>
    {
        /// <summary>
        /// The SID of the Service to create the resource under
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the channel the member to update belongs to
        /// </summary>
        public string PathChannelSid { get; }
        /// <summary>
        /// The SID of the Member resource to update
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The SID of the Role to assign to the member
        /// </summary>
        public string RoleSid { get; set; }
        /// <summary>
        /// The index of the last consumed Message for the Channel for the Member
        /// </summary>
        public int? LastConsumedMessageIndex { get; set; }
        /// <summary>
        /// The ISO 8601 based timestamp string representing the datetime of the last Message read event for the Member within the Channel
        /// </summary>
        public DateTime? LastConsumptionTimestamp { get; set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the resource was created
        /// </summary>
        public DateTime? DateCreated { get; set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the resource was updated
        /// </summary>
        public DateTime? DateUpdated { get; set; }
        /// <summary>
        /// A valid JSON string that contains application-specific data
        /// </summary>
        public string Attributes { get; set; }
        /// <summary>
        /// The X-Twilio-Webhook-Enabled HTTP request header
        /// </summary>
        public MemberResource.WebhookEnabledTypeEnum XTwilioWebhookEnabled { get; set; }

        /// <summary>
        /// Construct a new UpdateMemberOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to create the resource under </param>
        /// <param name="pathChannelSid"> The SID of the channel the member to update belongs to </param>
        /// <param name="pathSid"> The SID of the Member resource to update </param>
        public UpdateMemberOptions(string pathServiceSid, string pathChannelSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (RoleSid != null)
            {
                p.Add(new KeyValuePair<string, string>("RoleSid", RoleSid.ToString()));
            }

            if (LastConsumedMessageIndex != null)
            {
                p.Add(new KeyValuePair<string, string>("LastConsumedMessageIndex", LastConsumedMessageIndex.ToString()));
            }

            if (LastConsumptionTimestamp != null)
            {
                p.Add(new KeyValuePair<string, string>("LastConsumptionTimestamp", Serializers.DateTimeIso8601(LastConsumptionTimestamp)));
            }

            if (DateCreated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreated", Serializers.DateTimeIso8601(DateCreated)));
            }

            if (DateUpdated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateUpdated", Serializers.DateTimeIso8601(DateUpdated)));
            }

            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Attributes));
            }

            return p;
        }

        /// <summary>
        /// Generate the necessary header parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetHeaderParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (XTwilioWebhookEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("X-Twilio-Webhook-Enabled", XTwilioWebhookEnabled.ToString()));
            }

            return p;
        }
    }

}