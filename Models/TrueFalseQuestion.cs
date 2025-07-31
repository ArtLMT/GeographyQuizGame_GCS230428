using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographyQuizGame.Models
{
    public class TrueFalseQuestion : Question
    {
        private String CorrectAnswer { get; set; } // "True" or "False"
        public string GetCorrectAnswer() => CorrectAnswer;
        public void SetCorrectAnswer(string answer)
        {
            if (answer != "True" && answer != "False")
            {
                throw new ArgumentException("Correct answer must be 'True' or 'False'.");
            }
            CorrectAnswer = answer;
        }

        public TrueFalseQuestion()
        {
            CorrectAnswer = string.Empty;
        }

        public TrueFalseQuestion( int id, String questionText, String correctAnswer) : base(id, questionText)
        {
            if (correctAnswer != "True" && correctAnswer != "False")
            {
                throw new ArgumentException("Correct answer must be 'True' or 'False'."); 
            }
            CorrectAnswer = correctAnswer;
        }

        public override bool IsCorrectAnswer(string userAnswer)
        {
            return string.Equals(userAnswer, CorrectAnswer, StringComparison.OrdinalIgnoreCase);
        }

        public override string ToString()
        {
            return base.ToString() + " [True False]";
        }
    }
}
