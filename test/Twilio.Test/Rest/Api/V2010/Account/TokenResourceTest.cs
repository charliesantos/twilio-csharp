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
using Twilio.Rest.Api.V2010.Account;

namespace Twilio.Tests.Rest.Api.V2010.Account
{

    [TestFixture]
    public class TokenTest : TwilioTest
    {
        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Api,
                "/2010-04-01/Accounts/ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Tokens.json",
                ""
            );
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                TokenResource.Create(client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestCreateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"username\": \"dc2d2894d5a9023620c467b0e71cfa6a35457e6679785ed6ae9856fe5bdfa269\",\"ice_servers\": [{\"url\": \"stun:global.stun.twilio.com:3478?transport=udp\",\"urls\": \"stun:global.stun.twilio.com:3478?transport=udp\"},{\"username\": \"dc2d2894d5a9023620c467b0e71cfa6a35457e6679785ed6ae9856fe5bdfa269\",\"credential\": \"tE2DajzSJwnsSbc123\",\"url\": \"turn:global.turn.twilio.com:3478?transport=udp\",\"urls\": \"turn:global.turn.twilio.com:3478?transport=udp\"},{\"username\": \"dc2d2894d5a9023620c467b0e71cfa6a35457e6679785ed6ae9856fe5bdfa269\",\"credential\": \"tE2DajzSJwnsSbc123\",\"url\": \"turn:global.turn.twilio.com:3478?transport=tcp\",\"urls\": \"turn:global.turn.twilio.com:3478?transport=tcp\"},{\"username\": \"dc2d2894d5a9023620c467b0e71cfa6a35457e6679785ed6ae9856fe5bdfa269\",\"credential\": \"tE2DajzSJwnsSbc123\",\"url\": \"turn:global.turn.twilio.com:443?transport=tcp\",\"urls\": \"turn:global.turn.twilio.com:443?transport=tcp\"}],\"date_updated\": \"Fri, 01 May 2020 01:42:57 +0000\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"ttl\": \"86400\",\"date_created\": \"Fri, 01 May 2020 01:42:57 +0000\",\"password\": \"tE2DajzSJwnsSbc123\"}"
                                     ));

            var response = TokenResource.Create(client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}