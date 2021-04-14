using System;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace binmath {

    public partial class AdditionFrom : Form
    {
        public AdditionFrom()
        {
            InitializeComponent();

            additionButton.Click += AdditionButton_Click;
        }

        private void AdditionButton_Click(object sender, EventArgs e)
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

            textBox3.Text = ToBinaryString(BigInteger.Add(BigInteger.Parse(BinaryToDec(textBox1.Text)), BigInteger.Parse(BinaryToDec(textBox2.Text))));
        }

        /// <summary>
        /// Конвертация BigInteger в двоичное представление (строка)
        /// </summary>
        /// <param name="bigint">Число, которое необходимо конвертировать</param>
        /// <returns>Двоичное представление числа</returns>
        public string ToBinaryString(BigInteger bigint) {
            byte[] bytes        = bigint.ToByteArray();

            StringBuilder base2 = new StringBuilder(bytes.Length * 8);

            int idx             = bytes.Length - 1;
            string binary       = Convert.ToString(bytes[idx], 2);

            if (binary[0] != '0' && bigint.Sign == 1) {
                base2.Append('0');
            }

            base2.Append(binary);

            for (idx--; idx >= 0; idx--) {
                base2.Append(Convert.ToString(bytes[idx], 2).PadLeft(8, '0'));
            }

            return base2.ToString();
        }

        /// <summary>
        /// Конвертация двоичного числа (строки) в эквивалентное десятичное представление
        /// </summary>
        /// <param name="value">Двоичное число (строка)</param>
        /// <returns>Десятичное число (строка)</returns>
        public string BinaryToDec(string value)
        {
            BigInteger res = 0;

            foreach (char c in value) {
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
    }

}