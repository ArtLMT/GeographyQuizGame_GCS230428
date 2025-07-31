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

            // Hook the combo box event manually to be safe
            comboBoxQuestionType.SelectedIndexChanged += comboBoxQuestionType_SelectedIndexChanged;
            HomeBtn.Click += HomeBtn_Click;
            listBoxQuestions.DoubleClick += ListBoxQuestions_DoubleClick;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void ListBoxQuestions_DoubleClick(object sender, EventArgs e)
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

            if (question is MultipleChoiceQuestion mcq)
            {
                control = new MultipleChoiceControl(this, mcq); // Pass the question
            }
            else if (question is TrueFalseQuestion tfq)
            {
                control = new TrueFalseControl(this, tfq);
            }
            else if (question is OpenEndedQuestion oeq)
            {
                control = new OpenEndedControl(this, oeq);
            }

            if (control != null)
            {
                control.Dock = DockStyle.Fill;
                panelInputArea.Controls.Add(control);
            }
        }


    }
}
