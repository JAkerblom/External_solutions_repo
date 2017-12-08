using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace ClassLibrary1
{
    [TestClass]
    public class Class1
    {
        [TestMethod]
        public void hej()
        {
            Assert.NotNull("hj");
        }

    }
}
