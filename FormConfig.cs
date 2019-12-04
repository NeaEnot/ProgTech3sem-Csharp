using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab
{
    public partial class FormConfig : Form
    {
        ITransport tractor = null;

        private event tractorDelegate eventAdd;

        public FormConfig()
        {
            InitializeComponent();

            panelBlack.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelDarkGray.MouseDown += panelColor_MouseDown;
            panelLightGray.MouseDown += panelColor_MouseDown;
            panelBeige.MouseDown += panelColor_MouseDown;
            panelTurquoise.MouseDown += panelColor_MouseDown;
            panelLightBlue.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void Draw()
        {
            if (tractor != null)
            {
                Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
                Graphics gr = Graphics.FromImage(bmp);
                tractor.SetPosition(5, 5, pictureBox.Width, pictureBox.Height);
                tractor.Draw(gr);
                pictureBox.Image = bmp;
            }
        }

        public void AddEvent(tractorDelegate ev)
        {
            if (eventAdd == null)
            {
                eventAdd = new tractorDelegate(ev);
            }
            else
            {
                eventAdd += ev;
            }
        }

        private void labelTractor_MouseDown(object sender, MouseEventArgs e)
        {
            labelTractor.DoDragDrop(labelTractor.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelExcavatorTractor_MouseDown(object sender, MouseEventArgs e)
        {
            labelExcavatorTractor.DoDragDrop(labelExcavatorTractor.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void picturePanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void picturePanel_DragDrop(object sender, DragEventArgs e)
        {
            switch(e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Tractor":
                    tractor = new Tractor(100, 500, Color.White);
                    break;
                case "Excavator Tractor":
                    tractor = new ExcavatorTractor(100, 500, Color.White, Color.Black, Color.White, true, false, true, true, true);
                    break;
            }
            Draw();
        }

        private void labelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            if (tractor != null)
            {
                tractor.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                Draw();
            }
        }

        private void labelMainColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (tractor != null)
            {
                if (tractor is ExcavatorTractor)
                {
                    (tractor as ExcavatorTractor).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    Draw();
                }
            }
        }

        private void labelDopColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            eventAdd?.Invoke(tractor);
            Close();
        }
    }
}
