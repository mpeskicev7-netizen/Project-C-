using System;
using System.Drawing;

namespace lab1
{
    [Serializable]
    public class Rect : Figure
    {
        [NonSerialized]
        private Color backColor;

        public Rect(int x1, int y1, int x2, int y2,
                    Color lineColor, Color fillColor, int lineWidth, bool isFilled, Color bgColor)
            : base(x1, y1, x2, y2, lineColor, fillColor, lineWidth, isFilled)
        {
            backColor = bgColor;
        }

        public void SetBackColor(Color color) => backColor = color;

        public override void Draw(Graphics g)
        {
            int left = Math.Min(x1, x2);
            int top = Math.Min(y1, y2);
            int w = Math.Abs(x2 - x1);
            int h = Math.Abs(y2 - y1);

            if (isFilled)
                using (SolidBrush brush = new SolidBrush(fillColor))
                    g.FillRectangle(brush, left, top, w, h);

            using (Pen pen = new Pen(lineColor, lineWidth))
                g.DrawRectangle(pen, left, top, w, h);
        }

        public override void DrawDash(Graphics g)
        {
            int left = Math.Min(x1, x2);
            int top = Math.Min(y1, y2);
            int w = Math.Abs(x2 - x1);
            int h = Math.Abs(y2 - y1);

            using (Pen pen = new Pen(lineColor, 1))
            {
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                g.DrawRectangle(pen, left, top, w, h);
            }
        }

        public override void Hide(Graphics g)
        {
            int left = Math.Min(x1, x2);
            int top = Math.Min(y1, y2);
            int w = Math.Abs(x2 - x1);
            int h = Math.Abs(y2 - y1);

            using (Pen pen = new Pen(backColor, lineWidth + 2))
                g.DrawRectangle(pen, left, top, w, h);
        }
    }
}