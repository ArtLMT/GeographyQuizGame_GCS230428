using GeographyQuizGame.Controller;
using GeographyQuizGame.Models;
using GeographyQuizGame.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographyQuizGame.Services.Implement
{
    public class TrueFalseServiceImpl : TrueFalseService
    {
        public void CreateQuestion(string questionText, string correctAnswer)
        {
            ValidateQuestionText(questionText);

            if (correctAnswer != "True" && correctAnswer != "False")
            {
                throw new ArgumentException("Correct answer must be 'True' or 'False'.");
            }

            int questionId = QuestionManager.GetNextId();
            TrueFalseQuestion question = new TrueFalseQuestion(questionId, questionText, correctAnswer);
            QuestionManager.AddQuestion(question);
        }

        public void UpdateQuestion(TrueFalseQuestion question, string questionText, string correctAnswer)
        {
            if (question == null)
                throw new ArgumentNullException(nameof(question));

            ValidateQuestionText(questionText);

            question.SetQuestionText(questionText);
            question.correctAnswer = correctAnswer;
        }

        public void DeleteQuestion(TrueFalseQuestion question)
        {
            if (question == null)
                throw new ArgumentNullException(nameof(question));

            QuestionManager.DeleteQuestion(question);
        }

        private void ValidateQuestionText(string questionText)
        {
            if (string.IsNullOrWhiteSpace(questionText))
            {
                throw new ArgumentException("Question text cannot be empty.");
            }
        }
    }
}
