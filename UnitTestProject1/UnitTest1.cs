using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ejer03;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        private Class1 sut;

        [TestInitialize]
        public void TestInicial()
        {
            sut = new Class1();
            
        }

        [TestMethod]
        public void TestResta()
        {
            int res = sut.Resta(5, 2);
            Assert.AreEqual(3, res);
        }

        [TestMethod]
        public void TestRestaNegativos()
        {
            int res = sut.Resta(-5, -2);
            Assert.AreEqual(-3, res);
        }
    }
}
