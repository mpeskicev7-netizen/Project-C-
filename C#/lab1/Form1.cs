using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace lab1
{
    public enum FigureType
    {
        Rectangle,
        Ellipse,
        Line,
        FreeLine
    }

    public partial class Form1 : Form
    {
        private Color currentLineColor = Color.Black;
        private Color currentFillColor = Color.Transparent;
        private int currentLineWidth = 1;
        private Size currentPictureSize = new Size(800, 600);
        private FigureType currentFigureType = FigureType.Rectangle;
        private bool fillEnabled = false;

        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }


        public void UpdateStatusBarCoordinates(int x, int y)
        {
            toolStripStatusCoord.Text = $"Координаты: {x}, {y}";
        }

        public void UpdateStatusBarSize(int width, int height)
        {
            toolStripStatusSize.Text = $"Размер: {width}x{height}";
        }

        public void UpdateStatusBarLineWidth(int width)
        {
            toolStripStatusLineWidth.Text = $"Толщина: {width}";
        }

        public void UpdateStatusBarLineColor(Color color)
        {
            toolStripStatusLineColor.BackColor = color;
            toolStripStatusLineColor.Text = "       ";
        }

        public void UpdateStatusBarFillColor(Color color)
        {
            toolStripStatusFillColor.BackColor = color;
            toolStripStatusFillColor.Text = "       ";
        }

        public void UpdateStatusBarFigureType(FigureType type)
        {
            string figureName = "";
            switch (type)
            {
                case FigureType.Rectangle: figureName = "Прямоугольник"; break;
                case FigureType.Ellipse: figureName = "Эллипс"; break;
                case FigureType.Line: figureName = "Линия"; break;
                case FigureType.FreeLine: figureName = "Кривая"; break;
            }
            toolStripStatusFigure.Text = $"Фигура: {figureName}";
        }

        public void UpdateStatusBarFill(bool enabled)
        {
            toolStripStatusFill.Text = enabled ? "Заливка: Вкл" : "Заливка: Выкл";
        }

        public void UpdateStatusBar()
        {
            UpdateStatusBarLineColor(currentLineColor);
            UpdateStatusBarFillColor(currentFillColor);
            UpdateStatusBarLineWidth(currentLineWidth);
            UpdateStatusBarFigureType(currentFigureType);
            UpdateStatusBarFill(fillEnabled);
        }


        public void UpdateAllChildSettings()
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is Form2 form2)
                {
                    form2.UpdateSettings(currentLineColor, currentFillColor, currentLineWidth,
                        currentFigureType, fillEnabled);
                }
            }
            UpdateStatusBar();
        }


        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 child = new Form2(currentPictureSize, currentLineColor, currentFillColor,
                currentLineWidth, currentFigureType, fillEnabled);
            child.MdiParent = this;
            child.Show();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Environment.CurrentDirectory;
            dialog.Filter = "Рисунки (*.fig)|*.fig|Все файлы (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var loadedData = Form2.LoadFromFile(dialog.FileName);

                Form2 child = new Form2(loadedData, currentLineColor, currentFillColor,
                    currentLineWidth, currentFigureType, fillEnabled);
                child.MdiParent = this;
                child.currentFilePath = dialog.FileName;
                child.Text = Path.GetFileName(dialog.FileName);
                child.isModified = false;
                child.Show();
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is Form2 child)
                child.Save();
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is Form2 child)
                child.SaveAs();
        }

        private void экспортPNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is Form2 child)
                child.ExportAsPNG();
        }

        private void Form1_MdiChildActivate(object sender, EventArgs e)
        {
            bool hasChild = (this.ActiveMdiChild != null);
            сохранитьToolStripMenuItem.Enabled = hasChild;
            сохранитьКакToolStripMenuItem.Enabled = hasChild;
            экспортPNGToolStripMenuItem.Enabled = hasChild;

            if (hasChild && ActiveMdiChild is Form2 form2)
            {
                form2.UpdateStatusBar();
            }
        }


        private void цветЛинииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = currentLineColor;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                currentLineColor = dialog.Color;
                UpdateAllChildSettings();
            }
        }

        private void цветФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = currentFillColor;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                currentFillColor = dialog.Color;
                UpdateAllChildSettings();
            }
        }

        private void толщинаЛинииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LineWidthDialog dialog = new LineWidthDialog();
            dialog.WidthValue = currentLineWidth;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                currentLineWidth = dialog.SelectedWidth;
                UpdateAllChildSettings();
            }
        }

        private void размерРисункаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SizeDialog dialog = new SizeDialog();
            dialog.SetCurrentSize(currentPictureSize);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                currentPictureSize = dialog.SelectedSize;
            }
        }


        private void прямоугольникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetFigureType(FigureType.Rectangle);
        }

        private void эллипсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetFigureType(FigureType.Ellipse);
        }

        private void линияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetFigureType(FigureType.Line);
        }

        private void криваяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetFigureType(FigureType.FreeLine);
        }

        private void заливкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleFill();
        }


        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            новыйToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            открытьToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            сохранитьToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButtonWidth_Click(object sender, EventArgs e)
        {
            толщинаЛинииToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButtonLineColor_Click(object sender, EventArgs e)
        {
            цветЛинииToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButtonFillColor_Click(object sender, EventArgs e)
        {
            цветФонаToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButtonSize_Click(object sender, EventArgs e)
        {
            размерРисункаToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButtonRect_Click(object sender, EventArgs e)
        {
            SetFigureType(FigureType.Rectangle);
        }

        private void toolStripButtonEllipse_Click(object sender, EventArgs e)
        {
            SetFigureType(FigureType.Ellipse);
        }

        private void toolStripButtonLine_Click(object sender, EventArgs e)
        {
            SetFigureType(FigureType.Line);
        }

        private void toolStripButtonFreeLine_Click(object sender, EventArgs e)
        {
            SetFigureType(FigureType.FreeLine);
        }

        private void toolStripButtonFill_Click(object sender, EventArgs e)
        {
            ToggleFill();
        }

        private void UpdateButtonGroup()
        {
            toolStripButtonRect.Checked = (currentFigureType == FigureType.Rectangle);
            toolStripButtonEllipse.Checked = (currentFigureType == FigureType.Ellipse);
            toolStripButtonLine.Checked = (currentFigureType == FigureType.Line);
            toolStripButtonFreeLine.Checked = (currentFigureType == FigureType.FreeLine);
        }

        private void SetFigureType(FigureType type)
        {
            currentFigureType = type;

            прямоугольникToolStripMenuItem.Checked = (type == FigureType.Rectangle);
            эллипсToolStripMenuItem.Checked = (type == FigureType.Ellipse);
            линияToolStripMenuItem.Checked = (type == FigureType.Line);
            криваяToolStripMenuItem.Checked = (type == FigureType.FreeLine);

            toolStripButtonRect.Checked = (type == FigureType.Rectangle);
            toolStripButtonEllipse.Checked = (type == FigureType.Ellipse);
            toolStripButtonLine.Checked = (type == FigureType.Line);
            toolStripButtonFreeLine.Checked = (type == FigureType.FreeLine);

            UpdateAllChildSettings();
        }

        private void ToggleFill()
        {
            fillEnabled = !fillEnabled;

            заливкаToolStripMenuItem.Checked = fillEnabled;

            toolStripButtonFill.Checked = fillEnabled;

            UpdateAllChildSettings();
        }
    }
}