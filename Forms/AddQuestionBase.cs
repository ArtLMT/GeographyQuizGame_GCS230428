using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeographyQuizGame.Forms.Controls;
using GeographyQuizGame.Models;
using GeographyQuizGame.Services;


namespace GeographyQuizGame.Forms
{
    public partial class AddQuestionBase : UserControl
    {
        public AddQuestionBase()
        {
            InitializeComponent();
            RefreshQuestionList();

            // Hook the combo box event manually to be safe
            comboBoxQuestionType.SelectedIndexChanged += comboBoxQuestionType_SelectedIndexChanged;
            HomeBtn.Click += HomeBtn_Click;
            listBoxQuestions.Click += ListBoxQuestions_Click;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddQuestionBase_Load(object sender, EventArgs e)
        {
            comboBoxQuestionType.Items.Clear();
            comboBoxQuestionType.Items.Add("Multiple Choice");
            comboBoxQuestionType.Items.Add("True/False");
            comboBoxQuestionType.Items.Add("Open-ended");
            comboBoxQuestionType.SelectedItem = "Multiple Choice";
        }

        private void comboBoxQuestionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelInputArea.Controls.Clear();

            string selectedType = comboBoxQuestionType.SelectedItem.ToString();

            UserControl selectedControl = null;

            if (selectedType == "Multiple Choice")
            {
                selectedControl = new MultipleChoiceControl(this);
            }
            else if (selectedType == "True/False")
            {
                selectedControl = new TrueFalseControl(this);
            }
            else if (selectedType == "Open-ended")
            {
                selectedControl = new OpenEndedControl(this);
            }

            if (selectedControl != null)
            {
                selectedControl.Dock = DockStyle.Fill;
                panelInputArea.Controls.Add(selectedControl);
            }
        }

        public void RefreshQuestionList()
        {
            listBoxQuestions.Items.Clear();

            foreach (var question in QuestionManager.GetAllQuestions())
            {
                listBoxQuestions.Items.Add(question);
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

        private void ListBoxQuestions_Click(object sender, EventArgs e)
        {
            if (listBoxQuestions.SelectedItem is Question selectedQuestion)
            {
                LoadEditorForQuestion(selectedQuestion);
            }
        }

        private void LoadEditorForQuestion(Question question)
        {
            panelInputArea.Controls.Clear();
            UserControl control = null;

            if (question is MultipleChoiceQuestion multipleChoiceQuestion)
            {
                control = new MultipleChoiceControl(this, multipleChoiceQuestion);
            }
            else if (question is TrueFalseQuestion trueFalseQuestion)
            {
                control = new TrueFalseControl(this, trueFalseQuestion);
            }
            else if (question is OpenEndedQuestion openEndedQuestion)
            {
                control = new OpenEndedControl(this, openEndedQuestion);
            }

            if (control != null)
            {
                control.Dock = DockStyle.Fill;
                panelInputArea.Controls.Add(control);
            }
        }

        private void listBoxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void ReloadInputPanel()
        {
            string selectedType = comboBoxQuestionType.SelectedItem.ToString();

            panelInputArea.Controls.Clear();

            UserControl selectedControl = null;

            if (selectedType == "Multiple Choice")
            {
                selectedControl = new MultipleChoiceControl(this);
            }
            else if (selectedType == "True/False")
            {
                selectedControl = new TrueFalseControl(this);
            }
            else if (selectedType == "Open-ended")
            {
                selectedControl = new OpenEndedControl(this);
            }

            if (selectedControl != null)
            {
                selectedControl.Dock = DockStyle.Fill;
                panelInputArea.Controls.Add(selectedControl);
            }
        }

    }
}
