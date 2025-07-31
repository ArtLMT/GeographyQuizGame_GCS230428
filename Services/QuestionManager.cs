using GeographyQuizGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographyQuizGame.Services
{
    public class QuestionManager
    {
        private static int currentId = 1;
        public static List<Question> CreatedQuestions = new List<Question>();

        public static void AddQuestion(Question question)
        {
            CreatedQuestions.Add(question);
        }

        public static List<Question> GetAllQuestions()
        {
            //if (CreatedQuestions.Count == 0)
            //{
            //    throw new InvalidOperationException("No questions have been created yet.");
            //}
            return CreatedQuestions;
        }

        public static int GetNextId()
        {
            return currentId++;
        }

        public static void DeleteQuestion(Question questionToDelete)
        {
            if (CreatedQuestions.Contains(questionToDelete))
            {
                CreatedQuestions.Remove(questionToDelete);

                // Optional: Reassign question IDs to keep them in order
                currentId = 1;
                foreach (var question in CreatedQuestions)
                {
                    question.SetId(currentId++);
                }
            }
        }
    }
}
