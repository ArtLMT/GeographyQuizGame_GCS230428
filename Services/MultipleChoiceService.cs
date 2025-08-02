using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GeographyQuizGame.Models;     

namespace GeographyQuizGame.Services
{
    public interface MultipleChoiceService
    {
        void CreateQuestion(string text, Dictionary<string, string> options, string correctKey);
        void UpdateQuestion(MultipleChoiceQuestion question, string text, Dictionary<string, string> options, string correctKey);
        void DeleteQuestion(MultipleChoiceQuestion question);
        bool CheckAnswer(MultipleChoiceQuestion question, string userOptionKey);
    }
}

