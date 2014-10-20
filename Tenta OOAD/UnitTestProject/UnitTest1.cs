using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TentaOOADClassLibrary;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethodPolisen()
        {
            TopCrimeSystem system=new TopCrimeSystem();
            Polisen polisen=new Polisen(system);
            Assert.IsNotNull(polisen.ReadTopCrime());
        }

        [TestMethod]
        public void TestMethodUtryckning()
        {
            TopCrimeSystem system = new TopCrimeSystem();
            Utryckning utryckning= new Utryckning(system);
            Assert.IsNotNull(utryckning.ReadTopCrime());
        }
    }
}
