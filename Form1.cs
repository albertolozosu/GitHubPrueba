using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHub2
{
    public partial class Form1 : Form
    {//albert lozano
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int dni = Convert.ToInt32(txtDNI.Text);
            char letter = functionDNI(dni);
            txtLetter.Text = letter.ToString();
        }
        private char functionDNI(int dni) {
            char letter = 'A';
            return letter;
        }
    }
}
