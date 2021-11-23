using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_2_CVP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Context_Menu (String nameMenu)
        {
            MessageBox.Show(this, "You push on " + nameMenu, "Message");
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Context_Menu("add");
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Context_Menu("search");
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Context_Menu("delete");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timer1.Interval = 50;
            this.progressBar1.Increment(1);
        }
    }
}
