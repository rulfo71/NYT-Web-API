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
    [TestClass]
    public class NullOrEmptyParametersTest
    {
        IConfiguration configuration = new ConfigurationMock();
        ExceptionsList listOfExceptions = new ExceptionsList();

        [TestMethod]
        public void TestEmptyParametersShouldReturnTrue()
        {
            var theme = String.Empty;
            var begin_date = String.Empty;
            var end_date = String.Empty;

            var queryValidator = new QueryValidator();
            listOfExceptions = queryValidator.ValidateData(theme, begin_date, end_date);

            Assert.IsTrue(listOfExceptions.HasEmptyDataException(),"Should have an empty data exception");
        }
    }
}