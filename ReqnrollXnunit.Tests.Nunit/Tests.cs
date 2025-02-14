using System;
using NUnit.Framework;

namespace ReqnrollXnunit.Tests.Classic
{
    [TestFixture, Category("Tests1")]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.True(true);
        }
        
        [Test]
        public void Test2()
        {
            Assert.True(true);
        }
    }
}