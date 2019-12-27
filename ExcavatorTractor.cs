using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    public class ExcavatorTractor:Tractor, IComparable<ExcavatorTractor>, IEquatable<ExcavatorTractor>
    {
        public Color DopColor;
        public Color FlagColor;
        public bool Flag;
        public bool FrontTube;
        public bool BackTube;
        public bool FrontLadle;
        public bool WheelChock;

        public Color FLAG_COLOR
        {
            set
            {
                if (value != MainColor && value != DopColor)
                {
                    FlagColor = value;
                }
                else
                {
                    Random rnd = new Random();
                    Color color = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255), rnd.Next(255));
                    FLAG_COLOR = color;
                }
            }
            get
            {
                return FlagColor;
            }
        }

        public Color DOP_COLOR
        {
            set
            {
                if (value != MainColor)
                {
                    DopColor = value;
                }
                else
                {
                    Random rnd = new Random();
                    Color color = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255));
                    DOP_COLOR = color;
                }
            }
            get
            {
                return DopColor;
            }
        }

        public ExcavatorTractor(int maxSpeed, float weight, Color mainColor, 
            Color dopColor, Color flagColor, bool ladle, bool chock, bool flag, bool frontTube, bool backTube)
            :base(maxSpeed, weight, mainColor)
        {
            DOP_COLOR = dopColor;
            FLAG_COLOR = flagColor;
            Flag = flag;
            FrontTube = frontTube;
            BackTube = backTube;
            WheelChock = chock;
            FrontLadle = ladle;
        }

        public ExcavatorTractor(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 9)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Flag = Convert.ToBoolean(strs[4]);
                FrontTube = Convert.ToBoolean(strs[5]);
                BackTube = Convert.ToBoolean(strs[6]);
                WheelChock = Convert.ToBoolean(strs[7]);
                FrontLadle = Convert.ToBoolean(strs[8]);
            }
        }

        public override void Draw(Graphics g)
        {
            Pen penDop = new Pen(DopColor);
            Brush brMain = new SolidBrush(MainColor);
            Brush brDop = new SolidBrush(DopColor);
            Brush brFlag = new SolidBrush(FlagColor);

            base.Draw(g);

            if (FrontLadle)
            {
                g.DrawLine(penDop, _startPosX + 3, _startPosY + 30, _startPosX - 2, _startPosY + 30);
                g.DrawLine(penDop, _startPosX + 3, _startPosY + 35, _startPosX - 2, _startPosY + 35);
                g.DrawLine(penDop, _startPosX - 2, _startPosY + 20, _startPosX - 2, _startPosY + 45);
                g.DrawLine(penDop, _startPosX - 2, _startPosY + 20, _startPosX - 5, _startPosY + 15);
                g.DrawLine(penDop, _startPosX - 2, _startPosY + 45, _startPosX - 5, _startPosY + 50);
            }

            g.DrawLine(penDop, _startPosX + 50, _startPosY + 25, _startPosX + 60, _startPosY + 10);
            g.DrawLine(penDop, _startPosX + 60, _startPosY + 10, _startPosX + 80, _startPosY + 25);
            g.DrawLine(penDop, _startPosX + 80, _startPosY + 25, _startPosX + 80, _startPosY + 45);
            g.DrawLine(penDop, _startPosX + 80, _startPosY + 30, _startPosX + 70, _startPosY + 30);
            g.DrawLine(penDop, _startPosX + 80, _startPosY + 45, _startPosX + 65, _startPosY + 50);

            if (WheelChock)
            {
                g.FillRectangle(brDop, _startPosX + 15, _startPosY + 30, 5, 18);
                g.FillRectangle(brDop, _startPosX + 35, _startPosY + 30, 5, 18);
            }

            if (Flag) {
                g.DrawLine(penDop, _startPosX + 47, _startPosY + 10, _startPosX + 47, _startPosY);
                g.FillRectangle(brFlag, _startPosX + 47, _startPosY, 20, 7);
            }

            if (FrontTube) {
                g.FillRectangle(brMain, _startPosX + 8, _startPosY + 10, 5, 15);
            }

            if (BackTube) {
                g.FillRectangle(brMain, _startPosX + 16, _startPosY + 10, 5, 15);
            }
        }

        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + Flag + ";" + 
                    FrontTube + ";" + BackTube + ";" + WheelChock + ";" + FrontLadle;
        }

        public int CompareTo(ExcavatorTractor other)
        {
            var res = (this is Tractor).CompareTo(other is Tractor);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                DopColor.Name.CompareTo(other.DopColor.Name);
            }
            if (Flag != other.Flag)
            {
                return Flag.CompareTo(other.Flag);
            }
            if (FrontTube != other.FrontTube)
            {
                return FrontTube.CompareTo(other.FrontTube);
            }
            if (BackTube != other.BackTube)
            {
                return BackTube.CompareTo(other.BackTube);
            }
            if (FrontLadle != other.FrontLadle)
            {
                return FrontLadle.CompareTo(other.FrontLadle);
            }
            if (WheelChock != other.WheelChock)
            {
                return WheelChock.CompareTo(other.WheelChock);
            }

            return 0;
        }

        public bool Equals(ExcavatorTractor other)
        {
            var res = (this as Tractor).Equals(other as Tractor);
            if (!res)
            {
                return res;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (Flag != other.Flag)
            {
                return false;
            }
            if (FrontTube != other.FrontTube)
            {
                return false;
            }
            if (BackTube != other.BackTube)
            {
                return false;
            }
            if (FrontLadle != other.FrontLadle)
            {
                return false;
            }
            if (WheelChock != other.WheelChock)
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
            if (!(obj is ExcavatorTractor tractorObj))
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
