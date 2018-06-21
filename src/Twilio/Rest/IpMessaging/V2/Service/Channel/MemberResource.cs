/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// MemberResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.IpMessaging.V2.Service.Channel 
{

    public class MemberResource : Resource 
    {
        private static Request BuildFetchRequest(FetchMemberOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.IpMessaging,
                "/v2/Services/" + options.PathServiceSid + "/Channels/" + options.PathChannelSid + "/Members/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Member parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Member </returns> 
        public static MemberResource Fetch(FetchMemberOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Member parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Member </returns> 
        public static async System.Threading.Tasks.Task<MemberResource> FetchAsync(FetchMemberOptions options, 
                                                                                   ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathChannelSid"> The channel_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Member </returns> 
        public static MemberResource Fetch(string pathServiceSid, 
                                           string pathChannelSid, 
                                           string pathSid, 
                                           ITwilioRestClient client = null)
        {
            var options = new FetchMemberOptions(pathServiceSid, pathChannelSid, pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathChannelSid"> The channel_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Member </returns> 
        public static async System.Threading.Tasks.Task<MemberResource> FetchAsync(string pathServiceSid, 
                                                                                   string pathChannelSid, 
                                                                                   string pathSid, 
                                                                                   ITwilioRestClient client = null)
        {
            var options = new FetchMemberOptions(pathServiceSid, pathChannelSid, pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildCreateRequest(CreateMemberOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.IpMessaging,
                "/v2/Services/" + options.PathServiceSid + "/Channels/" + options.PathChannelSid + "/Members",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Member parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Member </returns> 
        public static MemberResource Create(CreateMemberOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Member parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Member </returns> 
        public static async System.Threading.Tasks.Task<MemberResource> CreateAsync(CreateMemberOptions options, 
                                                                                    ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// create
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathChannelSid"> The channel_sid </param>
        /// <param name="identity"> A unique string identifier for this User in this Service. See the access tokens docs for
        ///                more details. </param>
        /// <param name="roleSid"> The role to be assigned to this member. Defaults to the roles specified on the Service.
        ///               </param>
        /// <param name="lastConsumedMessageIndex"> Field used to specify the last consumed Message index for the Channel for
        ///                                this Member.  Should only be used when recreating a Member from a backup/separate
        ///                                source. </param>
        /// <param name="lastConsumptionTimestamp"> ISO8601 time indicating the last datetime the Member consumed a Message in
        ///                                the Channel.  Should only be used when recreating a Member from a backup/separate
        ///                                source </param>
        /// <param name="dateCreated"> The ISO8601 time specifying the datetime the Members should be set as being created. 
        ///                   Will be set to the current time by the Chat service if not specified.  Note that this should only
        ///                   be used in cases where a Member is being recreated from a backup/separate source </param>
        /// <param name="dateUpdated"> The ISO8601 time specifying the datetime the Member should be set as having been last
        ///                   updated.  Will be set to the null by the Chat service if not specified.  Note that this should
        ///                   only be used in cases where a Member is being recreated from a backup/separate source  and where a
        ///                   Member was previously updated. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Member </returns> 
        public static MemberResource Create(string pathServiceSid, 
                                            string pathChannelSid, 
                                            string identity, 
                                            string roleSid = null, 
                                            int? lastConsumedMessageIndex = null, 
                                            DateTime? lastConsumptionTimestamp = null, 
                                            DateTime? dateCreated = null, 
                                            DateTime? dateUpdated = null, 
                                            ITwilioRestClient client = null)
        {
            var options = new CreateMemberOptions(pathServiceSid, pathChannelSid, identity){RoleSid = roleSid, LastConsumedMessageIndex = lastConsumedMessageIndex, LastConsumptionTimestamp = lastConsumptionTimestamp, DateCreated = dateCreated, DateUpdated = dateUpdated};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathChannelSid"> The channel_sid </param>
        /// <param name="identity"> A unique string identifier for this User in this Service. See the access tokens docs for
        ///                more details. </param>
        /// <param name="roleSid"> The role to be assigned to this member. Defaults to the roles specified on the Service.
        ///               </param>
        /// <param name="lastConsumedMessageIndex"> Field used to specify the last consumed Message index for the Channel for
        ///                                this Member.  Should only be used when recreating a Member from a backup/separate
        ///                                source. </param>
        /// <param name="lastConsumptionTimestamp"> ISO8601 time indicating the last datetime the Member consumed a Message in
        ///                                the Channel.  Should only be used when recreating a Member from a backup/separate
        ///                                source </param>
        /// <param name="dateCreated"> The ISO8601 time specifying the datetime the Members should be set as being created. 
        ///                   Will be set to the current time by the Chat service if not specified.  Note that this should only
        ///                   be used in cases where a Member is being recreated from a backup/separate source </param>
        /// <param name="dateUpdated"> The ISO8601 time specifying the datetime the Member should be set as having been last
        ///                   updated.  Will be set to the null by the Chat service if not specified.  Note that this should
        ///                   only be used in cases where a Member is being recreated from a backup/separate source  and where a
        ///                   Member was previously updated. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Member </returns> 
        public static async System.Threading.Tasks.Task<MemberResource> CreateAsync(string pathServiceSid, 
                                                                                    string pathChannelSid, 
                                                                                    string identity, 
                                                                                    string roleSid = null, 
                                                                                    int? lastConsumedMessageIndex = null, 
                                                                                    DateTime? lastConsumptionTimestamp = null, 
                                                                                    DateTime? dateCreated = null, 
                                                                                    DateTime? dateUpdated = null, 
                                                                                    ITwilioRestClient client = null)
        {
            var options = new CreateMemberOptions(pathServiceSid, pathChannelSid, identity){RoleSid = roleSid, LastConsumedMessageIndex = lastConsumedMessageIndex, LastConsumptionTimestamp = lastConsumptionTimestamp, DateCreated = dateCreated, DateUpdated = dateUpdated};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadMemberOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.IpMessaging,
                "/v2/Services/" + options.PathServiceSid + "/Channels/" + options.PathChannelSid + "/Members",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Member parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Member </returns> 
        public static ResourceSet<MemberResource> Read(ReadMemberOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<MemberResource>.FromJson("members", response.Content);
            return new ResourceSet<MemberResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Member parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Member </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<MemberResource>> ReadAsync(ReadMemberOptions options, 
                                                                                               ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<MemberResource>.FromJson("members", response.Content);
            return new ResourceSet<MemberResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathChannelSid"> The channel_sid </param>
        /// <param name="identity"> A unique string identifier for this User in this Service. See the access tokens docs for
        ///                more details. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Member </returns> 
        public static ResourceSet<MemberResource> Read(string pathServiceSid, 
                                                       string pathChannelSid, 
                                                       List<string> identity = null, 
                                                       int? pageSize = null, 
                                                       long? limit = null, 
                                                       ITwilioRestClient client = null)
        {
            var options = new ReadMemberOptions(pathServiceSid, pathChannelSid){Identity = identity, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathChannelSid"> The channel_sid </param>
        /// <param name="identity"> A unique string identifier for this User in this Service. See the access tokens docs for
        ///                more details. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Member </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<MemberResource>> ReadAsync(string pathServiceSid, 
                                                                                               string pathChannelSid, 
                                                                                               List<string> identity = null, 
                                                                                               int? pageSize = null, 
                                                                                               long? limit = null, 
                                                                                               ITwilioRestClient client = null)
        {
            var options = new ReadMemberOptions(pathServiceSid, pathChannelSid){Identity = identity, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<MemberResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<MemberResource>.FromJson("members", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<MemberResource> NextPage(Page<MemberResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.IpMessaging,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<MemberResource>.FromJson("members", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<MemberResource> PreviousPage(Page<MemberResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.IpMessaging,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<MemberResource>.FromJson("members", response.Content);
        }

        private static Request BuildDeleteRequest(DeleteMemberOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.IpMessaging,
                "/v2/Services/" + options.PathServiceSid + "/Channels/" + options.PathChannelSid + "/Members/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete Member parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Member </returns> 
        public static bool Delete(DeleteMemberOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete Member parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Member </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteMemberOptions options, 
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathChannelSid"> The channel_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Member </returns> 
        public static bool Delete(string pathServiceSid, 
                                  string pathChannelSid, 
                                  string pathSid, 
                                  ITwilioRestClient client = null)
        {
            var options = new DeleteMemberOptions(pathServiceSid, pathChannelSid, pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathChannelSid"> The channel_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Member </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathServiceSid, 
                                                                          string pathChannelSid, 
                                                                          string pathSid, 
                                                                          ITwilioRestClient client = null)
        {
            var options = new DeleteMemberOptions(pathServiceSid, pathChannelSid, pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateMemberOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.IpMessaging,
                "/v2/Services/" + options.PathServiceSid + "/Channels/" + options.PathChannelSid + "/Members/" + options.PathSid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update Member parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Member </returns> 
        public static MemberResource Update(UpdateMemberOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update Member parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Member </returns> 
        public static async System.Threading.Tasks.Task<MemberResource> UpdateAsync(UpdateMemberOptions options, 
                                                                                    ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathChannelSid"> The channel_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="roleSid"> The role to be assigned to this member. </param>
        /// <param name="lastConsumedMessageIndex"> Field used to specify the last consumed Message index for the Channel for
        ///                                this Member. </param>
        /// <param name="lastConsumptionTimestamp"> ISO8601 time indicating the last datetime the Member consumed a Message in
        ///                                the Channel. </param>
        /// <param name="dateCreated"> The ISO8601 time specifying the datetime the Members should be set as being created.
        ///                   </param>
        /// <param name="dateUpdated"> The ISO8601 time specifying the datetime the Member should be set as having been last
        ///                   updated. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Member </returns> 
        public static MemberResource Update(string pathServiceSid, 
                                            string pathChannelSid, 
                                            string pathSid, 
                                            string roleSid = null, 
                                            int? lastConsumedMessageIndex = null, 
                                            DateTime? lastConsumptionTimestamp = null, 
                                            DateTime? dateCreated = null, 
                                            DateTime? dateUpdated = null, 
                                            ITwilioRestClient client = null)
        {
            var options = new UpdateMemberOptions(pathServiceSid, pathChannelSid, pathSid){RoleSid = roleSid, LastConsumedMessageIndex = lastConsumedMessageIndex, LastConsumptionTimestamp = lastConsumptionTimestamp, DateCreated = dateCreated, DateUpdated = dateUpdated};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathChannelSid"> The channel_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="roleSid"> The role to be assigned to this member. </param>
        /// <param name="lastConsumedMessageIndex"> Field used to specify the last consumed Message index for the Channel for
        ///                                this Member. </param>
        /// <param name="lastConsumptionTimestamp"> ISO8601 time indicating the last datetime the Member consumed a Message in
        ///                                the Channel. </param>
        /// <param name="dateCreated"> The ISO8601 time specifying the datetime the Members should be set as being created.
        ///                   </param>
        /// <param name="dateUpdated"> The ISO8601 time specifying the datetime the Member should be set as having been last
        ///                   updated. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Member </returns> 
        public static async System.Threading.Tasks.Task<MemberResource> UpdateAsync(string pathServiceSid, 
                                                                                    string pathChannelSid, 
                                                                                    string pathSid, 
                                                                                    string roleSid = null, 
                                                                                    int? lastConsumedMessageIndex = null, 
                                                                                    DateTime? lastConsumptionTimestamp = null, 
                                                                                    DateTime? dateCreated = null, 
                                                                                    DateTime? dateUpdated = null, 
                                                                                    ITwilioRestClient client = null)
        {
            var options = new UpdateMemberOptions(pathServiceSid, pathChannelSid, pathSid){RoleSid = roleSid, LastConsumedMessageIndex = lastConsumedMessageIndex, LastConsumptionTimestamp = lastConsumptionTimestamp, DateCreated = dateCreated, DateUpdated = dateUpdated};
            return await UpdateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a MemberResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> MemberResource object represented by the provided JSON </returns> 
        public static MemberResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<MemberResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// A 34 character string that uniquely identifies this resource.
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The unique id of the Account responsible for this member.
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The unique id of the Channel for this member.
        /// </summary>
        [JsonProperty("channel_sid")]
        public string ChannelSid { get; private set; }
        /// <summary>
        /// The unique id of the Service this member belongs to.
        /// </summary>
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }
        /// <summary>
        /// A unique string identifier for this User in this Service.
        /// </summary>
        [JsonProperty("identity")]
        public string Identity { get; private set; }
        /// <summary>
        /// The date that this resource was created.
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date that this resource was last updated.
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The Role assigned to this member.
        /// </summary>
        [JsonProperty("role_sid")]
        public string RoleSid { get; private set; }
        /// <summary>
        /// An Integer representing index of the last Message this Member has read within this Channel
        /// </summary>
        [JsonProperty("last_consumed_message_index")]
        public int? LastConsumedMessageIndex { get; private set; }
        /// <summary>
        /// An ISO8601 based timestamp string representing the datetime of the last Message read event for this Member within this Channel
        /// </summary>
        [JsonProperty("last_consumption_timestamp")]
        public DateTime? LastConsumptionTimestamp { get; private set; }
        /// <summary>
        /// An absolute URL for this member.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private MemberResource()
        {

        }
    }

}