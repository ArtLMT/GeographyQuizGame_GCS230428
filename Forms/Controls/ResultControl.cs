using GeographyQuizGame.Models;
using GeographyQuizGame.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeographyQuizGame.Forms.Controls
{
    public partial class ResultControl : UserControl
    {
        public ResultControl(int score, int totalQuestions, TimeSpan time)
        {
            InitializeComponent();
            DisplayResult(score, totalQuestions);
            HomeBtn.Click += HomeBtn_Click;
            PlayAgainBtn.Click += PlayAgainBtn_Click;
            ShowResultBtn.Click += ShowResultBtn_Click;
            LoadAllQuestions();
            timer.Text = $"{time.Seconds} seconds";

        }

        private void ShowResultBtn_Click(object sender, EventArgs e)
        {
            listBoxQuestions.Visible = true;
        }
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            var parentForm = this.ParentForm as HomePage;

            if (parentForm != null)
            {
                var HomePage = new HomePageForm();
                parentForm.GamePanel.Controls.Clear();
                parentForm.GamePanel.Controls.Add(HomePage);
                HomePage.Dock = DockStyle.Fill;
            }
        }

        public void PlayAgainBtn_Click(object sender, EventArgs e)
        {
            var parentForm = this.ParentForm as HomePage;
            if (parentForm != null)
            {
                var playGameForm = new PlayGameForm();
                parentForm.GamePanel.Controls.Clear();
                parentForm.GamePanel.Controls.Add(playGameForm);
                playGameForm.Dock = DockStyle.Fill;
            }
        }

        public void DisplayResult(int score, int totalQuestions)
        {
            ResultLbl.Text = $"Your Score: {score} out of {totalQuestions}";
            this.Visible = true;
        }


        private void LoadAllQuestions()
        {
            listBoxQuestions.Items.Clear(); // assuming this is the name of your ListBox

            foreach (var question in QuestionManager.GetAllQuestions())
            {
                String questionText = question.GetQuestionText();
                if (question is MultipleChoiceQuestion mcq)
                {
                    String correctAnswer = mcq.GetCorrectAnswerText();
                    listBoxQuestions.Items.Add(questionText + ", correct answer: " + correctAnswer);
                }
                else if (question is TrueFalseQuestion tfq)
                {
                    String correctAnswer = tfq.correctAnswer;
                    listBoxQuestions.Items.Add(questionText + ", correct answer: " + correctAnswer);
                }
                else if (question is OpenEndedQuestion oeq)
                {
                    String correctAnswer = oeq.GetCorrectAnswerText();
                    listBoxQuestions.Items.Add(questionText + ", correct answer: " + correctAnswer);
                }
               
               
            }
        }
    }
}
