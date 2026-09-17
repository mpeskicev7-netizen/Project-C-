using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form2 : Form
    {
        private List<Figure> figures;
        private int startX, startY;
        private bool isDrawing = false;
        private Figure currentFigure;
        private FreeLine currentFreeLine;
        internal string currentFilePath = null;
        internal bool isModified = false;

        private Color currentLineColor;
        private Color currentFillColor;
        private int currentLineWidth;
        private Size pictureSize;
        private FigureType currentFigureType;
        private bool isFillingEnabled;

        public Form2() : this(new Size(800, 600), Color.Black, Color.Transparent, 1, FigureType.Rectangle, false)
        {
        }

        public Form2(Size size, Color lineColor, Color fillColor, int lineWidth,
                     FigureType figureType, bool fillingEnabled)
        {
            InitializeComponent();

            this.AutoScroll = true;
            pictureSize = size;
            this.AutoScrollMinSize = pictureSize;
            this.BackColor = SystemColors.ControlDark;
            this.DoubleBuffered = true;

            figures = new List<Figure>();
            currentFilePath = null;
            isModified = false;

            currentLineColor = lineColor;
            currentFillColor = fillColor;
            currentLineWidth = lineWidth;
            currentFigureType = figureType;
            isFillingEnabled = fillingEnabled;

            //this.Activated += Form2_Activated;
        }

        public Form2(Tuple<Size, List<Figure>> loadedData, Color lineColor, Color fillColor,
                     int lineWidth, FigureType figureType, bool fillingEnabled)
            : this(loadedData.Item1, lineColor, fillColor, lineWidth, figureType, fillingEnabled)
        {
            figures = loadedData.Item2;
            foreach (Rect rect in figures.OfType<Rect>())
                rect.SetBackColor(this.BackColor);
            foreach (Ellipse ellipse in figures.OfType<Ellipse>())
                ellipse.SetBackColor(this.BackColor);
            foreach (Line line in figures.OfType<Line>())
                line.SetBackColor(this.BackColor);
            foreach (FreeLine freeLine in figures.OfType<FreeLine>())
                freeLine.SetBackColor(this.BackColor);
            Invalidate();
        }

        public void UpdateSettings(Color lineColor, Color fillColor, int lineWidth,
                                   FigureType figureType, bool fillingEnabled)
        {
            currentLineColor = lineColor;
            currentFillColor = fillColor;
            currentLineWidth = lineWidth;
            currentFigureType = figureType;
            isFillingEnabled = fillingEnabled;
            UpdateStatusBar();
        }

        public void UpdateStatusBar()
        {
            if (this.ParentForm is Form1 mainForm)
            {
                mainForm.UpdateStatusBar();
                mainForm.UpdateStatusBarSize(pictureSize.Width, pictureSize.Height);
            }
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            UpdateStatusBar();
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                Point offset = this.AutoScrollPosition;
                startX = e.X - offset.X;
                startY = e.Y - offset.Y;

                switch (currentFigureType)
                {
                    case FigureType.Rectangle:
                        currentFigure = new Rect(startX, startY, startX, startY,
                            currentLineColor, currentFillColor, currentLineWidth, isFillingEnabled, this.BackColor);
                        break;
                    case FigureType.Ellipse:
                        currentFigure = new Ellipse(startX, startY, startX, startY,
                            currentLineColor, currentFillColor, currentLineWidth, isFillingEnabled, this.BackColor);
                        break;
                    case FigureType.Line:
                        currentFigure = new Line(startX, startY, startX, startY,
                            currentLineColor, currentLineWidth, this.BackColor);
                        break;
                    case FigureType.FreeLine:
                        currentFreeLine = new FreeLine(currentLineColor, currentLineWidth, this.BackColor);
                        currentFreeLine.AddPoint(startX, startY);
                        currentFigure = currentFreeLine;
                        break;
                }
            }
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.ParentForm is Form1 mainForm)
            {
                Point offset = this.AutoScrollPosition;
                int realX = e.X - offset.X;
                int realY = e.Y - offset.Y;
                mainForm.UpdateStatusBarCoordinates(realX, realY);
            }

            if (isDrawing)
            {
                Point offset = this.AutoScrollPosition;
                int currentX = e.X - offset.X;
                int currentY = e.Y - offset.Y;

                if (currentFigureType == FigureType.FreeLine && currentFreeLine != null)
                {
                    currentFreeLine.AddPoint(currentX, currentY);
                }
                else if (currentFigure != null)
                {
                    switch (currentFigureType)
                    {
                        case FigureType.Rectangle:
                            currentFigure = new Rect(currentFigure.X1, currentFigure.Y1, currentX, currentY,
                                currentLineColor, currentFillColor, currentLineWidth, isFillingEnabled, this.BackColor);
                            break;
                        case FigureType.Ellipse:
                            currentFigure = new Ellipse(currentFigure.X1, currentFigure.Y1, currentX, currentY,
                                currentLineColor, currentFillColor, currentLineWidth, isFillingEnabled, this.BackColor);
                            break;
                        case FigureType.Line:
                            currentFigure = new Line(currentFigure.X1, currentFigure.Y1, currentX, currentY,
                                currentLineColor, currentLineWidth, this.BackColor);
                            break;
                    }
                }
                Invalidate();
            }
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                if (currentFigureType != FigureType.FreeLine && currentFigure != null)
                {
                    int left = Math.Min(currentFigure.X1, currentFigure.X2);
                    int top = Math.Min(currentFigure.Y1, currentFigure.Y2);
                    int right = Math.Max(currentFigure.X1, currentFigure.X2);
                    int bottom = Math.Max(currentFigure.Y1, currentFigure.Y2);

                    if (left >= 0 && top >= 0 && right <= pictureSize.Width && bottom <= pictureSize.Height)
                    {
                        figures.Add(currentFigure);
                        isModified = true;
                    }
                }
                else if (currentFigureType == FigureType.FreeLine && currentFreeLine != null)
                {
                    figures.Add(currentFreeLine);
                    isModified = true;
                }

                currentFigure = null;
                currentFreeLine = null;
                isDrawing = false;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.TranslateTransform(AutoScrollPosition.X, AutoScrollPosition.Y);

            g.Clear(SystemColors.ControlDark);

            using (SolidBrush whiteBrush = new SolidBrush(Color.White))
            {
                g.FillRectangle(whiteBrush, 0, 0, pictureSize.Width, pictureSize.Height);
            }

            foreach (Figure fig in figures)
            {
                fig.Draw(g);
            }

            if (isDrawing && currentFigure != null)
            {
                currentFigure.DrawDash(g);
            }
        }

        public static Tuple<Size, List<Figure>> LoadFromFile(string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                return (Tuple<Size, List<Figure>>)formatter.Deserialize(stream);
            }
        }

        public void SaveToFile(string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                var saveData = Tuple.Create(pictureSize, figures);
                formatter.Serialize(stream, saveData);
            }
            currentFilePath = fileName;
            isModified = false;
            this.Text = Path.GetFileName(fileName);
        }

        public void Save()
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                SaveAs();
            }
            else
            {
                SaveToFile(currentFilePath);
            }
        }

        public void SaveAs()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = Environment.CurrentDirectory;
            dialog.Filter = "Рисунки (*.fig)|*.fig|Все файлы (*.*)|*.*";
            dialog.DefaultExt = "fig";
            dialog.AddExtension = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = dialog.FileName;
                SaveToFile(currentFilePath);
                this.Text = Path.GetFileName(currentFilePath);
            }
        }

        public void ExportAsPNG()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = Environment.CurrentDirectory;
            dialog.Filter = "PNG изображение (*.png)|*.png";
            dialog.DefaultExt = "png";
            dialog.AddExtension = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (Bitmap bitmap = new Bitmap(pictureSize.Width, pictureSize.Height))
                {
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        g.Clear(Color.White);
                        foreach (Figure fig in figures)
                        {
                            fig.Draw(g);
                        }
                    }
                    bitmap.Save(dialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                }
                MessageBox.Show("Экспорт завершен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (isModified)
            {
                DialogResult result = MessageBox.Show("Сохранить изменения?", "Закрытие документа",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    Save();
                else if (result == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }
    }
}