using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OOPproject
{
    public partial class BoredWorker : Form
    {
        Random rand = new Random();
        List<PictureBox> items = new List<PictureBox>();
        public BoredWorker()
        {
            InitializeComponent();
        }
        private void MakePictureBox()
        {
            PictureBox newpic = new PictureBox();
            newpic.Height = 50;
            newpic.Width = 50;
            newpic.BackColor = Color.DodgerBlue;
            int x = rand.Next(10,this.ClientSize.Width-newpic.Width);
            int y = rand.Next(10,this.ClientSize.Height - newpic.Height);
            newpic.Location = new Point(x, y);
            newpic.Click += Newpic_Click;
            items.Add(newpic);
            this.Controls.Add(newpic);
        }
        private void Newpic_Click(object sender, EventArgs e)
        {
            PictureBox temp = sender as PictureBox;
            items.Remove(temp);
            this.Controls.Remove(temp);
            lblItemCount.Text = "Items: " + items.Count();
        }
        private void TimerEvent(object sender, EventArgs e)
        {
            MakePictureBox();
            lblItemCount.Text = "Items: " + items.Count();
        }
    }
}
