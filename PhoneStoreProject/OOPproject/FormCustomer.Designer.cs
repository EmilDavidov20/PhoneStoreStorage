
namespace OOPproject
{
    partial class FormCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPhoneColor = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.labelTimeCustomer = new System.Windows.Forms.Label();
            this.labelItems = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelItems1 = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCharger = new System.Windows.Forms.Button();
            this.pictureBoxCart = new System.Windows.Forms.PictureBox();
            this.buttonCases = new System.Windows.Forms.Button();
            this.buttonHeadPhones = new System.Windows.Forms.Button();
            this.buttonPhones = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MainPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.comboBoxCart = new System.Windows.Forms.ComboBox();
            this.textBoxItems = new System.Windows.Forms.TextBox();
            this.buttonAddItemToCart = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonRemoveAll = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCart)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.buttonPhoneColor);
            this.panel1.Controls.Add(this.buttonOrder);
            this.panel1.Controls.Add(this.labelTimeCustomer);
            this.panel1.Controls.Add(this.labelItems);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Controls.Add(this.labelItems1);
            this.panel1.Controls.Add(this.labelAmount);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 631);
            this.panel1.TabIndex = 3;
            // 
            // buttonPhoneColor
            // 
            this.buttonPhoneColor.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonPhoneColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPhoneColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPhoneColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPhoneColor.Location = new System.Drawing.Point(0, 143);
            this.buttonPhoneColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPhoneColor.Name = "buttonPhoneColor";
            this.buttonPhoneColor.Size = new System.Drawing.Size(226, 64);
            this.buttonPhoneColor.TabIndex = 46;
            this.buttonPhoneColor.Text = "Phone Colors";
            this.buttonPhoneColor.UseVisualStyleBackColor = false;
            this.buttonPhoneColor.Click += new System.EventHandler(this.buttonPhoneColor_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonOrder.Location = new System.Drawing.Point(0, 378);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(226, 60);
            this.buttonOrder.TabIndex = 15;
            this.buttonOrder.Text = "Get Order Number";
            this.buttonOrder.UseVisualStyleBackColor = false;
            this.buttonOrder.Click += new System.EventHandler(this.buttonBuy_Click_1);
            // 
            // labelTimeCustomer
            // 
            this.labelTimeCustomer.AutoSize = true;
            this.labelTimeCustomer.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.labelTimeCustomer.Location = new System.Drawing.Point(12, 9);
            this.labelTimeCustomer.Name = "labelTimeCustomer";
            this.labelTimeCustomer.Size = new System.Drawing.Size(54, 28);
            this.labelTimeCustomer.TabIndex = 45;
            this.labelTimeCustomer.Text = "Time";
            // 
            // labelItems
            // 
            this.labelItems.AutoSize = true;
            this.labelItems.Cursor = System.Windows.Forms.Cursors.No;
            this.labelItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItems.Location = new System.Drawing.Point(95, 323);
            this.labelItems.Name = "labelItems";
            this.labelItems.Size = new System.Drawing.Size(30, 31);
            this.labelItems.TabIndex = 12;
            this.labelItems.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::OOPproject.Properties.Resources.back;
            this.pictureBox2.Location = new System.Drawing.Point(44, 550);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Cursor = System.Windows.Forms.Cursors.No;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(95, 281);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(30, 31);
            this.labelPrice.TabIndex = 11;
            this.labelPrice.Text = "0";
            // 
            // labelItems1
            // 
            this.labelItems1.AutoSize = true;
            this.labelItems1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItems1.Location = new System.Drawing.Point(3, 323);
            this.labelItems1.Name = "labelItems1";
            this.labelItems1.Size = new System.Drawing.Size(86, 31);
            this.labelItems1.TabIndex = 10;
            this.labelItems1.Text = "Items";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.Location = new System.Drawing.Point(3, 281);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(88, 31);
            this.labelAmount.TabIndex = 9;
            this.labelAmount.Text = "Total ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.buttonCharger);
            this.panel2.Controls.Add(this.pictureBoxCart);
            this.panel2.Controls.Add(this.buttonCases);
            this.panel2.Controls.Add(this.buttonHeadPhones);
            this.panel2.Controls.Add(this.buttonPhones);
            this.panel2.Location = new System.Drawing.Point(226, -2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 633);
            this.panel2.TabIndex = 4;
            // 
            // buttonCharger
            // 
            this.buttonCharger.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonCharger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCharger.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCharger.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCharger.Location = new System.Drawing.Point(0, 449);
            this.buttonCharger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCharger.Name = "buttonCharger";
            this.buttonCharger.Size = new System.Drawing.Size(155, 54);
            this.buttonCharger.TabIndex = 8;
            this.buttonCharger.Text = "Battery Charger";
            this.buttonCharger.UseVisualStyleBackColor = false;
            this.buttonCharger.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBoxCart
            // 
            this.pictureBoxCart.Image = global::OOPproject.Properties.Resources.shopping_cart;
            this.pictureBoxCart.Location = new System.Drawing.Point(0, 64);
            this.pictureBoxCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCart.Name = "pictureBoxCart";
            this.pictureBoxCart.Size = new System.Drawing.Size(155, 123);
            this.pictureBoxCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCart.TabIndex = 3;
            this.pictureBoxCart.TabStop = false;
            // 
            // buttonCases
            // 
            this.buttonCases.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonCases.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCases.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCases.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCases.Location = new System.Drawing.Point(0, 380);
            this.buttonCases.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCases.Name = "buttonCases";
            this.buttonCases.Size = new System.Drawing.Size(155, 54);
            this.buttonCases.TabIndex = 7;
            this.buttonCases.Text = "Cases";
            this.buttonCases.UseVisualStyleBackColor = false;
            this.buttonCases.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonHeadPhones
            // 
            this.buttonHeadPhones.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonHeadPhones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHeadPhones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHeadPhones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHeadPhones.Location = new System.Drawing.Point(0, 310);
            this.buttonHeadPhones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonHeadPhones.Name = "buttonHeadPhones";
            this.buttonHeadPhones.Size = new System.Drawing.Size(155, 54);
            this.buttonHeadPhones.TabIndex = 9;
            this.buttonHeadPhones.Text = "Head Phones";
            this.buttonHeadPhones.UseVisualStyleBackColor = false;
            this.buttonHeadPhones.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPhones
            // 
            this.buttonPhones.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonPhones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPhones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPhones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPhones.Location = new System.Drawing.Point(0, 241);
            this.buttonPhones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPhones.Name = "buttonPhones";
            this.buttonPhones.Size = new System.Drawing.Size(155, 54);
            this.buttonPhones.TabIndex = 0;
            this.buttonPhones.Text = "Phones";
            this.buttonPhones.UseVisualStyleBackColor = false;
            this.buttonPhones.Click += new System.EventHandler(this.btn_Phones_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SkyBlue;
            this.panel3.Controls.Add(this.MainPicture);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Location = new System.Drawing.Point(379, -2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(840, 149);
            this.panel3.TabIndex = 5;
            // 
            // MainPicture
            // 
            this.MainPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainPicture.Image = global::OOPproject.Properties.Resources.market;
            this.MainPicture.Location = new System.Drawing.Point(745, 7);
            this.MainPicture.Name = "MainPicture";
            this.MainPicture.Size = new System.Drawing.Size(87, 83);
            this.MainPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainPicture.TabIndex = 46;
            this.MainPicture.TabStop = false;
            this.MainPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPicture_MouseDown);
            this.MainPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPicture_MouseMove);
            this.MainPicture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainPicture_MouseUp);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::OOPproject.Properties.Resources.customer_menu;
            this.pictureBox4.Location = new System.Drawing.Point(3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(834, 143);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 47;
            this.pictureBox4.TabStop = false;
            // 
            // Time
            // 
            this.Time.Enabled = true;
            this.Time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.DropDownHeight = 85;
            this.comboBoxItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.IntegralHeight = false;
            this.comboBoxItems.ItemHeight = 15;
            this.comboBoxItems.Location = new System.Drawing.Point(488, 162);
            this.comboBoxItems.MaxDropDownItems = 6;
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(717, 23);
            this.comboBoxItems.TabIndex = 5;
            // 
            // comboBoxCart
            // 
            this.comboBoxCart.DropDownHeight = 85;
            this.comboBoxCart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxCart.FormattingEnabled = true;
            this.comboBoxCart.IntegralHeight = false;
            this.comboBoxCart.Location = new System.Drawing.Point(488, 550);
            this.comboBoxCart.Name = "comboBoxCart";
            this.comboBoxCart.Size = new System.Drawing.Size(717, 23);
            this.comboBoxCart.TabIndex = 7;
            // 
            // textBoxItems
            // 
            this.textBoxItems.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxItems.Location = new System.Drawing.Point(388, 211);
            this.textBoxItems.Multiline = true;
            this.textBoxItems.Name = "textBoxItems";
            this.textBoxItems.ReadOnly = true;
            this.textBoxItems.Size = new System.Drawing.Size(818, 315);
            this.textBoxItems.TabIndex = 8;
            this.textBoxItems.TextChanged += new System.EventHandler(this.textBoxItems_TextChanged);
            // 
            // buttonAddItemToCart
            // 
            this.buttonAddItemToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonAddItemToCart.Location = new System.Drawing.Point(387, 162);
            this.buttonAddItemToCart.Name = "buttonAddItemToCart";
            this.buttonAddItemToCart.Size = new System.Drawing.Size(95, 43);
            this.buttonAddItemToCart.TabIndex = 13;
            this.buttonAddItemToCart.Text = "Add Item";
            this.buttonAddItemToCart.UseVisualStyleBackColor = true;
            this.buttonAddItemToCart.Click += new System.EventHandler(this.buttonAddItemToCart_Click_1);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonRemove.Location = new System.Drawing.Point(387, 549);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(95, 43);
            this.buttonRemove.TabIndex = 14;
            this.buttonRemove.Text = "Remove Item";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click_1);
            // 
            // buttonRemoveAll
            // 
            this.buttonRemoveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonRemoveAll.Location = new System.Drawing.Point(388, 596);
            this.buttonRemoveAll.Name = "buttonRemoveAll";
            this.buttonRemoveAll.Size = new System.Drawing.Size(94, 29);
            this.buttonRemoveAll.TabIndex = 15;
            this.buttonRemoveAll.Text = "Remove All";
            this.buttonRemoveAll.UseVisualStyleBackColor = true;
            this.buttonRemoveAll.Click += new System.EventHandler(this.buttonRemoveAll_Click);
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1218, 630);
            this.ControlBox = false;
            this.Controls.Add(this.buttonRemoveAll);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAddItemToCart);
            this.Controls.Add(this.textBoxItems);
            this.Controls.Add(this.comboBoxCart);
            this.Controls.Add(this.comboBoxItems);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCustomer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCart)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonPhones;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBoxCart;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonHeadPhones;
        private System.Windows.Forms.Button buttonCharger;
        private System.Windows.Forms.Button buttonCases;
        private System.Windows.Forms.Label labelTimeCustomer;
        private System.Windows.Forms.Timer Time;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.ComboBox comboBoxCart;
        private System.Windows.Forms.TextBox textBoxItems;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelItems1;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelItems;
        private System.Windows.Forms.Button buttonAddItemToCart;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.PictureBox MainPicture;
        private System.Windows.Forms.Button buttonPhoneColor;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button buttonRemoveAll;
    }
}