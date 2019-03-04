using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    [HttpGet("/wordcounter")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/wordcounter")]
    public ActionResult Create(string userWord, string userSentence)
    {
      int result = 0;
      RepeatCounter counter = new RepeatCounter(userWord, userSentence, result);
      counter.Searcher(userWord, userSentence, result);
      return RedirectToAction("Index", counter);
    }

    [HttpGet("/wordcounter/new")]
    public ActionResult New()
    {
      return View();
    }
  }
}
