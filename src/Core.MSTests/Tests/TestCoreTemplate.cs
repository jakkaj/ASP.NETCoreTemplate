using System;
using System.Collections.Generic;
using System.Text;
using Core.Contracts.Template;
using Core.MSTests.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.MSTests.Tests
{
    [TestClass]
    public class TestCoreTemplate : TestBase
    {
        [TestMethod]
        public void TestResolveServiceAndConfigsWorking()
        {
            var templateCoreService = Resolve<ITemplateService>();

            Assert.IsTrue(templateCoreService.DoSomething() == "Sample value");
        }
    }
}
