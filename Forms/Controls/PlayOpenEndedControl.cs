using GeographyQuizGame.Models;
using GeographyQuizGame.Services;
using GeographyQuizGame.Services.Implement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeographyQuizGame.Forms
{
    public partial class PlayOpenEndedControl : UserControl
    {
        public event Action<bool> Answered;
        private OpenEndedQuestion question;
        private OpenEndedService service;

        public PlayOpenEndedControl(OpenEndedQuestion question)
        {
            InitializeComponent();
            this.question = question;
            this.service = new OpenEndedServiceImpl();

            QuestionText.Text = this.question.GetQuestionText();
            NextBtn.Click += NextBtn_Click;
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            string userAnswer = UserAnswerBtn.Text;
            bool isCorrect = service.CheckAnswer(question, userAnswer);
            Answered?.Invoke(isCorrect);
        }
    }
}
