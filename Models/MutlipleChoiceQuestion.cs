using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographyQuizGame.Models
{
    public class MultipleChoiceQuestion : Question
    {
        public Dictionary<string, string> Options { get; private set; }
        public string CorrectAnswerKey { get; private set; }

        public void SetOptions(Dictionary<string, string> options)
        {
            this.Options = options;
        }

        public Dictionary<string, string> GetOptions()
        {
            return Options;
        }

        public void SetCorrectAnswerKey(string correctAnswerKey)
        {
            this.CorrectAnswerKey = correctAnswerKey;
        }

        public string GetCorrectAnswerKey()
        {
            return CorrectAnswerKey;
        }

        public MultipleChoiceQuestion()
        {
            Options = new Dictionary<string, string>();
            CorrectAnswerKey = string.Empty;
        }

        public MultipleChoiceQuestion(Dictionary<string, string> options, int id, string questionText, string correctAnswerKey)
            : base(id, questionText)
        {
            this.Options = options;
            this.CorrectAnswerKey = correctAnswerKey;
        }

        public override bool IsCorrectAnswer(string answerKey)
        {
            return string.Equals(answerKey, CorrectAnswerKey, StringComparison.OrdinalIgnoreCase);
        }

        public string GetCorrectAnswerText()
        {
            return Options.ContainsKey(CorrectAnswerKey) ? Options[CorrectAnswerKey] : string.Empty;
        }

        public override string ToString()
        {
            return base.ToString() + " [Multiple Choice]";
        }
    }

}
