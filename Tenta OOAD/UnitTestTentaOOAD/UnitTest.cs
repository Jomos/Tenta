using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TentaOOADClassLibrary;

namespace UnitTestTentaOOAD
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestHeadlinePolisen()
        {
            //Assign
            Scraping scraping = new Scraping();


            string headline = scraping.ScreenScraping(@"http://polisen.se/", @"/html/body/form/div[3]/div[7]/div[2]/div[2]/div/div[1]/div/ul/li[1]/p[1]/a");
            //Assert
            Assert.IsNotNull(headline);
        }
        

        //[TestMethod]
        //public void TestHeadlineUtryckning.se()
        //{
        //    //Assign
           
        //    //Act
        //    string headline =
        //        //Assert
        //    Assert.IsNotNull(headline);
        //}
    }
}
