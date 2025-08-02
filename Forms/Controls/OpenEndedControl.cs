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
using static System.Windows.Forms.Design.AxImporter;

namespace GeographyQuizGame.Forms.Controls
{
    public partial class OpenEndedControl : UserControl
    {
        private AddQuestionBase parentForm;
        private OpenEndedQuestion editingQuestion = null;
        private OpenEndedService service;

        public OpenEndedControl(AddQuestionBase parentForm, OpenEndedQuestion question = null)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.editingQuestion = question;
            this.service = new OpenEndedServiceImpl();

            CreateQuestionBtn.Click += CreateQuestionBtn_Click;
            DeleteBtn.Click += DeleteBtn_Click;

            if (editingQuestion != null)
            {
                textBox1.Text = editingQuestion.GetQuestionText();
                AcceptableAnswerBox.Text = editingQuestion.GetCorrectAnswerText(); // can show all instead
                CreateQuestionBtn.Text = "Update Question";
                DeleteBtn.Visible = true;
            }
        }

        private void CreateQuestionBtn_Click(object sender, EventArgs e)
        {
            string questionText = textBox1.Text;
            string acceptableAnswers = AcceptableAnswerBox.Text;

            try
            {
                if (editingQuestion != null)
                {
                    service.UpdateQuestion(editingQuestion, questionText, acceptableAnswers);
                    MessageBox.Show("Question updated!");
                }
                else
                {
                    service.CreateQuestion(questionText, acceptableAnswers);
                    MessageBox.Show("New question created!");
                }

                parentForm.RefreshQuestionList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (editingQuestion != null)
            {
                service.DeleteQuestion(editingQuestion);
                parentForm.RefreshQuestionList();
                parentForm.ReloadInputPanel();
                MessageBox.Show("Question deleted!");
            }
            else
            {
                MessageBox.Show("No question to delete.");
            }
        }
    }
}
