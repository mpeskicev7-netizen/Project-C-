using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace lab1
{
    [Serializable]
    public class FreeLine : Figure
    {
        [NonSerialized]
        private Color backColor;

        private List<Point> points;

        public FreeLine(Color lineColor, int lineWidth, Color bgColor)
            : base(0, 0, 0, 0, lineColor, Color.White, lineWidth, false)
        {
            backColor = bgColor;
            points = new List<Point>();
        }

        public void AddPoint(int x, int y) => points.Add(new Point(x, y));
        public Point[] GetPoints() => points.ToArray();
        public void SetBackColor(Color color) => backColor = color;

        public override void Draw(Graphics g)
        {
            if (points.Count < 2) return;
            using (Pen pen = new Pen(lineColor, lineWidth))
                g.DrawCurve(pen, points.ToArray());
        }

        public override void DrawDash(Graphics g)
        {
            if (points.Count < 2) return;
            using (Pen pen = new Pen(lineColor, 1))
            {
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                g.DrawCurve(pen, points.ToArray());
            }
        }

        public override void Hide(Graphics g)
        {
            if (points.Count < 2) return;
            using (Pen pen = new Pen(backColor, lineWidth + 2))
                g.DrawCurve(pen, points.ToArray());
        }

        public override void Offset(int dx, int dy)
        {
            for (int i = 0; i < points.Count; i++)
                points[i] = new Point(points[i].X + dx, points[i].Y + dy);
        }
    }
}