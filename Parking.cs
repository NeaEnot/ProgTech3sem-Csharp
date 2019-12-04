using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Parking<T> where T: class, ITransport
    {
        private T[] _places;

        private int PictureWidth { get; set; }
        private int PictureHeight { get; set; }

        private const int _placeSizeWidth = 210;///<summary>///Размер парковочного места (высота)///</summary>
        private const int _placeSizeHeight = 80;

        public Parking(int sizes, int pictureWidth, int pictureHeight)
        {
            _places = new T[sizes];
            PictureWidth = pictureWidth;
            PictureHeight = pictureHeight;

            for (int i = 0; i < _places.Length; i++) {
                _places[i] = null;
            }
        }

        public static int operator+(Parking<T> p, T tractor)
        {
            for (int i = 0; i < p._places.Length; i++) {
                if (p.CheckFreePlace(i)) {
                    p._places[i] = tractor;
                    p._places[i].SetPosition(5 + i / 5 * _placeSizeWidth + 5, 
                                            i % 5 * _placeSizeHeight + 15, 
                                            p.PictureWidth, p.PictureHeight);
                    return i;
                }
            }
            return -1;
        }
        
        public static T operator-(Parking<T> p, int index)
        {
            if (index < 0 || index > p._places.Length) {
                return null;
            }
            if (!p.CheckFreePlace(index)) {
                T tractor = p._places[index];
                p._places[index] = null;
                return tractor;
            }

            return null;
        }

        private bool CheckFreePlace(int index)
        {
            return _places[index] == null;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++) {
                if (!CheckFreePlace(i)) {
                    _places[i].Draw(g);
                }
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.DrawRectangle(pen, 0, 0, (_places.Length / 5) * _placeSizeWidth, 480);
            for (int i = 0; i < _places.Length / 5; i++) {
                for (int j = 0; j < 6; j++){
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight,i * _placeSizeWidth + 110, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, 400);
            }
        }
    }
}
