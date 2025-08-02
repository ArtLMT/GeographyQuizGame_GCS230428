using GeographyQuizGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographyQuizGame.Services.Implement
{
    internal class OpenEndedServiceImpl : OpenEndedService
    {
        public void CreateQuestion(string questionText, string acceptableAnswers)
        {
            Validate(questionText, acceptableAnswers);
            int id = QuestionManager.GetNextId();
            var question = new OpenEndedQuestion(acceptableAnswers, id, questionText);
            QuestionManager.AddQuestion(question);
        }

        public void UpdateQuestion(OpenEndedQuestion question, string questionText, string acceptableAnswers)
        {
            if (question == null)
                throw new ArgumentNullException(nameof(question));

            Validate(questionText, acceptableAnswers);

            question.SetQuestionText(questionText);
            question.SetAcceptableAnswers(acceptableAnswers);
        }

        public void DeleteQuestion(OpenEndedQuestion question)
        {
            if (question == null)
                throw new ArgumentNullException(nameof(question));

            QuestionManager.DeleteQuestion(question);
        }

        public bool CheckAnswer(OpenEndedQuestion question, string userAnswer)
        {
            if (question == null)
                throw new ArgumentNullException(nameof(question));

            return question.IsCorrectAnswer(userAnswer);
        }


        private void Validate(string questionText, string acceptableAnswers)
        {
            if (string.IsNullOrWhiteSpace(questionText))
                throw new ArgumentException("Question text cannot be empty.");

            if (string.IsNullOrWhiteSpace(acceptableAnswers))
                throw new ArgumentException("Acceptable answers cannot be empty.");
        }
    }
}
