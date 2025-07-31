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
    public partial class PlayMutlipleChoiceControl : UserControl
    {
        public event Action<bool> Answered;
        private MultipleChoiceQuestion question;
        public PlayMutlipleChoiceControl(MultipleChoiceQuestion question)
        {
            InitializeComponent();
            this.question = question;
            QuestionText.Text = this.question.GetQuestionText();
            setOptions();

        }

        private void OptionA_Click(object sender, EventArgs e)
        {
            bool isCorrect = question.IsCorrectAnswer("A");
            Answered?.Invoke(isCorrect);
        }

        private void OptionB_Click(object sender, EventArgs e)
        {
            bool isCorrect = question.IsCorrectAnswer("B");
            Answered?.Invoke(isCorrect);
        }

        private void OptionC_Click(object sender, EventArgs e)
        {
            bool isCorrect = question.IsCorrectAnswer("C");
            Answered?.Invoke(isCorrect);
        }

        private void OptionD_Click(object sender, EventArgs e)
        {
            bool isCorrect = question.IsCorrectAnswer("D");
            Answered?.Invoke(isCorrect);
        }

        private void ShowCorrectAnswer()
        {
            //// Show the correct answer to the user
            //MessageBox.Show($"The correct answer is: {question.GetCorrectAnswer()}");
        }

        private void setOptions()
        {
            Dictionary<String, String> options = this.question.GetOptions();
            if (options.ContainsKey("A")) OptionA.Text = options["A"];
            if (options.ContainsKey("B")) OptionB.Text = options["B"];
            if (options.ContainsKey("C")) OptionC.Text = options["C"];
            if (options.ContainsKey("D")) OptionD.Text = options["D"];

        }

    }
}
