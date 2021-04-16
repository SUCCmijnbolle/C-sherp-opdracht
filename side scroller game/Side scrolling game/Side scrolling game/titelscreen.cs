using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace side_scrolling_game
{
    public partial class titelscreen : Form
    {
        public titelscreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            level1 l1 = new level1();
            l1.ShowDialog();
            Application.Exit();
        }
    }
}
