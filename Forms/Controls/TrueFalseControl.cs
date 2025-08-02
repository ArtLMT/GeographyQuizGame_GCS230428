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

using GeographyQuizGame.Services.Implement;

namespace GeographyQuizGame.Forms.Controls
{
    public partial class TrueFalseControl : UserControl
    {
        private AddQuestionBase parentForm;
        private TrueFalseQuestion editingQuestion;
        private TrueFalseServiceImpl service;

        public TrueFalseControl(AddQuestionBase parentForm, TrueFalseQuestion question = null)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.editingQuestion = question;
            this.service = new TrueFalseServiceImpl();

            comboBoxCorrectAnswer.Items.Clear();
            comboBoxCorrectAnswer.Items.Add("True");
            comboBoxCorrectAnswer.Items.Add("False");
            comboBoxCorrectAnswer.SelectedIndex = 0;

            CreateQuestionBtn.Click += CreateQuestionBtn_Click;
            DeleteBtn.Click += DeleteBtn_Click;

            if (question != null)
            {
                QuestionTextInput.Text = editingQuestion.GetQuestionText();
                comboBoxCorrectAnswer.SelectedItem = editingQuestion.correctAnswer;
                CreateQuestionBtn.Text = "Update Question";
                DeleteBtn.Visible = true;
            }
        }

        private void CreateQuestionBtn_Click(object sender, EventArgs e)
        {
            string questionText = QuestionTextInput.Text;
            string correctAnswer = comboBoxCorrectAnswer.SelectedItem?.ToString() ?? "True";
            MessageBox.Show($"SelectedItem: {comboBoxCorrectAnswer.SelectedItem}");
            try
            {
                if (editingQuestion == null)
                {
                    service.CreateQuestion(questionText, correctAnswer);
                }
                else
                {
                    service.UpdateQuestion(editingQuestion, questionText, correctAnswer);
                    MessageBox.Show("Question updated!");
                }

                parentForm.RefreshQuestionList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
