using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class FormTransport : Form
    {
        ITransport tractor;

        public FormTransport()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxET.Width, pictureBoxET.Height);
            Graphics gr = Graphics.FromImage(bmp);
            tractor.Draw(gr); pictureBoxET.Image = bmp;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            Random rnd = new Random();

            switch (name)
            {
                case "buttonCreateT":
                    tractor = new Tractor(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue);
                    break;
                case "buttonCreateET":
                    tractor = new ExcavatorTractor(rnd.Next(100, 300), rnd.Next(1000, 2000),
                Color.Blue, Color.Blue, Color.Blue, true, true, true, false, true);
                    break;
            }
            
            tractor.SetPosition(rnd.Next(10, 100), 150, pictureBoxET.Width, pictureBoxET.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name) {
                case "buttonLeft":
                    tractor.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    tractor.MoveTransport(Direction.Right);
                    break;
                case "buttonUp":
                    tractor.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    tractor.MoveTransport(Direction.Down);
                    break;
            }

            Draw();
        }
    }
}
