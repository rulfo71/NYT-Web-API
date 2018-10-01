using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using NYTWebApi.Services;
using System.Threading.Tasks;
using NYTWebApi.Models;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;



namespace NYTTests
{
    [TestClass]
    public class ArticleServiceTest
    {
        IConfiguration configuration = new ConfigurationMock();
        MockArticles mockArticles = new MockArticles();

        [TestMethod]
        public void TestNoMoreThan10WhenReceivingMoreShouldReturnTrue()
        {
            var articlesService = new ArticlesService(configuration);
            IEnumerable<Doc> allArticles = this.mockArticles.Mock20Articles();
            // IEnumerable<Doc> allArticles = this.ArticlesWithMoreThan10Mock();
            IEnumerable<Doc> filteredArticles = new List<Doc>();

            filteredArticles = articlesService.KeepFirstArticles(allArticles, 10);
            var quantityOfArticles = filteredArticles.Count();
            var result = (quantityOfArticles == 10);
            Assert.IsTrue(result, "There should be maximum 10 articles");
        }

        [TestMethod]
        public void TestNoMoreThan10WhenReceivingLessShouldReturnTrue()
        {
            var articlesService = new ArticlesService(configuration);
            IEnumerable<Doc> allArticles = this.mockArticles.Mock7Articles();

            // IEnumerable<Doc> allArticles = this.ArticlesWithLessThan10Mock();
            IEnumerable<Doc> filteredArticles = new List<Doc>();

            filteredArticles = articlesService.KeepFirstArticles(allArticles, 10);
            var quantityOfArticles = filteredArticles.Count();
            var result = (quantityOfArticles == 7);
            Assert.IsTrue(result, "There should be 7 articles");
        }
    }
}