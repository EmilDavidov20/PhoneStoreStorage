using System;
using System.Windows.Forms;
using OOPproject.NewFolder;
using OOPproject.DataStoarge;
using System.IO;
using System.Linq;

namespace OOPproject
{
    public partial class FormManager : Form
    {
        public FormManager()
        {
            InitializeComponent();

        }
        private void refreshForItem()
        {
            comboBoxCamera.Visible = false;
            comboBoxColors.Visible = false;
            comboBoxInch.Visible = false;
            comboBoxSSD.Visible = false;
            comboBoxBattery.Visible = false;
            comboBoxCompatible.Visible = false;
            comboBoxType.Visible = false;
            comboBoxWattage.Visible = false;
            comboBoxAmperage.Visible = false;
            LabelColors.Visible = false;
            LabelInch.Visible = false;
            LabelSSD.Visible = false;
            LabelSSD.Visible = false;
            LabelCamera.Visible = false;
            LabelBattery.Visible = false;
            LabelCompatible.Visible = false;
            LabelType.Visible = false;
            LabelWattage.Visible = false;
            LabelAmperage.Visible = false;
            checkBoxSupport.Visible = false;
            checkBoxMicrohpone.Visible = false;
        }
        private void visiblePhone()
        {
            comboBoxSSD.Visible = true;
            LabelSSD.Visible = true;
            comboBoxColors.Visible = true;
            LabelColors.Visible = true;
            comboBoxInch.Visible = true;
            LabelInch.Visible = true;
            checkBoxSupport.Visible = true;
            comboBoxCamera.Visible = true;
            LabelCamera.Visible = true;
        }
        private void visibleHeadPhone()
        {
            LabelColors.Visible = true;
            comboBoxColors.Visible = true;
            comboBoxType.Visible = true;
            LabelType.Visible = true;
            checkBoxMicrohpone.Visible = true;
        }
        private void visiblePhoneCase()
        {
            comboBoxColors.Visible = true;
            LabelColors.Visible = true;
            comboBoxCompatible.Visible = true;
            LabelCompatible.Visible = true;
        }
        private void visibleCharger()
        {
            comboBoxWattage.Visible = true;
            comboBoxAmperage.Visible = true;
            LabelWattage.Visible = true;
            LabelAmperage.Visible = true;
        }

        private void refresh_comboBox()
        {
            comboBoxCamera.SelectedIndex = -1;
            comboBoxColors.SelectedIndex = -1;
            comboBoxInch.SelectedIndex = -1;
            comboBoxSSD.SelectedIndex = -1;
            comboBoxBattery.SelectedIndex = -1;
            comboBoxCompatible.SelectedIndex = -1;
            comboBoxType.SelectedIndex = -1;
            comboBoxWattage.SelectedIndex = -1;
            comboBoxAmperage.SelectedIndex = -1;
            checkBoxMicrohpone.Checked = false;
            checkBoxSupport.Checked = false;
        }
        private void btn_return_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void cmb_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshForItem();

