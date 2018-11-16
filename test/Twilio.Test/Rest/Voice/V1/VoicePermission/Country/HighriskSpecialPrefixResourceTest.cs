/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Voice.V1.VoicePermission.Country;

namespace Twilio.Tests.Rest.Voice.V1.VoicePermission.Country 
{

    [TestFixture]
    public class HighriskSpecialPrefixTest : TwilioTest 
    {
        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Voice,
                "/v1/DialingPermissions/Countries/US/HighRiskSpecialPrefixes",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                HighriskSpecialPrefixResource.Read("US", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestReadUsResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"content\": [{\"prefix\": \"+37181\"},{\"prefix\": \"+3719000\"}],\"meta\": {\"first_page_url\": \"https://voice.twilio.com/v1/DialingPermissions/Countries/LV/HighRiskSpecialPrefixes?PageSize=50&Page=0\",\"key\": \"content\",\"next_page_url\": null,\"page\": 0,\"page_size\": 50,\"previous_page_url\": null,\"url\": \"https://voice.twilio.com/v1/DialingPermissions/Countries/LV/HighRiskSpecialPrefixes?PageSize=50&Page=0\"}}"
                                     ));

            var response = HighriskSpecialPrefixResource.Read("US", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}