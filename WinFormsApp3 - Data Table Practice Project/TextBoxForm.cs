using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3___Data_Table_Practice_Project
{
    public partial class TextBoxForm : Form
    {
        public string TextBoxValue { get; private set; }
        public TextBoxForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveColumn_Click(object sender, EventArgs e)
        {
            TextBoxValue = textBox1.Text;
            this.Close();
        }
    }
}
