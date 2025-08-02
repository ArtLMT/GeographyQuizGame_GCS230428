using System;
using System.Collections.Generic;

namespace GeographyQuizGame.Models
{
    public class MultipleChoiceQuestion : Question
    {
        public Dictionary<string, string> Options { get; set; }
        public string CorrectAnswerKey { get; set; }

        public MultipleChoiceQuestion()
        {
            Options = new Dictionary<string, string>();
            CorrectAnswerKey = string.Empty;
        }

        public MultipleChoiceQuestion(int id, string questionText, Dictionary<string, string> options, string correctAnswerKey)
            : base(id, questionText)
        {
            Options = options;
            CorrectAnswerKey = correctAnswerKey;
        }

        public override bool IsCorrectAnswer(string userAnswerKey)
        {
            return string.Equals(userAnswerKey, CorrectAnswerKey, StringComparison.OrdinalIgnoreCase);
        }

        public string GetCorrectAnswerText()
        {
            return Options.TryGetValue(CorrectAnswerKey, out var text) ? text : string.Empty;
        }

        public override string ToString()
        {
            return base.ToString() + " [Multiple Choice]";
        }
    }
}
