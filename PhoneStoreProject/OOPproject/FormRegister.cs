using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OOPproject
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        { 
            InitializeComponent();
        }

       OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_users.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxUserName.Text=="" && textBoxPassword.Text== "" && textBoxConfirmPassword.Text=="")
            {
                MessageBox.Show("Username and Password fiels are empty","Sign Up Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (textBoxPassword.Text==textBoxConfirmPassword.Text)
            {
                con.Open();
                string register="INSERT INTO tbl_users VALUES ('"+textBoxUserName.Text +"','"+textBoxPassword.Text +"')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                cmd.Clone();

                textBoxConfirmPassword.Text = "";
                textBoxPassword.Text = "";
                textBoxUserName.Text = "";

                MessageBox.Show("Your Account has been Created","Registration Success",MessageBoxButtons.OK,MessageBoxIcon.Information );

            }
            else
            {
                MessageBox.Show("Password does not match, Please try again", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Text = "";
                textBoxConfirmPassword.Text = "";
                textBoxPassword.Focus();
            }
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxShowPassword.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
                textBoxConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '●';
                textBoxConfirmPassword.PasswordChar = '●';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBoxConfirmPassword.Text = "";
            textBoxPassword.Text = "";
            textBoxUserName.Text = "";
            textBoxUserName.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
