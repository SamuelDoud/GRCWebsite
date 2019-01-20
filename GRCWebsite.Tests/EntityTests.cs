using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GRCWebsite.Models;
using System.Linq;

namespace GRCWebsite.Tests.Controllers
{
    /// <summary>
    /// Testing the functions of GRCDBEntities
    /// </summary>
    [TestClass]
    public class EntityTests
    {
        public EntityTests()
        {
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        /// <summary>
        /// Tests whether a user can register or not
        /// </summary>
        [TestMethod]
        public void TestCanRegister()
        {
            using (var context = new GRCDBEntities())
            {
                Assert.IsTrue(context.CanRegister("testPass@test.com").Single().Value);
                Assert.IsFalse(context.CanRegister("testWillFail@test.com").Single().Value);
            }
        }

        [TestMethod]
        public void TestGetPerson()
        {
            using (var context = new GRCDBEntities())
            {
                Person person = context.GetPerson(1).Single();
            }
        }
    }
}
