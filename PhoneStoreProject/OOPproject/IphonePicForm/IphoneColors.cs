using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOPproject
{
    public partial class BlackIphone : Form
    {
        private bool isDragging;
        private Point lastLocation;

        public BlackIphone()
        {
            InitializeComponent();
        }

        private void BlackIphone_Load(object sender, EventArgs e)
        {
            pictureBoxBlue.Visible = false;
            pictureBoxBlack.Visible = false;
            pictureBoxRed.Visible = false;
            pictureBoxWhite.Visible = false;
        }

        private void ShowPicture(PictureBox pictureBox)
        {
            pictureBoxBlue.Visible = false;
            pictureBoxBlack.Visible = false;
            pictureBoxRed.Visible = false;
            pictureBoxWhite.Visible = false;

            pictureBox.Visible = true;
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            ShowPicture(pictureBoxRed);
        }

        private void buttonBlack_Click(object sender, EventArgs e)
        {
            ShowPicture(pictureBoxBlack);
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            ShowPicture(pictureBoxBlue);
        }

        private void buttonWhite_Click(object sender, EventArgs e)
        {
            ShowPicture(pictureBoxWhite);
        }

        private void phone_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastLocation = e.Location;
        }

        private void phone_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void phone_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private string GetSelectedColor()
        {
            if (pictureBoxRed.Visible)
            {
                return "Red";
            }
            else if (pictureBoxBlack.Visible)
            {
                return "Black";
            }
            else if (pictureBoxBlue.Visible)
            {
                return "Blue";
            }
            else if (pictureBoxWhite.Visible)
            {
                return "White";
            }

            return string.Empty;
        }
        private void pictureBoxRight_Click(object sender, EventArgs e)
        {
            string selectedColor = GetSelectedColor();
            if (!string.IsNullOrEmpty(selectedColor))
            {
                MessageBox.Show("iPhone color is: " + selectedColor, "Color Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select an iPhone color.", "Color Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBoxError_Click(object sender, EventArgs e)
        {
            MessageBox.Show("iPhone color not selected.", "Color Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
        }
    }
}

