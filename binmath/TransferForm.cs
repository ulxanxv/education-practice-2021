using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace binmath
{
    public partial class TransferForm : Form
    {
        public TransferForm()
        {
            InitializeComponent();
        }
        private int toDecimal(string str)
        {
            return Convert.ToInt32(str, 2);
        }
        private bool Check(string str) 
        {
            if (str == "") 
            {
                return false;
            }
            foreach (var c in str) 
            {
                if (c == '1' || c == '0')
                {
                }
                else 
                {
                    return false;
                }
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Check(textBox1.Text)) 
            {
                textBox2.Text = toDecimal(textBox1.Text).ToString();
                return;
            }
            MessageBox.Show("Число введено не в двоичной форме!");
        }
    }
}
