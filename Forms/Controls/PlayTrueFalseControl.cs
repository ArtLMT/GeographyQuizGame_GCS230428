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

namespace GeographyQuizGame.Forms.Controls
{
    public partial class PlayTrueFalseControl : UserControl
    {
        TrueFalseQuestion question;
        public event Action<bool> Answered;
        public PlayTrueFalseControl(TrueFalseQuestion question)
        {
            InitializeComponent();
            this.question = question;
            QuestionText.Text = this.question.GetQuestionText();
            TrueBtn.Click += TrueButton_Click;
            FalseBtn.Click += FalseButton_Click;
        }

        private void TrueButton_Click(object sender, EventArgs e)
        {
            bool isCorrect = question.IsCorrectAnswer("True");
            Answered?.Invoke(isCorrect);
        }

        private void FalseButton_Click(object sender, EventArgs e)
        {
            bool isCorrect = question.IsCorrectAnswer("False");
            Answered?.Invoke(isCorrect);
        }


        public void ShowCorrectAnswer()
        {
            MessageBox.Show($"The correct answer is: {question.correctAnswer}");
        }

    }
}
