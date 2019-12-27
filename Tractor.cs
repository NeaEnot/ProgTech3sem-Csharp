using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    public class Tractor:Transport, IComparable<Tractor>, IEquatable<Tractor>
    {
        protected const int etWidth = 90;
        protected const int etHeight = 50;

        public Tractor(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        public Tractor(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }

        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - etWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                case Direction.Left:
                    if (_startPosX - step > 5)
                    {
                        _startPosX -= step;
                    }
                    break;
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - etHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public override void Draw(Graphics g)
        {
            Pen penMain = new Pen(MainColor);
            Brush brMain = new SolidBrush(MainColor);
            Brush brGray = new SolidBrush(Color.Gray);
            Brush brBlack = new SolidBrush(Color.Black);

            g.FillRectangle(brMain, _startPosX + 3, _startPosY + 25, 50, 15);
            g.DrawRectangle(penMain, _startPosX + 40, _startPosY + 7, 7, 25);

            g.FillEllipse(brGray, _startPosX, _startPosY + 35, 55, 15);
            g.FillEllipse(brBlack, _startPosX + 2, _startPosY + 38, 10, 10);
            g.FillEllipse(brBlack, _startPosX + 15, _startPosY + 38, 10, 10);
            g.FillEllipse(brBlack, _startPosX + 28, _startPosY + 38, 10, 10);
            g.FillEllipse(brBlack, _startPosX + 41, _startPosY + 38, 10, 10);
        }

        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }

        public int CompareTo(Tractor other)
        {
            if (other == null)
            {
                return 1;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return MaxSpeed.CompareTo(other.MaxSpeed);
            }
            if (Weight != other.Weight)
            {
                return Weight.CompareTo(other.Weight);
            }
            if (MainColor != other.MainColor)
            {
                MainColor.Name.CompareTo(other.MainColor.Name);
            }
            return 0;
        }

        public bool Equals(Tractor other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Tractor tractorObj))
            {
                return false;
            }
            else
            {
                return Equals(tractorObj);
            }
        }
    }
}
