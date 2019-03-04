using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterControllerTest
    {
        [TestMethod]
        public void Index()
        {
            WordCounterController controller = new WordCounterController();
            ActionResult indexView = controller.Index();
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }

        [TestMethod]
        public void New()
        {
            WordCounterController controller = new WordCounterController();
            ActionResult indexView = controller.New();
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }

        [TestMethod]
        public void Create()
        {
            WordCounterController controller = new WordCounterController();
            IActionResult view = controller.Create("i", "i i ii");
            Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
        }

        [TestMethod]
        public void Create2()
        {
            WordCounterController controller = new WordCounterController();
            RedirectToActionResult actionResult = controller.Create("i", "i i ii") as RedirectToActionResult;
            string result = actionResult.ActionName;
            Assert.AreEqual(result, "Index");
        }
    }
}
