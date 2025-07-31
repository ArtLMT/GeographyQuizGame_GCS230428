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
    public partial class HomePage : Form
    {

        public HomePage()
        {
            InitializeComponent();
            var control = new HomePageForm();
            //var control = new AddQuestionBase();

            GamePanel.Controls.Clear();
            GamePanel.Controls.Add(control);
        }

        private void GamePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
