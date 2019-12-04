using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class FormET : Form
    {
        ExcavatorTractor excavatorTractor;

        public FormET()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxET.Width, pictureBoxET.Height);
            Graphics gr = Graphics.FromImage(bmp);
            excavatorTractor.DrawET(gr); pictureBoxET.Image = bmp;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            excavatorTractor = new ExcavatorTractor(rnd.Next(100, 300), rnd.Next(1000, 2000), 
                Color.Blue, Color.Black, Color.Blue, true, false, true);
            excavatorTractor.SetPosition(rnd.Next(10, 100), 150, pictureBoxET.Width, pictureBoxET.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name) {
                case "buttonLeft":
                    excavatorTractor.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    excavatorTractor.MoveTransport(Direction.Right);
                    break;
                case "buttonUp":
                    excavatorTractor.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    excavatorTractor.MoveTransport(Direction.Down);
                    break;
            }

            Draw();
        }
    }
}
