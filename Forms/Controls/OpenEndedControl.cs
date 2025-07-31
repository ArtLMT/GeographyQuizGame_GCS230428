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
using static System.Windows.Forms.Design.AxImporter;

namespace GeographyQuizGame.Forms.Controls
{
    public partial class OpenEndedControl : UserControl
    {
        private AddQuestionBase parentForm;
        private OpenEndedQuestion editingQuestion = null;
        public OpenEndedControl(AddQuestionBase parentForm, OpenEndedQuestion question = null)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.CreateQuestionBtn.Click += new System.EventHandler(this.CreateQuestionBtn_Click);
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);

            if (question != null)
            {
                editingQuestion = question;
                textBox1.Text = question.GetQuestionText();
                AcceptableAnswerBox.Text = question.GetCorrectAnswerText(); // Or show all acceptable answers
                CreateQuestionBtn.Text = "Update Question";
                DeleteBtn.Visible = true;
            }
        }

        private void CreateQuestionBtn_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("Create Question Button Clicked");
            if (Validator.isNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Question text cannot be empty.");
                return;
            }

            if (Validator.isNullOrEmpty(AcceptableAnswerBox.Text))
            {
                MessageBox.Show("Acceptable answers cannot be empty.");
                return;
            }

            string questionText = textBox1.Text;
            string acceptableAnswers = AcceptableAnswerBox.Text;

            if (this.editingQuestion != null) // Editing an existing question
            {
                this.editingQuestion.SetQuestionText(questionText);
                this.editingQuestion.SetAcceptableAnswers(acceptableAnswers);

                MessageBox.Show("Question updated!");
            }
            else  // Creating a new question
            {
                int questionId = QuestionManager.GetNextId();
                OpenEndedQuestion question = new OpenEndedQuestion(acceptableAnswers, questionId, questionText);

                QuestionManager.AddQuestion(question);

                //MessageBox.Show("New question created!");
            }

            parentForm.RefreshQuestionList();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (editingQuestion != null)
            {
                QuestionManager.DeleteQuestion(editingQuestion);
                parentForm.RefreshQuestionList();
                MessageBox.Show("Question deleted!");
            }
            else
            {
                MessageBox.Show("No question to delete.");
            }
        }

    }
}
