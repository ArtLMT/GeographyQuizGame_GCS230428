using GeographyQuizGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographyQuizGame.Services
{
    internal interface OpenEndedService
    {
        void CreateQuestion(string questionText, string acceptableAnswers);
        void UpdateQuestion(OpenEndedQuestion question, string questionText, string acceptableAnswers);
        void DeleteQuestion(OpenEndedQuestion question);
        bool CheckAnswer(OpenEndedQuestion question, string userAnswer);

    }
}
