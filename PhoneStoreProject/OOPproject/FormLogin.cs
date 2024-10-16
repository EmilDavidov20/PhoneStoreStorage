using System;
using System.Windows.Forms;
using OOPproject.DataStoarge;

namespace OOPproject
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Storage.SaveData();
            DialogResult result = MessageBox.Show("Are you sure you want to Exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }
        private void btn_admin_Click(object sender, EventArgs e)
        {
            FormManager formManager = new FormManager();
            Hide();
            formManager.ShowDialog();
            Show();
        }
        private void btn_customer_Click(object sender, EventArgs e)
        {
            FormCustomer formCustomer = new FormCustomer();
            Hide();
            formCustomer.ShowDialog();
            Show();
        }
    }
}

