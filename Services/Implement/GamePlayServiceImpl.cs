using GeographyQuizGame.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace GeographyQuizGame.Services
{
    public class GamePlayServiceImpl : GamePlayService
    {
        private readonly List<Question> questions;
        private int currentIndex = 0;
        private int score = 0;
        private bool hasAnswered = false;
        private Stopwatch stopwatch;

        public GamePlayServiceImpl()
        {
            questions = QuestionManager.GetAllQuestions();
            stopwatch = new Stopwatch();
            stopwatch.Start();
        }

        public Question GetCurrentQuestion()
        {
            if (currentIndex < questions.Count)
                return questions[currentIndex];
            return null;
        }

        public bool CanContinue => currentIndex < questions.Count;
        public int TotalQuestions => questions.Count;
        public int Score => score;
        public TimeSpan Elapsed => stopwatch.Elapsed;

        public bool SubmitAnswer(bool isCorrect)
        {
            if (hasAnswered) return false;

            hasAnswered = true;
            if (isCorrect)
                score++;

            return true;
        }

        public void NextQuestion()
        {
            currentIndex++;
            hasAnswered = false;
        }
    }
}
