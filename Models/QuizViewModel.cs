namespace Store.Models
{
    public class QuizViewModel
    {
        public string Question1 { get; set; }
        public string Answer1 { get; set; }

        public string Question2 { get; set; }
        public string Answer2 { get; set; }

        // Optionally, you could have a collection of questions/answers if dynamic.

        public int Score { get; set; } // You can calculate this based on correct answers.
    }
}
