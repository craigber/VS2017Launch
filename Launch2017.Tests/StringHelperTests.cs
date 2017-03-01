using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Launch2017;

namespace Launch2017.Tests
{
    [TestClass]
    public class StringHelperTests
    {
        [TestMethod]
        [DataRow("skies", "sky")]
        [DataRow("horses", "horse")]
        [DataRow("poseys", "posey")]
        public void DepluralizeReturnsSingluar(string testValue, string expected)
        {
            StringHelpers helpers = new StringHelpers();
            string result = helpers.Depluralize(testValue);
            Assert.AreEqual(expected, result); 
        }

        [TestMethod]
        public void DepluralizeDoesNotModifyNonPlural()
        {
            StringHelpers helpers = new StringHelpers();
            string result = helpers.Depluralize("puppy");
            Assert.AreEqual("puppy", result); 
        }
    }
}
