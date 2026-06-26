using System;
using System.Drawing;

namespace lab1
{
    [Serializable]
    public abstract class Figure
    {
        protected int x1, y1, x2, y2;
        protected Color lineColor;
        protected Color fillColor;
        protected int lineWidth;
        protected bool isFilled;

        public Figure(int x1, int y1, int x2, int y2,
                      Color lineColor, Color fillColor, int lineWidth, bool isFilled)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.lineColor = lineColor;
            this.fillColor = fillColor;
            this.lineWidth = lineWidth;
            this.isFilled = isFilled;
        }

        public abstract void Draw(Graphics g);
        public abstract void DrawDash(Graphics g);
        public abstract void Hide(Graphics g);

        public virtual void Offset(int dx, int dy)
        {
            x1 += dx;
            y1 += dy;
            x2 += dx;
            y2 += dy;
        }

        public int X1 => x1;
        public int Y1 => y1;
        public int X2 => x2;
        public int Y2 => y2;

        public bool IsFilled
        {
            get => isFilled;
            set => isFilled = value;
        }
    }
}