            switch (comboBoxItems.SelectedItem.ToString())
            {
                case "Galaxy":
                    visiblePhone();
                    break;
                case "Iphone":
                    visiblePhone();
                    break;
                case "Charger":
                    visibleCharger();
                    break;
                case "Head Phone":
                    visibleHeadPhone();
                    break;
                case "Phone Case":
                    visiblePhoneCase();
                    break;
            }
            refresh_comboBox();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if (comboBoxItems.SelectedIndex == -1)
            {
                MessageBox.Show("Please select any item!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switch (comboBoxItems.SelectedIndex)
            {
                case 0: // for Iphone
                    if (comboBoxColors.Text.Equals("") || comboBoxInch.Text.Equals("") || comboBoxSSD.Text.Equals("") || comboBoxCamera.Text.Equals(""))
                        MessageBox.Show("Please finish fill the form", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        Storage.Stock.Add(new Phone(Convert.ToString("Iphone"), Convert.ToInt32(comboBoxSSD.SelectedItem),
                            Convert.ToString(comboBoxColors.SelectedItem),
                            Convert.ToDouble(comboBoxInch.SelectedItem), checkBoxSupport.Checked,
                            Convert.ToInt32(comboBoxCamera.SelectedItem)));

                        flag = true;
                    }
                    break;
                case 1:  //for Galaxy
                    if (comboBoxColors.Text.Equals("") || comboBoxInch.Text.Equals("") || comboBoxSSD.Text.Equals("") || comboBoxCamera.Text.Equals(""))
                        MessageBox.Show("Please finish fill the form", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        Storage.Stock.Add(new Phone(Convert.ToString("Galaxy"), Convert.ToInt32(comboBoxSSD.SelectedItem),
                              Convert.ToString(comboBoxColors.SelectedItem),
                              Convert.ToDouble(comboBoxInch.SelectedItem), checkBoxSupport.Checked,
                              Convert.ToInt32(comboBoxCamera.SelectedItem)));

                        flag = true;
                    }
                    break;
                case 2: // for Head Phones
                    if (comboBoxType.Text.Equals("") || comboBoxColors.Text.Equals(""))
                        MessageBox.Show("Please finish fill the form", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        Storage.Stock.Add(new HeadPhones(comboBoxColors.SelectedItem.ToString(),
                             comboBoxType.SelectedItem.ToString(), checkBoxMicrohpone.Checked));
                        flag = true;
                    }
                    break;
                case 3: // for Phone Case
                    if (comboBoxColors.Text.Equals("") || comboBoxCompatible.Text.Equals(""))
                        MessageBox.Show("Please finish fill the form", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        Storage.Stock.Add(new PhoneCase(comboBoxColors.SelectedItem.ToString(),
                             comboBoxCompatible.SelectedItem.ToString()));
                        flag = true;
                    }
                    break;
                case 4: // charger
                    if (comboBoxWattage.Text.Equals("") || (comboBoxAmperage.Text.Equals("")))
                        MessageBox.Show("Please finish fill the form", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    else
                    {
                        Storage.Stock.Add(new Charger(Convert.ToInt32(comboBoxWattage.SelectedItem),
                            Convert.ToDouble(comboBoxAmperage.SelectedItem)));
                        flag = true;
                    }
                    break;
            }
            if (flag)
            {
                ShowData();
                refresh_comboBox();
                Storage.SaveData();
                tb_return_id_TextChanged(sender, e);
                tb_return_price_TextChanged(sender, e);
            }
        }
        private void FormManager_Load(object sender, EventArgs e)
        {
            refreshForItem();
            ShowData();
        }
        private void ShowData()
        {
            textBoxData.Text = "";
            if (Storage.Stock != null)
            {
                foreach (Item item in Storage.Stock)
                {
                    textBoxData.Text += item.ToString() + "\r\n";
                }
            }
        }
        private void btn_remove_Click(object sender, EventArgs e)
        {
            bool flag = false;
            Item item = null;

            if (comboBoxItems.SelectedIndex == -1)
            {
                MessageBox.Show("Please select any item!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (comboBoxItems.SelectedIndex)
            {
                case 0: // for Iphone
                    if (comboBoxColors.Text.Equals("") || comboBoxInch.Text.Equals("") || comboBoxSSD.Text.Equals("") || comboBoxCamera.Text.Equals(""))
                    {
                        MessageBox.Show("Please finish filling the form", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    item = new Phone("Iphone", Convert.ToInt32(comboBoxSSD.SelectedItem),
                        comboBoxColors.SelectedItem.ToString(),
                        Convert.ToDouble(comboBoxInch.SelectedItem), checkBoxSupport.Checked,
                        Convert.ToInt32(comboBoxCamera.SelectedItem));
                    break;
                case 1: // for Galaxy
                    if (comboBoxColors.Text.Equals("") || comboBoxInch.Text.Equals("") || comboBoxSSD.Text.Equals("") || comboBoxCamera.Text.Equals(""))
                    {
                        MessageBox.Show("Please finish filling the form", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    item = new Phone("Galaxy", Convert.ToInt32(comboBoxSSD.SelectedItem),
                        comboBoxColors.SelectedItem.ToString(),
                        Convert.ToDouble(comboBoxInch.SelectedItem), checkBoxSupport.Checked,
                        Convert.ToInt32(comboBoxCamera.SelectedItem));
                    break;
                case 2: // for Head Phones 
                    if (comboBoxType.Text.Equals("") || comboBoxColors.Text.Equals(""))
                    {
                        MessageBox.Show("Please finish filling the form", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    item = new HeadPhones(comboBoxColors.SelectedItem.ToString(),
                        comboBoxType.SelectedItem.ToString(), checkBoxMicrohpone.Checked);
                    break;
                case 3: // for Phone Case
                    if (comboBoxColors.Text.Equals("") || comboBoxCompatible.Text.Equals(""))
                    {
                        MessageBox.Show("Please finish filling the form", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    item = new PhoneCase(comboBoxColors.SelectedItem.ToString(),
                        comboBoxCompatible.SelectedItem.ToString());
                    break;
                case 4: // Charger
                    if (comboBoxWattage.Text.Equals("") || (comboBoxAmperage.Text.Equals("")))
                    {
                        MessageBox.Show("Please finish filling the form", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    item = new Charger(Convert.ToInt32(comboBoxWattage.SelectedItem),
                        Convert.ToDouble(comboBoxAmperage.SelectedItem));
                    break;
            }

            if (item != null)
            {
                foreach (Item item2 in Storage.Stock)
                {
                    if (item.Id == item2.Id)
                    {
                        Storage.Stock.Remove(item2);
                        flag = true;
                        tb_return_id.Text = item.Id.ToString();
                        tb_return_price.Text = item.Price.ToString();
                        break;
                    }
                }
                if (flag)
                {
                    MessageBox.Show("The item deleted", "It succeeded!");
                }
                else
                {
                    MessageBox.Show("This item does not exist in the stock", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (flag)
            {
                ShowData();
                refresh_comboBox();
                Storage.SaveData();
            }
        }

        private void tb_return_id_TextChanged(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("list.txt");
            if (lines != null)
            {
                int count = lines.Length - 1;
                string[] sublines = lines[count].Split(' ');
                tb_return_id.Text = sublines[3];
            }
        }
        private void tb_return_price_TextChanged(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("list.txt");
            if (lines != null)
            {
                int count = lines.Length - 1;
                string[] sublines = lines[count].Split(' ');
                tb_return_price.Text = sublines[5];
            }
        }
        private void btn_showStock_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void textBoxData_TextChanged(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            panel.AutoScroll = true;

            panel.Dock = DockStyle.Fill;
            textBoxData.Multiline = true;
            textBoxData.ScrollBars = ScrollBars.Vertical;
            this.Controls.Add(panel);
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonGame_Click(object sender, EventArgs e)
        {
            BoredWorker game = new BoredWorker();
            game.Show();
        }
    }
}
