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

namespace GeographyQuizGame.Forms.Controls
{
    public partial class PlayMutlipleChoiceControl : UserControl
    {
        public event Action<bool> Answered;
        private MultipleChoiceQuestion question;
        private MultipleChoiceService service = new MultipleChoiceServiceImpl();
        private bool hasClicked = false;


        public PlayMutlipleChoiceControl(MultipleChoiceQuestion question)
        {
            InitializeComponent();
            this.OptionA.Click += OptionA_Click;
            this.OptionB.Click += OptionB_Click;
            this.OptionC.Click += OptionC_Click;
            this.OptionD.Click += OptionD_Click;
            this.question = question;
            QuestionText.Text = this.question.QuestionText;
            setOptions();

        }

        private void OptionA_Click(object sender, EventArgs e)
        {
            if (hasClicked) return;
            hasClicked = true;

            bool isCorrect = service.CheckAnswer(question, "A");
            Answered?.Invoke(isCorrect);

            DisableAllButtons();
        }

        private void OptionB_Click(object sender, EventArgs e)
        {
            if (hasClicked) return;
            hasClicked = true;

            bool isCorrect = service.CheckAnswer(question, "B");
            Answered?.Invoke(isCorrect);

            DisableAllButtons();
        }

        private void OptionC_Click(object sender, EventArgs e)
        {
            if (hasClicked) return; 
            hasClicked = true;

            bool isCorrect = service.CheckAnswer(question, "C");
            Answered?.Invoke(isCorrect);

            DisableAllButtons();
        }

        private void OptionD_Click(object sender, EventArgs e)
        {
            if (hasClicked) return; 
            hasClicked = true;

            bool isCorrect = service.CheckAnswer(question, "D");
            Answered?.Invoke(isCorrect);

            DisableAllButtons();
        }

        private void setOptions()
        {
            Dictionary<string, string> options = this.question.Options;
            if (options.ContainsKey("A")) OptionA.Text = options["A"];
            if (options.ContainsKey("B")) OptionB.Text = options["B"];
            if (options.ContainsKey("C")) OptionC.Text = options["C"];
            if (options.ContainsKey("D")) OptionD.Text = options["D"];

        }

        private void DisableAllButtons()
        {
            OptionA.Enabled = false;
            OptionB.Enabled = false;
            OptionC.Enabled = false;
            OptionD.Enabled = false;
        }

    }
}
