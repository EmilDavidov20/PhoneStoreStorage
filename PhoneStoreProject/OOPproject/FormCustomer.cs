using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OOPproject.DataStoarge;
using OOPproject.NewFolder;

namespace OOPproject
{
    public partial class FormCustomer : Form
    {
        private bool isDragging;
        private Point mouseOffset;
        private Point initialLocation;

        Random random = new Random();
        public FormCustomer()
        {
            InitializeComponent();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Storage.Cart.Count > 0)
            {
                DialogResult result = MessageBox.Show("There are items in the cart. \nAre you sure you want to go back? \nAll items will be removed!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return; 
                }
                else
                {
                    Storage.Cart.Clear();
                    comboBoxCart.Items.Clear();
                    comboBoxCart.ResetText();
                    textBoxItems.Text = "";
                    labelPrice.Text = "0";
                    labelItems.Text = "0";
                }
            }
            Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTimeCustomer.Text = DateTime.Now.ToLongTimeString();

        }
        private void Time_Tick(object sender, EventArgs e)
        {
            labelTimeCustomer.Text = DateTime.Now.ToLongTimeString();
        }
        private void bindComboBox(Item type)
        {
            comboBoxItems.Items.Clear();
            foreach (Item item in Storage.Stock)
            {
                if (item.GetType() == type.GetType())
                {
                    comboBoxItems.Items.Add(item);
                }
            }
            if (comboBoxItems.Items.Count > 0)
            {
                comboBoxItems.Visible = true;
                comboBoxItems.SelectedIndex = 0;
            }
            else comboBoxItems.Visible = false;
        }
        private void btn_Phones_Click_1(object sender, EventArgs e)//phones
        {
            bindComboBox(new Phone());
        }
        private void button2_Click(object sender, EventArgs e) // cases
        {
            bindComboBox(new PhoneCase());
        }
        private void button3_Click(object sender, EventArgs e) // battery   
        {
            bindComboBox(new Charger());
        }
        private void button1_Click(object sender, EventArgs e)// head
        {
            bindComboBox(new HeadPhones());
        }
        private double getTotalAmount()
        {
            double sum = 0;
            foreach (Item item in Storage.Cart)
            {
                sum += item.Price;
            }
            return sum;
        }
        private void buttonAddItemToCart_Click_1(object sender, EventArgs e)
        {
            if (comboBoxItems.Text == "") return;
            Storage.Cart.Add(comboBoxItems.SelectedItem as Item);
            Storage.Stock.Remove(comboBoxItems.SelectedItem as Item);
            comboBoxCart.Items.Add(comboBoxItems.SelectedItem as Item);

            textBoxItems.Text = "";
            foreach (Item item in Storage.Cart)
            {
                textBoxItems.Text += item.ToString() + "\r\n";
            }
            if (comboBoxItems.SelectedItem is Phone)
            {
                bindComboBox(new Phone());
            }
            if (comboBoxItems.SelectedItem is PhoneCase)
            {
                bindComboBox(new PhoneCase());
            }
            if (comboBoxItems.SelectedItem is Charger)
            {
                bindComboBox(new Charger());
            }
            if (comboBoxItems.SelectedItem is HeadPhones)
            {
                bindComboBox(new HeadPhones());
            }
            labelPrice.Text = getTotalAmount().ToString();
            labelItems.Text = Storage.Cart.Count.ToString();
        }
        private void buttonRemove_Click_1(object sender, EventArgs e)
        {
            if (comboBoxCart.Text == "") return;
            for (int i = 0; i < Storage.Cart.Count; i++)
            {
                if (Storage.Cart[i].Id == (comboBoxCart.SelectedItem as Item).Id)
                {
                    Storage.Stock.Add(Storage.Cart[i]);
                    comboBoxCart.Items.Remove(Storage.Cart[i]);
                    comboBoxCart.Text = "";
                    Storage.Cart.Remove(Storage.Cart[i]);
                    break;
                }
            }
            textBoxItems.Text = "";
            foreach (Item item in Storage.Cart)
                textBoxItems.Text += item.ToString() + "\r\n";

            labelPrice.Text = getTotalAmount().ToString();
            labelItems.Text = Storage.Cart.Count.ToString();
        }

        private void buttonBuy_Click_1(object sender, EventArgs e)
        {
            if (Storage.Cart.Count != 0)
            {
                StringBuilder message = new StringBuilder("Selected Items:\n");
                foreach (Item item in Storage.Cart)
                    message.AppendLine(item.ToString());
                DialogResult result = MessageBox.Show(message.ToString() + "\nAre you sure the customer wants to buy these items?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    int randomNumber = random.Next(100, 999);
                    MessageBox.Show("Order Number: #" + randomNumber + "\nTotal Amount:" + getTotalAmount() + "₪", "Order Number!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Storage.Cart = new List<Item>();
                    labelPrice.Text = "0";
                    labelItems.Text = "0";
                    comboBoxCart.Items.Clear();
                    comboBoxCart.ResetText();
                    textBoxItems.Text = "";
                }
            }
            else
                MessageBox.Show("The cart is already empty!", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonPhoneColor_Click(object sender, EventArgs e)
        {
            BlackIphone phonecolor = new BlackIphone();
            phonecolor.ShowDialog();
            Show();
        }

        private void textBoxItems_TextChanged(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            panel.AutoScroll = true;

            panel.Dock = DockStyle.Fill;
            textBoxItems.Multiline = true;
            textBoxItems.ScrollBars = ScrollBars.Vertical;
            this.Controls.Add(panel);
        }

        private void MainPicture_MouseDown(object sender, MouseEventArgs e)
        {
            MainPicture.BringToFront();
            isDragging = true;
            mouseOffset = new Point(e.X, e.Y);
            initialLocation = MainPicture.Location;
        }

        private void MainPicture_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newLocation = MainPicture.Location;
                newLocation.X += e.X - mouseOffset.X;
                newLocation.Y += e.Y - mouseOffset.Y;
                MainPicture.Location = newLocation;
            }
        }

        private void MainPicture_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            MainPicture.Location = initialLocation; 
        }

        private void buttonRemoveAll_Click(object sender, EventArgs e)
        {
            if (Storage.Cart.Count == 0)
            {
                MessageBox.Show("The cart is already empty!", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to remove all items from the cart?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Storage.Cart.Clear();
                comboBoxCart.Items.Clear();
                comboBoxCart.ResetText();
                textBoxItems.Text = "";
                labelPrice.Text = "0";
                labelItems.Text = "0";

                MessageBox.Show("All items have been removed from the cart.", "Cart Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}