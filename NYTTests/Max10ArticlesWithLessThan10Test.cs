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
    public class Max10ArticlesWithLessThan10Test
    {
        IConfiguration configuration = new ConfigurationMock();

        [TestMethod]
        public void TestNoMoreThan10WhenReceivingLessShouldReturnTrue()
        {
            var articlesService = new ArticlesService(configuration);

            IEnumerable<Doc> allArticles = this.ArticlesWithLessThan10Mock();
            IEnumerable<Doc> filteredArticles = new List<Doc>();

            filteredArticles = articlesService.KeepFirstArticles(allArticles, 10);
            var quantityOfArticles = filteredArticles.Count();
            var result = (quantityOfArticles == 7);
            Assert.IsTrue(result, "There should be 7 articles");
        }
        private IEnumerable<Doc> ArticlesWithLessThan10Mock()
        {
            List<Doc> allArticles = new List<Doc>();
            //headline
            var kicker = "kicker";
            var content_kicker = "content_kicker";
            var print_headline = "print_headline";
            object name = new Object();
            object seo = new Object();
            object sub = new Object();

            var web_url = "weburl";
            var snippet = "snippet";
            var main = "main";
            var headline = new Headline(kicker, content_kicker, print_headline, name, seo, sub);
            var pub_date = new DateTime(2016 - 09 - 02);
            var score = 2.5;

            var doc1 = new Doc(web_url, snippet, headline, pub_date, score);
            var doc2 = new Doc(web_url, snippet, headline, pub_date, score);
            var doc3 = new Doc(web_url, snippet, headline, pub_date, score);
            var doc4 = new Doc(web_url, snippet, headline, pub_date, score);
            var doc5 = new Doc(web_url, snippet, headline, pub_date, score);
            var doc6 = new Doc(web_url, snippet, headline, pub_date, score);
            var doc7 = new Doc(web_url, snippet, headline, pub_date, score);

            allArticles.Add(doc1);
            allArticles.Add(doc2);
            allArticles.Add(doc3);
            allArticles.Add(doc4);
            allArticles.Add(doc5);
            allArticles.Add(doc6);
            allArticles.Add(doc7);

            return allArticles;
        }
    }
}




