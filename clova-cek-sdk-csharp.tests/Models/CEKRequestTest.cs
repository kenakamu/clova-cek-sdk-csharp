using CEK.CSharp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CEK.CSharp.Tests.Models
{
    public class CEKRequestTest
    {
        [Fact]
        public void TypeSafeReadSessionAttributeTest()
        {
            var target = new CEKRequest
            {
                Session = new Session
                {
                    SessionAttributes = new Dictionary<string, object>
                    {
                        ["A"] = "a value",
                        ["B"] = "b value",
                    },
                },
            };

            var typeSafeSession = target.GetSessionAttributeAs<SessionType>();
            Assert.Equal("a value", typeSafeSession.A);
            Assert.Equal("b value", typeSafeSession.B);
        }

        [Fact]
        public void TypeSafeReadSessionAttributeNullCaseTest()
        {
            var target = new CEKRequest();
            Assert.Null(target.GetSessionAttributeAs<SessionType>());
        }

        class SessionType
        {
            public string A { get; set; }
            public string B { get; set; }
        }
    }
}
