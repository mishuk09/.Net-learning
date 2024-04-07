using Microsoft.AspNetCore.Mvc;
using Store.Data;
using Store.Models;
using System.Diagnostics;

namespace Store.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _logger;

        public HomeController(ApplicationDbContext logger)
        {
                this._logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Courses()
        {
            return View();
        }

        public IActionResult Quiz()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Submit(Quiz quiz)
        {
            if (ModelState.IsValid)
            {
                int score = quiz.CalculateScore();
                return RedirectToAction("Result", new { Score = score });
            }
            // If model state is not valid, return back to the quiz view
            return View("Quiz", quiz);
        }

        public IActionResult Database()
        {
            IEnumerable<Abcd> abc = _logger.BookStoreUsers;
            return View(abc);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var user = await _logger.BookStoreUsers.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            _logger.BookStoreUsers.Remove(user);
            await _logger.SaveChangesAsync();
            return RedirectToAction("Database");
        }
        public IActionResult Result(int Score)
        {
            ViewBag.Score = Score;

            // Define questions
            ViewBag.Question1 = "What does 'HTML' stand for?";
            ViewBag.Question2 = "What programming language is often used for developing Android applications?";
            ViewBag.Question3 = "Which company developed the C# programming language?";
            ViewBag.Question4 = "What does 'SEO' stand for in the context of websites?";
            ViewBag.Question5 = "Which protocol is used for secure communication over a computer network?";
            ViewBag.Question6 = "What is the purpose of a 'CSS' file in web development?";
            ViewBag.Question7 = "Which programming language is commonly used for data analysis and machine learning?";
            ViewBag.Question8 = "What does 'API' stand for in the context of software development?";
            ViewBag.Question9 = "Which technology is used for creating dynamic and interactive web pages?";
            ViewBag.Question10 = "What is the primary function of a 'DNS' server in computer networking?";
            // Add similar lines for other questions

            // Define correct answers
            ViewBag.CorrectAnswer1 = "Hypertext Markup Language";
            ViewBag.CorrectAnswer2 = "Java";
            ViewBag.CorrectAnswer3 = "Microsoft";
            ViewBag.CorrectAnswer4 = "Search Engine Optimization";
            ViewBag.CorrectAnswer5 = "HTTPS";
            ViewBag.CorrectAnswer6 = "Styling web pages";
            ViewBag.CorrectAnswer7 = "Python";
            ViewBag.CorrectAnswer8 = "Application Programming Interface";
            ViewBag.CorrectAnswer9 = "JavaScript";
            ViewBag.CorrectAnswer10 = "Translate domain names to IP addresses";
            // Add similar lines for other correct answers

            return View();
        }

    }
}
