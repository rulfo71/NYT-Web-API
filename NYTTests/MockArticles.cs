using System;
using System.Collections.Generic;
using NYTWebApi.Models;

namespace NYTTests
{
    public class MockArticles
    {
        IEnumerable<Doc> articles = new List<Doc>();

        public IEnumerable<Doc> Mock20Articles()
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

        public IEnumerable<Doc> Mock7Articles()
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