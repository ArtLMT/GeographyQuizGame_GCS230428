using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographyQuizGame.Models
{
    public class TrueFalseQuestion : Question
    {
        public string correctAnswer { get; set; }


        public TrueFalseQuestion()
        {
            
        }

        public TrueFalseQuestion(int id, string questionText, string correctAnswer) : base(id, questionText)
        {
            this.correctAnswer = correctAnswer;
        }

        public override bool IsCorrectAnswer(string userAnswer)
        {
            return string.Equals(userAnswer, correctAnswer, StringComparison.OrdinalIgnoreCase);
        }

        public override string ToString()
        {
            return base.ToString() + " [True/False]";
        }
    }
}