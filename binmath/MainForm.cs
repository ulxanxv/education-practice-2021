using System;
using System.Windows.Forms;

namespace binmath {

    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

            transferFormButton.Click += TransferFormButton_Click;
            additionFormButton.Click += AdditionFormButton_Click;
        }

        private void AdditionFormButton_Click(object sender, EventArgs e)
        {
            new AdditionFrom().ShowDialog();
        }

        private void TransferFormButton_Click(object sender, EventArgs e)
        {
            new TransferForm().ShowDialog();
        }

    }

}