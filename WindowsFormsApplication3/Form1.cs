using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMad_Click(object sender, EventArgs e)
        {
            lblClick.text = "";
        }

        private void btnSad_Click(object sender, EventArgs e)
        {
            lblClick.text = "Go watch a Bill Murray movie.";
        }

        private void btnHappy_Click(object sender, EventArgs e)
        {
            lblClick.Text = "";
        }
    }
}
