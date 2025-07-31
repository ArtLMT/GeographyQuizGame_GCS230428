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

namespace GeographyQuizGame.Forms
{
    public partial class PlayGameForm : UserControl
    {
        public PlayGameForm()
        {
            InitializeComponent();
            RefreshQuestionList();
        }

        private void panelInputArea_Paint(object sender, PaintEventArgs e)
        {

        }

        public void RefreshQuestionList()
        {
            listBoxQuestions.Items.Clear();

            foreach (var question in QuestionManager.GetAllQuestions())
            {
                listBoxQuestions.Items.Add(question.ToString());
            }
        }
    }
}
