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
    public partial class TrueFalseControl : UserControl
    {
        private AddQuestionBase parentForm;
        private TrueFalseQuestion editingQuestion = null;
        public TrueFalseControl(AddQuestionBase parentForm, TrueFalseQuestion question = null)
        {
            InitializeComponent();
            comboBoxCorrectAnswer.SelectedItem = "True";
            this.parentForm = parentForm;

            this.CreateQuestionBtn.Click += new System.EventHandler(this.CreateQuestionBtn_Click);
            this.editingQuestion = question;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);

            if (question != null)
            {
                editingQuestion = question;
                textBox1.Text = question.GetQuestionText();
                comboBoxCorrectAnswer.SelectedItem = question.GetCorrectAnswer();
                CreateQuestionBtn.Text = "Update Question";
                DeleteBtn.Visible = true;
            }
        }

        private void CreateQuestionBtn_Click(object sender, EventArgs e)
        {
            if (editingQuestion == null)
            {
                Console.WriteLine("Create Question Button Clicked");
                string questionText = textBox1.Text;

                string correctKey = comboBoxCorrectAnswer.SelectedItem?.ToString() ?? "True";
                int questionId = QuestionManager.GetNextId();

                TrueFalseQuestion question = new TrueFalseQuestion(questionId, questionText, correctKey);

                QuestionManager.AddQuestion(question);
            }
            else
            {
                Console.WriteLine("Update Question Button Clicked");
                editingQuestion.SetQuestionText(textBox1.Text);
                editingQuestion.SetCorrectAnswer(comboBoxCorrectAnswer.SelectedItem.ToString());
                MessageBox.Show("Question updated!");
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
