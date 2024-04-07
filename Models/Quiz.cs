using Microsoft.AspNetCore.Mvc;

namespace Store.Models
{
    public class Quiz
    {
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public string Answer5 { get; set; }
        public string Answer6 { get; set; }
        public string Answer7 { get; set; }
        public string Answer8 { get; set; }
        public string Answer9 { get; set; }
        public string Answer10 { get; set; }

        public int CalculateScore()
        {
            int score = 0;

            // Correct answers
            string correctAnswer1 = "Hypertext Markup Language";
            string correctAnswer2 = "Java";
            string correctAnswer3 = "Microsoft";
            string correctAnswer4 = "Search Engine Optimization";
            string correctAnswer5 = "HTTPS";
            string correctAnswer6 = "Styling web pages";
            string correctAnswer7 = "Python";
            string correctAnswer8 = "Application Programming Interface";
            string correctAnswer9 = "JavaScript";
            string correctAnswer10 = "Translate domain names to IP addresses";

            // Check answers
            if (Answer1.Equals(correctAnswer1, StringComparison.OrdinalIgnoreCase))
                score++;
            if (Answer2.Equals(correctAnswer2, StringComparison.OrdinalIgnoreCase))
                score++;
            if (Answer3.Equals(correctAnswer3, StringComparison.OrdinalIgnoreCase))
                score++;
            if (Answer4.Equals(correctAnswer4, StringComparison.OrdinalIgnoreCase))
                score++;
            if (Answer5.Equals(correctAnswer5, StringComparison.OrdinalIgnoreCase))
                score++;
            if (Answer6.Equals(correctAnswer6, StringComparison.OrdinalIgnoreCase))
                score++;
            if (Answer7.Equals(correctAnswer7, StringComparison.OrdinalIgnoreCase))
                score++;
            if (Answer8.Equals(correctAnswer8, StringComparison.OrdinalIgnoreCase))
                score++;
            if (Answer9.Equals(correctAnswer9, StringComparison.OrdinalIgnoreCase))
                score++;
            if (Answer10.Equals(correctAnswer10, StringComparison.OrdinalIgnoreCase))
                score++;

            return score;
        }

       

    }
}
