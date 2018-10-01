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
    public class Max10ArticlesWithMoreThan10Test
    {
        IConfiguration configuration = new ConfigurationMock();

        [TestMethod]
        public void TestNoMoreThan10WhenReceivingMoreShouldReturnTrue()
        {
            var articlesService = new ArticlesService(configuration);

            IEnumerable<Doc> allArticles = this.ArticlesWithMoreThan10Mock();
            IEnumerable<Doc> filteredArticles = new List<Doc>();

            filteredArticles = articlesService.KeepFirstArticles(allArticles, 10);
            var quantityOfArticles = filteredArticles.Count();
            var result = (quantityOfArticles == 10);
            Assert.IsTrue(result, "There should be maximum 10 articles");
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
        private IEnumerable<Doc> ArticlesWithMoreThan10Mock()
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
            var doc8 = new Doc(web_url, snippet, headline, pub_date, score);
            var doc9 = new Doc(web_url, snippet, headline, pub_date, score);
            var doc10 = new Doc(web_url, snippet, headline, pub_date, score);
            var doc11 = new Doc(web_url, snippet, headline, pub_date, score);
            var doc12 = new Doc(web_url, snippet, headline, pub_date, score);
            var doc13 = new Doc(web_url, snippet, headline, pub_date, score);
            var doc14 = new Doc(web_url, snippet, headline, pub_date, score);
            var doc15 = new Doc(web_url, snippet, headline, pub_date, score);

            allArticles.Add(doc1);
            allArticles.Add(doc2);
            allArticles.Add(doc3);
            allArticles.Add(doc4);
            allArticles.Add(doc5);
            allArticles.Add(doc6);
            allArticles.Add(doc7);
            allArticles.Add(doc8);
            allArticles.Add(doc9);
            allArticles.Add(doc10);
            allArticles.Add(doc11);
            allArticles.Add(doc12);
            allArticles.Add(doc13);
            allArticles.Add(doc14);
            allArticles.Add(doc15);

            return allArticles;

        }
    }
}




