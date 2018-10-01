
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using NYTWebApi.Services;
using System.Threading.Tasks;
using NYTWebApi.Models;
using System.Collections.Generic;

namespace NYTTests
{
    public class QueryValidatorTest
    {
        IConfiguration configuration = new ConfigurationMock();
        ExceptionsList listOfExceptions = new ExceptionsList();
        [TestMethod]
        public void TestEndDateSoonerThanBeginDateShouldReturnTrue()
        {
            var theme = "pruebaDates";
            var begin_date = "20180907";
            var end_date = "20180903";

            var queryValidator = new QueryValidator();
            listOfExceptions = queryValidator.ValidateData(theme, begin_date, end_date);

            Assert.IsTrue(listOfExceptions.HasWrongDatesException(), "Should have a WrongDatesException");
        }

        [TestMethod]
        public void TestEmptyParametersShouldReturnTrue()
        {
            var theme = String.Empty;
            var begin_date = String.Empty;
            var end_date = String.Empty;

            var queryValidator = new QueryValidator();
            listOfExceptions = queryValidator.ValidateData(theme, begin_date, end_date);

            Assert.IsTrue(listOfExceptions.HasEmptyDataException(), "Should have an empty data exception");
        }
    }
}