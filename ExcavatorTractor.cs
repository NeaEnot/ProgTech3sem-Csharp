using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class ExcavatorTractor
    {
        private float _startPosX;
        private float _startPosY;
        private int _pictureWidth;
        private int _pictureHeight;
        private const int etWidth = 90;
        private const int etHeight = 50;
        public int MaxSpeed { private set; get; }
        public float Weight { private set; get; }
        public Color MainColor;
        public Color DopColor;
        public Color FlagColor;
        public bool Flag;
        public bool FrontTube;
        public bool BackTube;

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

        public ExcavatorTractor(int maxSpeed, float weight, Color mainColor, 
            Color dopColor, Color flagColor, bool flag, bool frontTube, bool backTube)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            FLAG_COLOR = flagColor;
            Flag = flag;
            FrontTube = frontTube;
            BackTube = backTube;
        }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction) {
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - etWidth) {
                        _startPosX += step;
                    }
                    break;
                case Direction.Left:
                    if (_startPosX - step > 5) {
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

        public void DrawET(Graphics g)
        {
            Pen penMain = new Pen(MainColor);
            Pen penDop = new Pen(DopColor);
            Brush brMain = new SolidBrush(MainColor);
            Brush brDop = new SolidBrush(DopColor);
            Brush brFlag = new SolidBrush(FlagColor);
            Brush brGray = new SolidBrush(Color.Gray);

            g.FillRectangle(brMain, _startPosX + 3, _startPosY + 25, 50, 15);
            g.DrawRectangle(penMain, _startPosX + 40, _startPosY + 7, 7, 25);

            g.FillEllipse(brGray, _startPosX, _startPosY + 35, 55, 15);
            g.FillEllipse(brDop, _startPosX + 2, _startPosY + 38, 10, 10);
            g.FillEllipse(brDop, _startPosX + 15, _startPosY + 38, 10, 10);
            g.FillEllipse(brDop, _startPosX + 28, _startPosY + 38, 10, 10);
            g.FillEllipse(brDop, _startPosX + 41, _startPosY + 38, 10, 10);

            g.DrawLine(penDop, _startPosX + 3, _startPosY + 30, _startPosX - 2, _startPosY + 30);
            g.DrawLine(penDop, _startPosX + 3, _startPosY + 35, _startPosX - 2, _startPosY + 35);
            g.DrawLine(penDop, _startPosX - 2, _startPosY + 20, _startPosX - 2, _startPosY + 45);
            g.DrawLine(penDop, _startPosX - 2, _startPosY + 20, _startPosX - 5, _startPosY + 15);
            g.DrawLine(penDop, _startPosX - 2, _startPosY + 45, _startPosX - 5, _startPosY + 50);

            g.DrawLine(penDop, _startPosX + 50, _startPosY + 25, _startPosX + 60, _startPosY + 10);
            g.DrawLine(penDop, _startPosX + 60, _startPosY + 10, _startPosX + 80, _startPosY + 25);
            g.DrawLine(penDop, _startPosX + 80, _startPosY + 25, _startPosX + 80, _startPosY + 45);
            g.DrawLine(penDop, _startPosX + 80, _startPosY + 30, _startPosX + 70, _startPosY + 30);
            g.DrawLine(penDop, _startPosX + 80, _startPosY + 45, _startPosX + 65, _startPosY + 50);

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
    }
}
