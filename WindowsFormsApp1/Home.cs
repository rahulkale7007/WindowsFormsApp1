using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void form1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.MdiParent = this;
            f1.Show();

        }

        private void form2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.MdiParent = this;
            f2.Show();

        }

        private void form3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 f3 = new Form1();
            f3.MdiParent = this;
            f3.Show();

        }

        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Student f1 = new Student();
            f1.MdiParent = this;
            f1.Show();

        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}
