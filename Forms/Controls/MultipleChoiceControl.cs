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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GeographyQuizGame.Forms.Controls
{
    public partial class MultipleChoiceControl : UserControl
    {
        private AddQuestionBase parentForm;
        private MultipleChoiceQuestion editingQuestion = null;
        private MultipleChoiceService service;
        public MultipleChoiceControl(AddQuestionBase parentForm, MultipleChoiceQuestion question = null)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.service = new MultipleChoiceServiceImpl();
            this.editingQuestion = question;
            
            comboBoxCorrectAnswer.SelectedItem = "A";

            this.CreateMultiQuestionBtn.Click += CreateMultiQuestionBtn_Click;
            this.DeleteBtn.Click += DeleteBtn_Click;

            comboBoxCorrectAnswer.Items.Clear();
            comboBoxCorrectAnswer.Items.AddRange(new object[] { "A", "B", "C", "D" });
            comboBoxCorrectAnswer.SelectedIndex = 0;

            if (question != null)
            {
                textBox1.Text = question.QuestionText;
                OptionA.Text = question.Options.GetValueOrDefault("A", "");
                OptionB.Text = question.Options.GetValueOrDefault("B", "");
                OptionC.Text = question.Options.GetValueOrDefault("C", "");
                OptionD.Text = question.Options.GetValueOrDefault("D", "");
                comboBoxCorrectAnswer.SelectedItem = question.CorrectAnswerKey;

                CreateMultiQuestionBtn.Text = "Update Question";
                DeleteBtn.Visible = true;
            }
        }

        private void CreateMultiQuestionBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string questionText = textBox1.Text;
                Dictionary<string, string> options = new Dictionary<string, string>
            {
                { "A", OptionA.Text },
                { "B", OptionB.Text },
                { "C", OptionC.Text },
                { "D", OptionD.Text }
            };
                string correctKey = comboBoxCorrectAnswer.SelectedItem?.ToString() ?? "A";

                if (editingQuestion != null)
                {
                    service.UpdateQuestion(editingQuestion, questionText, options, correctKey);
                    MessageBox.Show("Question updated!");
                }
                else
                {
                    service.CreateQuestion(questionText, options, correctKey);
                    MessageBox.Show("New question added!");
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
                MessageBox.Show("Question deleted!");
            }
            else
            {
                MessageBox.Show("No question to delete.");
            }
        }
    }
}
