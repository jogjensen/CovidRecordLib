using Microsoft.VisualStudio.TestTools.UnitTesting;
using CovidRecordLib;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace CovidRecordLib.Tests
{
    [TestClass()]
    public class CovidRecordTests
    {

        private CovidRecord covidRecord = new CovidRecord(1, "Nykøbing SJ", 4, 4, 2);

        //CONSTRUCTOR TEST
        [TestMethod()]
        public void CovidRecordTest()
        {
        CovidRecord covidRecord = new CovidRecord(1, "Nykøbing SJ", 4, 4, 2);

        Assert.AreEqual(1,covidRecord.Id);
        Assert.AreEqual("Nykøbing SJ",covidRecord.City);
        Assert.AreEqual(4,covidRecord.Household);
        Assert.AreEqual(4,covidRecord.Tested);
        Assert.AreEqual(2,covidRecord.Sick);
        }

        //City must be atleast 2 chars
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCityAtleast2Chars()
        {
            covidRecord.City = "a";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestHouseHoldAtleast1Char()
        {
            covidRecord.Household = 0;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestTestedAtleast0()
        {
            covidRecord.Tested = -1;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSickAtleast0()
        {
            covidRecord.Sick = -1;
        }

        [TestMethod]
        public void TestId()
        {
            covidRecord.Id = 1;
        }

        [TestMethod]
        public void TestEmptyConstructor()
        {
            covidRecord = new CovidRecord();
        }
    }
}