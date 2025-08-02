using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GeographyQuizGame.Models;
using GeographyQuizGame.Services;

namespace GeographyQuizGame.Services.Implement
{
    public class MultipleChoiceServiceImpl : MultipleChoiceService
    {
        public void CreateQuestion(string text, Dictionary<string, string> options, string correctKey)
        {
            Validate(text, options, correctKey);
            int id = QuestionManager.GetNextId();
            var question = new MultipleChoiceQuestion(id, text, options, correctKey);
            QuestionManager.AddQuestion(question);
        }

        public void UpdateQuestion(MultipleChoiceQuestion question, string text, Dictionary<string, string> options, string correctKey)
        {
            Validate(text, options, correctKey);
            question.SetQuestionText(text);
            question.Options = options;
            question.CorrectAnswerKey = correctKey;
        }

        public void DeleteQuestion(MultipleChoiceQuestion question)
        {
            QuestionManager.DeleteQuestion(question);
        }

        public bool CheckAnswer(MultipleChoiceQuestion question, string userOptionKey)
        {
            return question.IsCorrectAnswer(userOptionKey);
        }

        private void Validate(string text, Dictionary<string, string> options, string correctKey)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentException("Question text cannot be empty.");

            if (!options.ContainsKey(correctKey))
                throw new ArgumentException("Correct answer key must match an option.");

            if (options.Count < 4 || options.Values.Any(string.IsNullOrWhiteSpace))
                throw new ArgumentException("All options (A-D) must be filled out.");
        }
    }
}

