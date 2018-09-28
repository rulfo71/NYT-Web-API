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

        [TestMethod]
        public void TestNoMoreThan10()
        {



            var articlesService = new ArticlesService(configuration);
            IEnumerable<Doc> articlesAll = this.articlesMock()



            Task<List<Doc>> articlesTask = articlesService.GetNewsAsync(theme, begin_date, end_date);
            var articles = articlesTask.Result;
            var quantityOfArticles = articles.Count();
            var result = (quantityOfArticles == 10);
            Assert.IsTrue(result, "There should be maximum 10 articles");
        }

        private IEnumerable<Doc> articlesMock()
        {

            IEnumerable<Doc> allArticles = this.createDocs();
        }

        private bool createDocs()
        {
            IEnumerable<Doc> allArticles;
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
            var pub_date = new DateTime(2016-09-02);
            var score = 2.5;

            var doc = new Doc(web_url,snippet,headline,pub_date,score);

            for (var i = 1; i < 20; i++)
            {

            }
        }


        public string web_url { get; set; }
        public string snippet { get; set; }
        public Headline headline { get; set; }
        public DateTime pub_date { get; set; }
        public double score { get; set; }



        public class Headline
        {
            public string content_kicker { get; set; }
            public string print_headline { get; set; }
            public object name { get; set; }
            public object seo { get; set; }
            public object sub { get; set; }
        }
    }
}




