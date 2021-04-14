using System;
using System.Windows.Forms;

namespace binmath {

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new TransferForm().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AdditionFrom().ShowDialog();
        }
    }

}
