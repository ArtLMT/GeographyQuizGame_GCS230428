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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GeographyQuizGame.Forms.Controls
{
    public partial class MultipleChoiceControl : UserControl
    {
        private AddQuestionBase parentForm;
        private MultipleChoiceQuestion editingQuestion = null;
        public MultipleChoiceControl(AddQuestionBase parentForm, MultipleChoiceQuestion question = null)
        {
            InitializeComponent();
            comboBoxCorrectAnswer.SelectedItem = "A";


            this.CreateMultiQuestionBtn.Click += new System.EventHandler(this.CreateMultiQuestionBtn_Click);
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);

            this.parentForm = parentForm;

            if (question != null)
            {
                editingQuestion = question;
                textBox1.Text = question.GetQuestionText();
                foreach (var option in question.GetOptions())
                {
                    OptionA.Text= option.Key == "A" ? option.Value : OptionA.Text;
                    OptionB.Text= option.Key == "B" ? option.Value : OptionB.Text;
                    OptionC.Text= option.Key == "C" ? option.Value : OptionC.Text;
                    OptionD.Text= option.Key == "D" ? option.Value : OptionD.Text;
                }
                comboBoxCorrectAnswer.SelectedItem = question.GetCorrectAnswerKey();
                CreateMultiQuestionBtn.Text = "Update Question";
                DeleteBtn.Visible = true;
            }
        }

        private void CreateMultiQuestionBtn_Click(object sender, EventArgs e)
        {
            if (editingQuestion != null)
            {
                //Console.WriteLine("Update Question Button Clicked");
                editingQuestion.SetQuestionText(textBox1.Text);
                editingQuestion.SetOptions(new Dictionary<string, string>
                {
                    { "A", OptionA.Text },
                    { "B", OptionB.Text },
                    { "C", OptionC.Text },
                    { "D", OptionD.Text }
                });

            } else
            {

                //Console.WriteLine("Create Question Button Clicked");
                string questionText = textBox1.Text;
                var options = new Dictionary<string, string>
                {
                    { "A", OptionA.Text },
                    { "B", OptionB.Text },
                    { "C", OptionC.Text },
                    { "D", OptionD.Text }
                };

                int questionId = QuestionManager.GetNextId();

                string correctKey = comboBoxCorrectAnswer.SelectedItem?.ToString() ?? "A";

                var question = new MultipleChoiceQuestion(options, questionId, questionText, correctKey);

                QuestionManager.AddQuestion(question);
            }

                parentForm.RefreshQuestionList();

            //MessageBox.Show(
            //    $"Question: {questionText}\n" +
            //    $"A: {options["A"]}\nB: {options["B"]}\nC: {options["C"]}\nD: {options["D"]}\n" +
            //    $"Correct Answer: {correctKey} ({question.GetCorrectAnswerText()})");
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
