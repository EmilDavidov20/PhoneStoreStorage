
namespace OOPproject
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainlogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.passwordbtn = new System.Windows.Forms.Label();
            this.usernamebtn = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.passicon = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.manicon = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainlogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passicon)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manicon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.mainlogo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 612);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label6.Location = new System.Drawing.Point(78, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label5.Location = new System.Drawing.Point(130, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Storekeeper Service";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to the";
            // 
            // mainlogo
            // 
            this.mainlogo.Image = global::OOPproject.Properties.Resources.market;
            this.mainlogo.Location = new System.Drawing.Point(81, 128);
            this.mainlogo.Name = "mainlogo";
            this.mainlogo.Size = new System.Drawing.Size(194, 189);
            this.mainlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainlogo.TabIndex = 0;
            this.mainlogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.buttonSignUp);
            this.panel2.Controls.Add(this.buttonSignIn);
            this.panel2.Controls.Add(this.passwordbtn);
            this.panel2.Controls.Add(this.usernamebtn);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.buttonExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(362, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 612);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(434, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSignUp.Location = new System.Drawing.Point(270, 465);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(156, 50);
            this.buttonSignUp.TabIndex = 8;
            this.buttonSignUp.Text = "Sign Up";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSignIn.Location = new System.Drawing.Point(73, 465);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(156, 50);
            this.buttonSignIn.TabIndex = 7;
            this.buttonSignIn.Text = "Sign In";
            this.buttonSignIn.UseVisualStyleBackColor = true;
            this.buttonSignIn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // passwordbtn
            // 
            this.passwordbtn.AutoSize = true;
            this.passwordbtn.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.passwordbtn.ForeColor = System.Drawing.Color.Black;
            this.passwordbtn.Location = new System.Drawing.Point(4, 291);
            this.passwordbtn.Name = "passwordbtn";
            this.passwordbtn.Size = new System.Drawing.Size(100, 22);
            this.passwordbtn.TabIndex = 6;
            this.passwordbtn.Text = "Password:";
            // 
            // usernamebtn
            // 
            this.usernamebtn.AutoSize = true;
            this.usernamebtn.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.usernamebtn.ForeColor = System.Drawing.Color.Black;
            this.usernamebtn.Location = new System.Drawing.Point(4, 207);
            this.usernamebtn.Name = "usernamebtn";
            this.usernamebtn.Size = new System.Drawing.Size(106, 22);
            this.usernamebtn.TabIndex = 5;
            this.usernamebtn.Text = "Username:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.textBoxPassword);
            this.panel4.Controls.Add(this.passicon);
            this.panel4.Location = new System.Drawing.Point(0, 318);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(512, 52);
            this.panel4.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxPassword.Location = new System.Drawing.Point(46, 11);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '●';
            this.textBoxPassword.Size = new System.Drawing.Size(380, 20);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.Click += new System.EventHandler(this.textBox2_Click_1);
            // 
            // passicon
            // 
            this.passicon.Image = global::OOPproject.Properties.Resources.padlock;
            this.passicon.Location = new System.Drawing.Point(7, 8);
            this.passicon.Name = "passicon";
            this.passicon.Size = new System.Drawing.Size(38, 35);
            this.passicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passicon.TabIndex = 1;
            this.passicon.TabStop = false;
            this.passicon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.passicon_MouseDown);
            this.passicon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.passicon_MouseUp);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.textBoxUserName);
            this.panel3.Controls.Add(this.manicon);
            this.panel3.Location = new System.Drawing.Point(0, 235);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(511, 52);
            this.panel3.TabIndex = 3;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUserName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxUserName.Location = new System.Drawing.Point(46, 12);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(380, 20);
            this.textBoxUserName.TabIndex = 1;
            this.textBoxUserName.Click += new System.EventHandler(this.textBox1_Click_1);
            // 
            // manicon
            // 
            this.manicon.Image = global::OOPproject.Properties.Resources.businessman;
            this.manicon.Location = new System.Drawing.Point(7, 9);
            this.manicon.Name = "manicon";
            this.manicon.Size = new System.Drawing.Size(38, 35);
            this.manicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.manicon.TabIndex = 0;
            this.manicon.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(44, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Login to your account";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.buttonExit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonExit.Location = new System.Drawing.Point(470, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonExit.Size = new System.Drawing.Size(41, 45);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(875, 612);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainlogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passicon)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manicon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.PictureBox mainlogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label passwordbtn;
        private System.Windows.Forms.Label usernamebtn;
        private System.Windows.Forms.PictureBox passicon;
        private System.Windows.Forms.PictureBox manicon;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.Button button1;
    }
}

