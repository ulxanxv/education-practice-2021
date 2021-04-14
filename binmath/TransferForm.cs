using System;
using System.Numerics;
using System.Windows.Forms;

namespace binmath {

    public partial class TransferForm : Form
    {
        public TransferForm()
        {
            InitializeComponent();

            transferButton.Click += TransferButton_Click;
        }

        /// <summary>
        /// Конвертация двоичного числа (строки) в эквивалентное десятичное представление
        /// </summary>
        /// <param name="value">Двоичное число (строка)</param>
        /// <returns>Десятичное число (строка)</returns>
        public string BinaryToDec(string value)
        {
            BigInteger res = 0;

            foreach (char c in value)
            {
                res <<= 1;
                res += c == '1' ? 1 : 0;
            }

            return res.ToString();
        }

        private bool Check(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return false;
            }

            foreach (char symbol in str)
            {
                if (symbol == '1' || symbol == '0')
                {
                    continue;
                }
                return false;
            }

            return true;
        }

        private void TransferButton_Click(object sender, EventArgs e) {
            if (Check(textBox1.Text)) {
                textBox2.Text = BinaryToDec(textBox1.Text);
                return;
            }

            MessageBox.Show("Число введено не в двоичной форме!");
        }
    }

}