using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GeographyQuizGame.Models;

namespace GeographyQuizGame.Forms
{
    public partial class PlayOpenEndedControl : UserControl
    {
        public event Action<bool> Answered;
        private OpenEndedQuestion question;
        public PlayOpenEndedControl(OpenEndedQuestion question)
        {
            InitializeComponent();
            this.question = question;
            QuestionText.Text = this.question.GetQuestionText();
            NextBtn.Click += new System.EventHandler(this.NextBtn_Click);

        }

        public void NextBtn_Click(object sender, EventArgs e)
        {
            bool isCorrect = checkAnswer(UserAnswerBtn.Text);
            Answered?.Invoke(isCorrect);
        }

        public bool checkAnswer(string userAnswer)
        {
            return this.question.IsCorrectAnswer(userAnswer);
        }
    }
}
