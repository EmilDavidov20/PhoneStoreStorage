using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OOPproject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_users.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Click_1(object sender, EventArgs e)
        {
            textBoxUserName.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            textBoxPassword.BackColor = SystemColors.Control;
        }

        private void textBox2_Click_1(object sender, EventArgs e)
        {
            textBoxPassword.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel3.BackColor = SystemColors.Control;
            textBoxUserName.BackColor = SystemColors.Control;
        }
        private void passicon_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;
        }

        private void passicon_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tbl_users WHERE username= '" + textBoxUserName.Text + "' and password= '" + textBoxPassword.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                string username = dr["username"].ToString();
                MessageBox.Show("Hello " + username + "\nHave a nice day!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                new FormLogin().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Please try again.", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Text = "";
                textBoxUserName.Text = "";
                textBoxUserName.Focus();
                con.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToLongTimeString();
            label6.Text = DateTime.Now.ToLongDateString();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            textBoxPassword.Text = "";
            textBoxUserName.Text = "";
            textBoxUserName.Focus();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            new FormRegister().Show();
            this.Hide();
        }
    }
}
