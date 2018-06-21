/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Taskrouter.V1.Workspace.Worker 
{

    /// <summary>
    /// FetchWorkersCumulativeStatisticsOptions
    /// </summary>
    public class FetchWorkersCumulativeStatisticsOptions : IOptions<WorkersCumulativeStatisticsResource> 
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// Filter cumulative statistics by a end date.
        /// </summary>
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// Filter cumulative statistics by up to 'x' minutes in the past.
        /// </summary>
        public int? Minutes { get; set; }
        /// <summary>
        /// Filter cumulative statistics by a start date.
        /// </summary>
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// Filter cumulative statistics by TaskChannel.
        /// </summary>
        public string TaskChannel { get; set; }

        /// <summary>
        /// Construct a new FetchWorkersCumulativeStatisticsOptions
        /// </summary>
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        public FetchWorkersCumulativeStatisticsOptions(string pathWorkspaceSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (EndDate != null)
            {
                p.Add(new KeyValuePair<string, string>("EndDate", Serializers.DateTimeIso8601(EndDate)));
            }

            if (Minutes != null)
            {
                p.Add(new KeyValuePair<string, string>("Minutes", Minutes.Value.ToString()));
            }

            if (StartDate != null)
            {
                p.Add(new KeyValuePair<string, string>("StartDate", Serializers.DateTimeIso8601(StartDate)));
            }

            if (TaskChannel != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskChannel", TaskChannel));
            }

            return p;
        }
    }

}