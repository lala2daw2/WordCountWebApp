using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;
using WordCountWebApp.Models;
using WordCountWebApp.Tests;

namespace WordCountWebApp.Controllers
{
    public class WordController : Controller
    {
        // GET: Word
        public ActionResult List()
        {
            List<WordModel> words = new List<WordModel>();
            Cache cache = new Cache();
            DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath("~/XML/mobydickword.xml"));
            var wordList = (from rows in ds.Tables[0].AsEnumerable()
                            select new WordModel
                            {
                                count = Convert.ToInt32(rows[0].ToString()),
                                text = rows[1].ToString()
                            }).OrderByDescending(x => x.count).Take(10).ToList();
            

            if (cache["Data"] == null)
            {
                cache.Insert("Data", wordList);
            }
            return View(cache["Data"]);

        }
        public void GetWordList()
        {
          
        }
      
    }
}