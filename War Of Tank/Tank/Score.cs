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
    public partial class FormScore : Form
    {
        public FormScore()
        {
            InitializeComponent();
        }

        private void FormScore_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'diemDataSet1.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter1.Fill(this.diemDataSet1.Table);
            
            

        }
        
    }
}
