
namespace OOPproject
{
    partial class FormManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManager));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.buttonGame = new System.Windows.Forms.Button();
            this.comboBoxInch = new System.Windows.Forms.ComboBox();
            this.LabelInch = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.tb_return_id = new System.Windows.Forms.TextBox();
            this.comboBoxCamera = new System.Windows.Forms.ComboBox();
            this.LabelCamera = new System.Windows.Forms.Label();
            this.comboBoxColors = new System.Windows.Forms.ComboBox();
            this.lb_price = new System.Windows.Forms.Label();
            this.tb_return_price = new System.Windows.Forms.TextBox();
            this.LabelColors = new System.Windows.Forms.Label();
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.LabelItems = new System.Windows.Forms.Label();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.LabelSSD = new System.Windows.Forms.Label();
            this.comboBoxSSD = new System.Windows.Forms.ComboBox();
            this.LabelBattery = new System.Windows.Forms.Label();
            this.comboBoxBattery = new System.Windows.Forms.ComboBox();
            this.checkBoxSupport = new System.Windows.Forms.CheckBox();
            this.comboBoxCompatible = new System.Windows.Forms.ComboBox();
            this.LabelCompatible = new System.Windows.Forms.Label();
            this.checkBoxMicrohpone = new System.Windows.Forms.CheckBox();
            this.LabelType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.LabelWattage = new System.Windows.Forms.Label();
            this.comboBoxWattage = new System.Windows.Forms.ComboBox();
            this.LabelAmperage = new System.Windows.Forms.Label();
            this.comboBoxAmperage = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_remove);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 631);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OOPproject.Properties.Resources.market;
            this.pictureBox2.Location = new System.Drawing.Point(19, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(194, 189);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::OOPproject.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(44, 550);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.Location = new System.Drawing.Point(0, 367);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(228, 66);
            this.btn_remove.TabIndex = 2;
            this.btn_remove.Text = "Remove item from the stock";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(0, 285);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(228, 66);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add item to stock";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // buttonGame
            // 
            this.buttonGame.BackColor = System.Drawing.Color.White;
            this.buttonGame.Location = new System.Drawing.Point(1020, 599);
            this.buttonGame.Name = "buttonGame";
            this.buttonGame.Size = new System.Drawing.Size(198, 31);
            this.buttonGame.TabIndex = 45;
            this.buttonGame.Text = "Worker, Are you bored? Press here!";
            this.buttonGame.UseVisualStyleBackColor = false;
            this.buttonGame.Click += new System.EventHandler(this.buttonGame_Click);
            // 
            // comboBoxInch
            // 
            this.comboBoxInch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInch.FormattingEnabled = true;
            this.comboBoxInch.Items.AddRange(new object[] {
            "2.2",
            "3.4",
            "4.6",
            "5.1",
            "6.3"});
            this.comboBoxInch.Location = new System.Drawing.Point(463, 281);
            this.comboBoxInch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxInch.Name = "comboBoxInch";
            this.comboBoxInch.Size = new System.Drawing.Size(115, 21);
            this.comboBoxInch.Sorted = true;
            this.comboBoxInch.TabIndex = 36;
            // 
            // LabelInch
            // 
            this.LabelInch.AutoSize = true;
            this.LabelInch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LabelInch.Location = new System.Drawing.Point(230, 281);
            this.LabelInch.Name = "LabelInch";
            this.LabelInch.Size = new System.Drawing.Size(47, 21);
            this.LabelInch.TabIndex = 35;
            this.LabelInch.Text = " Inch";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.Location = new System.Drawing.Point(586, 542);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(34, 30);
            this.lb_id.TabIndex = 32;
            this.lb_id.Text = "ID";
            // 
            // tb_return_id
            // 
            this.tb_return_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_return_id.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_return_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tb_return_id.Location = new System.Drawing.Point(722, 550);
            this.tb_return_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_return_id.Name = "tb_return_id";
            this.tb_return_id.ReadOnly = true;
            this.tb_return_id.Size = new System.Drawing.Size(115, 24);
            this.tb_return_id.TabIndex = 31;
            // 
            // comboBoxCamera
            // 
            this.comboBoxCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCamera.FormattingEnabled = true;
            this.comboBoxCamera.Items.AddRange(new object[] {
            "1280",
            "1920",
            "2560",
            "640"});
            this.comboBoxCamera.Location = new System.Drawing.Point(463, 319);
            this.comboBoxCamera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCamera.Name = "comboBoxCamera";
            this.comboBoxCamera.Size = new System.Drawing.Size(115, 21);
            this.comboBoxCamera.Sorted = true;
            this.comboBoxCamera.TabIndex = 27;
            // 
            // LabelCamera
            // 
            this.LabelCamera.AutoSize = true;
            this.LabelCamera.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LabelCamera.Location = new System.Drawing.Point(229, 317);
            this.LabelCamera.Name = "LabelCamera";
            this.LabelCamera.Size = new System.Drawing.Size(154, 21);
            this.LabelCamera.TabIndex = 26;
            this.LabelCamera.Text = "Camera Resolution";
            // 
            // comboBoxColors
            // 
            this.comboBoxColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColors.FormattingEnabled = true;
            this.comboBoxColors.Items.AddRange(new object[] {
            "Black",
            "Grey",
            "White"});
            this.comboBoxColors.Location = new System.Drawing.Point(463, 215);
            this.comboBoxColors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxColors.Name = "comboBoxColors";
            this.comboBoxColors.Size = new System.Drawing.Size(115, 21);
            this.comboBoxColors.Sorted = true;
            this.comboBoxColors.TabIndex = 25;
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_price.Location = new System.Drawing.Point(586, 575);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(58, 30);
            this.lb_price.TabIndex = 24;
            this.lb_price.Text = "Price";
            // 
            // tb_return_price
            // 
            this.tb_return_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_return_price.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_return_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tb_return_price.Location = new System.Drawing.Point(722, 581);
            this.tb_return_price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_return_price.Name = "tb_return_price";
            this.tb_return_price.ReadOnly = true;
            this.tb_return_price.Size = new System.Drawing.Size(115, 24);
            this.tb_return_price.TabIndex = 42;
            // 
            // LabelColors
            // 
            this.LabelColors.AutoSize = true;
            this.LabelColors.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LabelColors.Location = new System.Drawing.Point(230, 216);
            this.LabelColors.Name = "LabelColors";
            this.LabelColors.Size = new System.Drawing.Size(51, 21);
            this.LabelColors.TabIndex = 21;
            this.LabelColors.Text = "Color";
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItems.ForeColor = System.Drawing.Color.Black;
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Items.AddRange(new object[] {
            "Iphone",
            "Galaxy",
            "Head Phone",
            "Phone Case",
            "Charger"});
            this.comboBoxItems.Location = new System.Drawing.Point(463, 167);
            this.comboBoxItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(115, 21);
            this.comboBoxItems.TabIndex = 20;
            this.comboBoxItems.SelectedIndexChanged += new System.EventHandler(this.cmb_items_SelectedIndexChanged);
            // 
            // LabelItems
            // 
            this.LabelItems.AutoSize = true;
            this.LabelItems.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LabelItems.Location = new System.Drawing.Point(229, 164);
            this.LabelItems.Name = "LabelItems";
            this.LabelItems.Size = new System.Drawing.Size(109, 21);
            this.LabelItems.TabIndex = 37;
            this.LabelItems.Text = "Choose item:";
            // 
            // textBoxData
            // 
            this.textBoxData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxData.Location = new System.Drawing.Point(585, 167);
            this.textBoxData.Multiline = true;
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.ReadOnly = true;
            this.textBoxData.Size = new System.Drawing.Size(621, 352);
            this.textBoxData.TabIndex = 41;
            this.textBoxData.TextChanged += new System.EventHandler(this.textBoxData_TextChanged);
            // 
            // LabelSSD
            // 
            this.LabelSSD.AutoSize = true;
            this.LabelSSD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LabelSSD.Location = new System.Drawing.Point(230, 358);
            this.LabelSSD.Name = "LabelSSD";
            this.LabelSSD.Size = new System.Drawing.Size(40, 21);
            this.LabelSSD.TabIndex = 26;
            this.LabelSSD.Text = "SSD";
            // 
            // comboBoxSSD
            // 
            this.comboBoxSSD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSSD.FormattingEnabled = true;
            this.comboBoxSSD.Items.AddRange(new object[] {
            "1024",
            "128",
            "256",
            "512",
            "64"});
            this.comboBoxSSD.Location = new System.Drawing.Point(463, 361);
            this.comboBoxSSD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSSD.Name = "comboBoxSSD";
            this.comboBoxSSD.Size = new System.Drawing.Size(115, 21);
            this.comboBoxSSD.Sorted = true;
            this.comboBoxSSD.TabIndex = 27;
            // 
            // LabelBattery
            // 
            this.LabelBattery.AutoSize = true;
            this.LabelBattery.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LabelBattery.Location = new System.Drawing.Point(233, 250);
            this.LabelBattery.Name = "LabelBattery";
            this.LabelBattery.Size = new System.Drawing.Size(98, 21);
            this.LabelBattery.TabIndex = 43;
            this.LabelBattery.Text = "Battery Life";
            // 
            // comboBoxBattery
            // 
            this.comboBoxBattery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBattery.FormattingEnabled = true;
            this.comboBoxBattery.Items.AddRange(new object[] {
            "99",
            "100"});
            this.comboBoxBattery.Location = new System.Drawing.Point(463, 249);
            this.comboBoxBattery.Name = "comboBoxBattery";
            this.comboBoxBattery.Size = new System.Drawing.Size(115, 21);
            this.comboBoxBattery.TabIndex = 44;
            // 
            // checkBoxSupport
            // 
            this.checkBoxSupport.AutoSize = true;
            this.checkBoxSupport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxSupport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxSupport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBoxSupport.Location = new System.Drawing.Point(234, 552);
            this.checkBoxSupport.Name = "checkBoxSupport";
            this.checkBoxSupport.Size = new System.Drawing.Size(232, 25);
            this.checkBoxSupport.TabIndex = 45;
            this.checkBoxSupport.Text = "Support Wireless Charging";
            this.checkBoxSupport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxSupport.UseVisualStyleBackColor = true;
            // 
            // comboBoxCompatible
            // 
            this.comboBoxCompatible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCompatible.FormattingEnabled = true;
            this.comboBoxCompatible.Items.AddRange(new object[] {
            "IOS",
            "Android"});
            this.comboBoxCompatible.Location = new System.Drawing.Point(463, 400);
            this.comboBoxCompatible.Name = "comboBoxCompatible";
            this.comboBoxCompatible.Size = new System.Drawing.Size(115, 21);
            this.comboBoxCompatible.TabIndex = 46;
            // 
            // LabelCompatible
            // 
            this.LabelCompatible.AutoSize = true;
            this.LabelCompatible.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LabelCompatible.Location = new System.Drawing.Point(229, 397);
            this.LabelCompatible.Name = "LabelCompatible";
            this.LabelCompatible.Size = new System.Drawing.Size(205, 21);
            this.LabelCompatible.TabIndex = 47;
            this.LabelCompatible.Text = "Compatible Phone Model";
            // 
            // checkBoxMicrohpone
            // 
            this.checkBoxMicrohpone.AutoSize = true;
            this.checkBoxMicrohpone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxMicrohpone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxMicrohpone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBoxMicrohpone.Location = new System.Drawing.Point(234, 590);
            this.checkBoxMicrohpone.Name = "checkBoxMicrohpone";
            this.checkBoxMicrohpone.Size = new System.Drawing.Size(154, 25);
            this.checkBoxMicrohpone.TabIndex = 48;
            this.checkBoxMicrohpone.Text = "Has Microhpone";
            this.checkBoxMicrohpone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxMicrohpone.UseVisualStyleBackColor = true;
            // 
            // LabelType
            // 
            this.LabelType.AutoSize = true;
            this.LabelType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LabelType.Location = new System.Drawing.Point(229, 436);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(46, 21);
            this.LabelType.TabIndex = 49;
            this.LabelType.Text = "Type";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "IOS",
            "Android"});
            this.comboBoxType.Location = new System.Drawing.Point(463, 439);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(115, 21);
            this.comboBoxType.TabIndex = 50;
            // 
            // LabelWattage
            // 
            this.LabelWattage.AutoSize = true;
            this.LabelWattage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LabelWattage.Location = new System.Drawing.Point(229, 466);
            this.LabelWattage.Name = "LabelWattage";
            this.LabelWattage.Size = new System.Drawing.Size(74, 21);
            this.LabelWattage.TabIndex = 51;
            this.LabelWattage.Text = "Wattage";
            // 
            // comboBoxWattage
            // 
            this.comboBoxWattage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWattage.FormattingEnabled = true;
            this.comboBoxWattage.Items.AddRange(new object[] {
            "15",
            "20",
            "30"});
            this.comboBoxWattage.Location = new System.Drawing.Point(463, 468);
            this.comboBoxWattage.Name = "comboBoxWattage";
            this.comboBoxWattage.Size = new System.Drawing.Size(115, 21);
            this.comboBoxWattage.TabIndex = 52;
            // 
            // LabelAmperage
            // 
            this.LabelAmperage.AutoSize = true;
            this.LabelAmperage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LabelAmperage.Location = new System.Drawing.Point(230, 507);
            this.LabelAmperage.Name = "LabelAmperage";
            this.LabelAmperage.Size = new System.Drawing.Size(89, 21);
            this.LabelAmperage.TabIndex = 53;
            this.LabelAmperage.Text = "Amperage";
            // 
            // comboBoxAmperage
            // 
            this.comboBoxAmperage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAmperage.FormattingEnabled = true;
            this.comboBoxAmperage.Items.AddRange(new object[] {
            "1.4",
            "2.8",
            "3.4"});
            this.comboBoxAmperage.Location = new System.Drawing.Point(463, 507);
            this.comboBoxAmperage.Name = "comboBoxAmperage";
            this.comboBoxAmperage.Size = new System.Drawing.Size(115, 21);
            this.comboBoxAmperage.TabIndex = 54;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::OOPproject.Properties.Resources.storeroom_stock_low_resolution_logo_color_on_transparent_background;
            this.pictureBox3.Location = new System.Drawing.Point(283, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(855, 149);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 55;
            this.pictureBox3.TabStop = false;
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1218, 630);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.buttonGame);
            this.Controls.Add(this.LabelCompatible);
            this.Controls.Add(this.LabelSSD);
            this.Controls.Add(this.LabelCamera);
            this.Controls.Add(this.LabelInch);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.comboBoxAmperage);
            this.Controls.Add(this.LabelAmperage);
            this.Controls.Add(this.comboBoxWattage);
            this.Controls.Add(this.LabelWattage);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.LabelType);
            this.Controls.Add(this.checkBoxMicrohpone);
            this.Controls.Add(this.comboBoxCompatible);
            this.Controls.Add(this.checkBoxSupport);
            this.Controls.Add(this.comboBoxBattery);
            this.Controls.Add(this.LabelBattery);
            this.Controls.Add(this.comboBoxSSD);
            this.Controls.Add(this.LabelItems);
            this.Controls.Add(this.comboBoxInch);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.comboBoxCamera);
            this.Controls.Add(this.comboBoxColors);
            this.Controls.Add(this.lb_price);
            this.Controls.Add(this.LabelColors);
            this.Controls.Add(this.comboBoxItems);
            this.Controls.Add(this.tb_return_id);
            this.Controls.Add(this.tb_return_price);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mangger";
            this.Load += new System.EventHandler(this.FormManager_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox comboBoxInch;
        // private System.Windows.Forms.Label labelInch;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.TextBox tb_return_id;
        private System.Windows.Forms.ComboBox comboBoxCamera;
        //private System.Windows.Forms.Label labepixel;
        private System.Windows.Forms.ComboBox comboBoxColors;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.TextBox tb_return_price;
        private System.Windows.Forms.Label LabelCamera;
        private System.Windows.Forms.Label LabelColors;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.Label LabelItems;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.Label LabelSSD;
        // private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox comboBoxSSD;
        private System.Windows.Forms.Label LabelInch;
        //private System.Windows.Forms.ComboBox Combo; //???
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LabelBattery;
        private System.Windows.Forms.ComboBox comboBoxBattery;
        private System.Windows.Forms.CheckBox checkBoxSupport;
        private System.Windows.Forms.ComboBox comboBoxCompatible;
        private System.Windows.Forms.Label LabelCompatible;
        private System.Windows.Forms.CheckBox checkBoxMicrohpone;
        private System.Windows.Forms.Label LabelType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label LabelWattage;
        private System.Windows.Forms.ComboBox comboBoxWattage;
        private System.Windows.Forms.Label LabelAmperage;
        private System.Windows.Forms.ComboBox comboBoxAmperage;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonGame;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}