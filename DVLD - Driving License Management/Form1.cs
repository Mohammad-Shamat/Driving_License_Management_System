using DVLD___Driving_License_Management.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___Driving_License_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
            label1.Text = textBox1.Text;
            guna2Button1.Image = Resources.Female_1;
        }

        

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '\0';
            guna2Button1.Image = Resources.app;
        }
    }
}
