using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographyQuizGame.Models
{
    public abstract class Question
    {
        private int id {get; set; }
        private string QuestionText {get; set; }
        public string GetQuestionText() => QuestionText;
        public void SetQuestionText(string questionText) => QuestionText = questionText;
        public int GetId() => id;
        public void SetId(int id) => this.id = id;

        public Question()
        {

        }

        public Question(int id, string questionText)
        {
            this.id = id;
            this.QuestionText = questionText;
        }

        public abstract bool IsCorrectAnswer(string answer);

        public override string ToString()
        {
            return "id: " + id + " " + QuestionText;
        }
    }
}
