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
    public class ArticleServiceTest
    {
        [TestMethod]
        public void TestNoMoreThan10()
        {
            string theme = "trump";
            string begin_date = "20160901";
            string end_date = "20160902";
            var articlesService = new ArticlesService();
            Task<List<Doc>> articlesTask = articlesService.GetNewsAsync(theme,begin_date,end_date);
            var articles = articlesTask.Result;
            var quantityOfArticles = articles.Count();
            var result = (quantityOfArticles == 10);
            Assert.IsTrue(result ,"There should be maximum 10 articles");
        }
    }
}




