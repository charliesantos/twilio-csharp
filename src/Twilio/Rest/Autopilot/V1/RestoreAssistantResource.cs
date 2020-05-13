/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
///
/// RestoreAssistantResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Autopilot.V1
{

    public class RestoreAssistantResource : Resource
    {
        private static Request BuildUpdateRequest(UpdateRestoreAssistantOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Autopilot,
                "/v1/Assistants/Restore",
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update RestoreAssistant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RestoreAssistant </returns>
        public static RestoreAssistantResource Update(UpdateRestoreAssistantOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update RestoreAssistant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RestoreAssistant </returns>
        public static async System.Threading.Tasks.Task<RestoreAssistantResource> UpdateAsync(UpdateRestoreAssistantOptions options,
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
        /// <param name="assistant"> The unique string that identifies the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RestoreAssistant </returns>
        public static RestoreAssistantResource Update(string assistant, ITwilioRestClient client = null)
        {
            var options = new UpdateRestoreAssistantOptions(assistant);
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="assistant"> The unique string that identifies the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RestoreAssistant </returns>
        public static async System.Threading.Tasks.Task<RestoreAssistantResource> UpdateAsync(string assistant,
                                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateRestoreAssistantOptions(assistant);
            return await UpdateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a RestoreAssistantResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> RestoreAssistantResource object represented by the provided JSON </returns>
        public static RestoreAssistantResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<RestoreAssistantResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The SID of the Account that created the resource
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The RFC 2822 date and time in GMT when the resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The RFC 2822 date and time in GMT when the resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// An application-defined string that uniquely identifies the resource
        /// </summary>
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }
        /// <summary>
        /// The string that you assigned to describe the resource
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// Whether model needs to be rebuilt
        /// </summary>
        [JsonProperty("needs_model_build")]
        public bool? NeedsModelBuild { get; private set; }
        /// <summary>
        /// Reserved
        /// </summary>
        [JsonProperty("latest_model_build_sid")]
        public string LatestModelBuildSid { get; private set; }
        /// <summary>
        /// Whether queries should be logged and kept after training
        /// </summary>
        [JsonProperty("log_queries")]
        public bool? LogQueries { get; private set; }
        /// <summary>
        /// A string describing the state of the assistant.
        /// </summary>
        [JsonProperty("development_stage")]
        public string DevelopmentStage { get; private set; }
        /// <summary>
        /// Reserved
        /// </summary>
        [JsonProperty("callback_url")]
        public Uri CallbackUrl { get; private set; }
        /// <summary>
        /// Reserved
        /// </summary>
        [JsonProperty("callback_events")]
        public string CallbackEvents { get; private set; }

        private RestoreAssistantResource()
        {

        }
    }

}