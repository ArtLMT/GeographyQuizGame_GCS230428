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
    public partial class HomePageForm : UserControl
    {
        public HomePageForm()
        {
            InitializeComponent();

            this.CreateGame.Click += new System.EventHandler(this.CreateGame_Click);

        }

        private void CreateGame_Click(object sender, EventArgs e)
        {
            // Ask parent (HomePage) to switch screen
            var parentForm = this.ParentForm as HomePage;

            if (parentForm != null)
            {
                var addQuestionPage = new AddQuestionBase();
                parentForm.GamePanel.Controls.Clear();
                parentForm.GamePanel.Controls.Add(addQuestionPage);
                addQuestionPage.Dock = DockStyle.Fill;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Play_Click(object sender, EventArgs e)
        {
            var parentForm = this.ParentForm as HomePage;

            if (parentForm != null)
            {
                var playGamePage = new PlayGameForm();
                parentForm.GamePanel.Controls.Clear();
                parentForm.GamePanel.Controls.Add(playGamePage);
                playGamePage.Dock = DockStyle.Fill;
            }
        }
    }
}
