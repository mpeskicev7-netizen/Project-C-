using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    [Serializable]
    public class Line : Figure
    {
        [NonSerialized]
        private Color backColor;

        public Line(int x1, int y1, int x2, int y2, Color lineColor, int lineWidth, Color bgColor) : base (x1, y1, x2, y2, lineColor, Color.White, lineWidth, false)
        {
            backColor = bgColor;
        }

        public void SetBackColor(Color color) => backColor = color;

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(lineColor, lineWidth))
                g.DrawLine(pen, x1, y1, x2, y2);
            
        }

        public override void DrawDash(Graphics g)
        {
            using (Pen pen = new Pen(lineColor, 1))
            {
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                g.DrawLine(pen, x1, y1, x2, y2);
            }
        }

        public override void Hide(Graphics g)
        {
            using (Pen pen = new Pen(backColor, lineWidth + 2))
                g.DrawLine(pen, x1, y1, x2, y2);
        }

    }
}
