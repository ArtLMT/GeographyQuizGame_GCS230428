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
            //this.TrueButton.Click += TrueButton_Click;
            //this.FalseButton.Click += FalseButton_Click;
            this.TrueBtn.Click += new System.EventHandler(this.TrueButton_Click);
            this.FalseBtn.Click += new System.EventHandler(this.FalseButton_Click);
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
            // Show the correct answer to the user
            MessageBox.Show($"The correct answer is: {question.GetCorrectAnswer()}");
        }

    }
}
