﻿using System;
using NUnit.Framework;

namespace ReqnrollXnunit.Tests.Classic
{
    [TestFixture, Category("Tests2")]
    public class Tests2
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

        public class Monkies
        {
            [Test]
            public void Test3()
            {
                Assert.True(true);
            }
            
            [Test]
            public void Test4()
            {
                Assert.True(true);
            }
        }
    }
}