/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NUnit.Framework;
using System;
using Twilio.Converters;
using Twilio.TwiML.Voice;

namespace Twilio.Tests.TwiML 
{

    [TestFixture]
    public class HangupTest : TwilioTest 
    {
        [Test]
        public void TestEmptyElement()
        {
            var elem = new Hangup();

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Hangup></Hangup>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithExtraAttributes()
        {
            var elem = new Hangup();
            elem.SetOption("newParam1", "value");
            elem.SetOption("newParam2", 1);

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Hangup newParam1=\"value\" newParam2=\"1\"></Hangup>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithTextNode()
        {
            var elem = new Hangup();

            elem.AddText("Here is the content");

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Hangup>Here is the content</Hangup>",
                elem.ToString()
            );
        }

        [Test]
        public void TestAllowGenericChildNodes()
        {
            var elem = new Hangup();
            elem.AddChild("generic-tag").AddText("Content").SetOption("tag", true);

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Hangup>" + Environment.NewLine +
                "  <generic-tag tag=\"True\">Content</generic-tag>" + Environment.NewLine +
                "</Hangup>",
                elem.ToString()
            );
        }
    }

}