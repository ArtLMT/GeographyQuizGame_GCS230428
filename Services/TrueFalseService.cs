using GeographyQuizGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographyQuizGame.Controller
{
    internal interface TrueFalseService
    {
        void CreateQuestion(string questionText, string correctAnswer);
        void UpdateQuestion(TrueFalseQuestion question, string questionText, string correctAnswer);
        void DeleteQuestion(TrueFalseQuestion question);
    }
}
