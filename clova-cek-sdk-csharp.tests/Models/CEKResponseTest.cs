using CEK.CSharp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CEK.CSharp.Tests.Models
{
    public class CEKResponseTest
    {
        [Fact]
        public void TypeSafeSessionAttributeSetTest()
        {
            var sessionValue = new OrderInfo
            {
                MenuName = "Pizza",
                OrderCount = 10,
            };
            var response = new CEKResponse();
            response.SetSessionAttributesFrom(sessionValue);
            Assert.Equal("Pizza", (string)response.SessionAttributes["MenuName"]);
            Assert.Equal(10, (long)response.SessionAttributes["OrderCount"]);
        }

        [Fact]
        public void TypeSafeSessionAttributeSetNullTest()
        {
            var response = new CEKResponse();
            response.AddSession("dummy", "dummy");
            response.SetSessionAttributesFrom(null);
            Assert.Empty(response.SessionAttributes);
        }
    }

    public class OrderInfo
    {
        public string MenuName { get; set; }
        public long OrderCount { get; set; }
    }
}
