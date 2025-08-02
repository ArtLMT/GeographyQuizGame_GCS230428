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

using System.Diagnostics;

using GeographyQuizGame.Models;
using GeographyQuizGame.Forms.Controls;

namespace GeographyQuizGame.Forms
{
    public partial class PlayGameForm : UserControl
    {
        private List<Question> questionList;
        private int currentQuestionIndex = 0;
        private int userScore = 0;
        private bool hasAnswered = false;
        private Stopwatch watch;
        private GamePlayServiceImpl game;



        public PlayGameForm()
        {
            InitializeComponent();
            RefreshQuestionList();
            game = new GamePlayServiceImpl();
            ShowNextQuestion();

            this.HomeBtn.Click += HomeBtn_Click;
        }

        private void panelInputArea_Paint(object sender, PaintEventArgs e)
        {

        }

        public void RefreshQuestionList()
        {
            listBoxQuestions.Items.Clear();

            foreach (var question in QuestionManager.GetAllQuestions())
            {
                listBoxQuestions.Items.Add(question.ToString());
            }
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

        private void play()
        {
            questionList = QuestionManager.GetAllQuestions();
            currentQuestionIndex = 0;

            this.watch = new Stopwatch();
            this.watch.Start();
            ShowNextQuestion();
        }

        //private void DisplayQuestion(Question question)
        //{
        //    panelInputArea.Controls.Clear();

        //    if (question is MultipleChoiceQuestion mcq)
        //    {
        //        var mcqControl = new PlayMutlipleChoiceControl(mcq);
        //        mcqControl.Answered += OnUserAnswered;
        //        panelInputArea.Controls.Add(mcqControl);
        //        mcqControl.Dock = DockStyle.Fill;
        //    }
        //    else if (question is TrueFalseQuestion tfq)
        //    {
        //        var tfqControl = new PlayTrueFalseControl(tfq);
        //        tfqControl.Answered += OnUserAnswered;
        //        panelInputArea.Controls.Add(tfqControl);
        //        tfqControl.Dock = DockStyle.Fill;
        //    }
        //    else if (question is OpenEndedQuestion oeq)
        //    {
        //        var oeqControl = new PlayOpenEndedControl(oeq);
        //        oeqControl.Answered += OnUserAnswered;
        //        panelInputArea.Controls.Add(oeqControl);
        //        oeqControl.Dock = DockStyle.Fill;
        //    }
        //}

        private void ShowNextQuestion()
        {
            panelInputArea.Controls.Clear();

            if (!game.CanContinue)
            {
                EndGame();
                return;
            }

            var question = game.GetCurrentQuestion();
            hasAnswered = false;

            if (question is MultipleChoiceQuestion mcq)
            {
                var mcqControl = new PlayMutlipleChoiceControl(mcq);
                mcqControl.Answered += OnUserAnswered;
                panelInputArea.Controls.Add(mcqControl);
                mcqControl.Dock = DockStyle.Fill;
            }
            else if (question is TrueFalseQuestion tfq)
            {
                var tfqControl = new PlayTrueFalseControl(tfq);
                tfqControl.Answered += OnUserAnswered;
                panelInputArea.Controls.Add(tfqControl);
                tfqControl.Dock = DockStyle.Fill;
            }
            else if (question is OpenEndedQuestion oeq)
            {
                var oeqControl = new PlayOpenEndedControl(oeq);
                oeqControl.Answered += OnUserAnswered;
                panelInputArea.Controls.Add(oeqControl);
                oeqControl.Dock = DockStyle.Fill;
            }
        }


        private void OnUserAnswered(bool isCorrect)
        {
            if (!game.SubmitAnswer(isCorrect)) return;

            game.NextQuestion();
            ShowNextQuestion();
        }

        private void EndGame()
        {
            var parentForm = this.ParentForm as HomePage;
            if (parentForm != null)
            {
                var resultPage = new ResultControl(game.Score, game.TotalQuestions, game.Elapsed);
                parentForm.GamePanel.Controls.Clear();
                parentForm.GamePanel.Controls.Add(resultPage);
                resultPage.Dock = DockStyle.Fill;
            }
        }


    }
}
