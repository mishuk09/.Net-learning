using Microsoft.AspNetCore.Mvc;

namespace Store.Controllers
{
    public class QuizController : Controller
    {
        // GET: Quiz
        public IActionResult Index()
        {
            // Initially display the quiz form with a new QuizViewModel
            return View(new Models.QuizViewModel());
        }

        // POST: Quiz
        [HttpPost]
        public IActionResult Index(Models.QuizViewModel model)
        {
            // Calculate the score based on the answers provided
            model.Score = 0;

            if (model.Answer1 == "4") model.Score++;
            if (model.Answer2.ToLower() == "paris") model.Score++;

            // Use ViewBag to pass the score to the view
            ViewBag.Score = model.Score;
            // Direct the user to the Result view, passing along the model
            return View("Result", model);
        }
    }
}
