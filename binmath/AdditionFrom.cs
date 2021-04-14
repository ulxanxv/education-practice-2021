using System;
using System.Windows.Forms;

namespace binmath {

    public partial class AdditionFrom : Form
    {
        public AdditionFrom()
        {
            InitializeComponent();
        }

        private string ToBinary(int a)
        {
            return Convert.ToString(a, 2);
        }

        private int ToDecimal(string str)
        {
            return Convert.ToInt32(str, 2);
        }

        private bool Check(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return false;
            }

            foreach(char symbol in str)
            {
                if (symbol == '1' || symbol == '0')
                {
                    continue;
                }
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Check(textBox1.Text))
            {
                MessageBox.Show("Первое слагаемое введено не в двоичной форме!");
                return;
            }

            if (!Check(textBox2.Text))
            {
                MessageBox.Show("Второе слагаемое введено не в двоичной форме!");
                return;
            }

            int a = ToDecimal(textBox1.Text) + ToDecimal(textBox2.Text);
            textBox3.Text = ToBinary(a);
        }
    }

}
