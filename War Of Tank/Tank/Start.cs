using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tank
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            FormGame game = new FormGame();
            game.Show();
            Hide();
        }

        private void btnHighScore_Click(object sender, EventArgs e)
        {
            FormScore score = new FormScore();
            score.ShowDialog();
        }
    }
}
