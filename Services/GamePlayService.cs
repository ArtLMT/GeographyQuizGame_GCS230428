using GeographyQuizGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographyQuizGame.Services
{
    internal interface GamePlayService
    {
        Question GetCurrentQuestion();
        bool SubmitAnswer(bool isCorrect);
        void NextQuestion();
    }
}
