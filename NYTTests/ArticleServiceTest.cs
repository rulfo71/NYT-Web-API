using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using NYTWebApi.Services;
using System.Threading.Tasks;
using NYTWebApi.Models;


namespace NYTTests
{
    [TestClass]
    public class ArticleServiceTest
    {
        [TestMethod]
        public void TestNoMoreThan10()
        {
            string theme = "trump";
            string begin_date = "20160901";
            string end_date = "20160902";
            Task<RootObj> rootObjTask = ArticlesService.getjsonAsync(theme,begin_date,end_date);
            var rootObj = rootObjTask.Result;
            var quantityOfArticles = rootObj.response.docs.Count();
            var result = (quantityOfArticles == 10);
            Assert.IsTrue(result ,"There should be maximum 10 articles");
        }

    }
}




