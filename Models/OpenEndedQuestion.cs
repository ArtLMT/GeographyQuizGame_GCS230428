using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographyQuizGame.Models
{
    public class OpenEndedQuestion : Question
    {
        private String AcceptableAnswers { get; set; }

        public OpenEndedQuestion()
        {
            AcceptableAnswers = string.Empty;
        }
        public OpenEndedQuestion(String acceptableAnswer, int id, String questionText) : base(id, questionText)
        {
            AcceptableAnswers = acceptableAnswer;
        }

        public override string ToString()
        {
            return base.ToString() + " [Open Ended]";
        }

        public override bool IsCorrectAnswer(string userAnswer)
        {
            // Split the acceptable answers by semicolon and check if the answer matches any of them
            string[] answers = AcceptableAnswers.Split(';');
            foreach (string acceptableAnswer in answers)
            {
                if (string.Equals(acceptableAnswer.Trim(), userAnswer.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        public string GetCorrectAnswerText()
        {
            // Return the first acceptable answer as the correct answer text
            string[] answers = AcceptableAnswers.Split(';');
            return answers.Length > 0 ? answers[0].Trim() : string.Empty;
        }

        public void SetAcceptableAnswers(string acceptableAnswers)
        {
            this.AcceptableAnswers = acceptableAnswers;
        }
    }
}
