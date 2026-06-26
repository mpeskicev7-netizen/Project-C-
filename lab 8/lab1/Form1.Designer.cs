namespace lab1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Меню
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортPNGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветЛинииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветФонаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem толщинаЛинииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерРисункаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фигураToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прямоугольникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эллипсToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem линияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem криваяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заливкаToolStripMenuItem;

        // Панель инструментов
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonNew;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonWidth;
        private System.Windows.Forms.ToolStripButton toolStripButtonLineColor;
        private System.Windows.Forms.ToolStripButton toolStripButtonFillColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonSize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonRect;
        private System.Windows.Forms.ToolStripButton toolStripButtonEllipse;
        private System.Windows.Forms.ToolStripButton toolStripButtonLine;
        private System.Windows.Forms.ToolStripButton toolStripButtonFreeLine;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonFill;

        // Строка состояния
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusCoord;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusSize;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLineWidth;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLineColor;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusFillColor;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusFigure;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusFill;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортPNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветЛинииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветФонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.толщинаЛинииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерРисункаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фигураToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прямоугольникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эллипсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.линияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.криваяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заливкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonWidth = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLineColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFillColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSize = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRect = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEllipse = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFreeLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonFill = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusCoord = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLineWidth = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLineColor = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusFillColor = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusFigure = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusFill = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.параметрыToolStripMenuItem,
            this.фигураToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1095, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.экспортPNGToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новыйToolStripMenuItem
            // 
            this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            this.новыйToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.новыйToolStripMenuItem.Text = "Новый";
            this.новыйToolStripMenuItem.Click += new System.EventHandler(this.новыйToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // экспортPNGToolStripMenuItem
            // 
            this.экспортPNGToolStripMenuItem.Name = "экспортPNGToolStripMenuItem";
            this.экспортPNGToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.экспортPNGToolStripMenuItem.Text = "Экспорт как PNG";
            this.экспортPNGToolStripMenuItem.Click += new System.EventHandler(this.экспортPNGToolStripMenuItem_Click);
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветЛинииToolStripMenuItem,
            this.цветФонаToolStripMenuItem,
            this.толщинаЛинииToolStripMenuItem,
            this.размерРисункаToolStripMenuItem});
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.параметрыToolStripMenuItem.Text = "Параметры";
            // 
            // цветЛинииToolStripMenuItem
            // 
            this.цветЛинииToolStripMenuItem.Name = "цветЛинииToolStripMenuItem";
            this.цветЛинииToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.цветЛинииToolStripMenuItem.Text = "Цвет линии";
            this.цветЛинииToolStripMenuItem.Click += new System.EventHandler(this.цветЛинииToolStripMenuItem_Click);
            // 
            // цветФонаToolStripMenuItem
            // 
            this.цветФонаToolStripMenuItem.Name = "цветФонаToolStripMenuItem";
            this.цветФонаToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.цветФонаToolStripMenuItem.Text = "Цвет заливки";
            this.цветФонаToolStripMenuItem.Click += new System.EventHandler(this.цветФонаToolStripMenuItem_Click);
            // 
            // толщинаЛинииToolStripMenuItem
            // 
            this.толщинаЛинииToolStripMenuItem.Name = "толщинаЛинииToolStripMenuItem";
            this.толщинаЛинииToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.толщинаЛинииToolStripMenuItem.Text = "Толщина линии";
            this.толщинаЛинииToolStripMenuItem.Click += new System.EventHandler(this.толщинаЛинииToolStripMenuItem_Click);
            // 
            // размерРисункаToolStripMenuItem
            // 
            this.размерРисункаToolStripMenuItem.Name = "размерРисункаToolStripMenuItem";
            this.размерРисункаToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.размерРисункаToolStripMenuItem.Text = "Размер рисунка";
            this.размерРисункаToolStripMenuItem.Click += new System.EventHandler(this.размерРисункаToolStripMenuItem_Click);
            // 
            // фигураToolStripMenuItem
            // 
            this.фигураToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прямоугольникToolStripMenuItem,
            this.эллипсToolStripMenuItem,
            this.линияToolStripMenuItem,
            this.криваяToolStripMenuItem,
            this.заливкаToolStripMenuItem});
            this.фигураToolStripMenuItem.Name = "фигураToolStripMenuItem";
            this.фигураToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.фигураToolStripMenuItem.Text = "Фигура";
            // 
            // прямоугольникToolStripMenuItem
            // 
            this.прямоугольникToolStripMenuItem.Name = "прямоугольникToolStripMenuItem";
            this.прямоугольникToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.прямоугольникToolStripMenuItem.Text = "Прямоугольник";
            this.прямоугольникToolStripMenuItem.Click += new System.EventHandler(this.прямоугольникToolStripMenuItem_Click);
            // 
            // эллипсToolStripMenuItem
            // 
            this.эллипсToolStripMenuItem.Name = "эллипсToolStripMenuItem";
            this.эллипсToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.эллипсToolStripMenuItem.Text = "Эллипс";
            this.эллипсToolStripMenuItem.Click += new System.EventHandler(this.эллипсToolStripMenuItem_Click);
            // 
            // линияToolStripMenuItem
            // 
            this.линияToolStripMenuItem.Name = "линияToolStripMenuItem";
            this.линияToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.линияToolStripMenuItem.Text = "Линия";
            this.линияToolStripMenuItem.Click += new System.EventHandler(this.линияToolStripMenuItem_Click);
            // 
            // криваяToolStripMenuItem
            // 
            this.криваяToolStripMenuItem.Name = "криваяToolStripMenuItem";
            this.криваяToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.криваяToolStripMenuItem.Text = "Кривая";
            this.криваяToolStripMenuItem.Click += new System.EventHandler(this.криваяToolStripMenuItem_Click);
            // 
            // заливкаToolStripMenuItem
            // 
            this.заливкаToolStripMenuItem.Name = "заливкаToolStripMenuItem";
            this.заливкаToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.заливкаToolStripMenuItem.Text = "Заливка";
            this.заливкаToolStripMenuItem.Click += new System.EventHandler(this.заливкаToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNew,
            this.toolStripButtonOpen,
            this.toolStripButtonSave,
            this.toolStripSeparator1,
            this.toolStripButtonWidth,
            this.toolStripButtonLineColor,
            this.toolStripButtonFillColor,
            this.toolStripSeparator2,
            this.toolStripButtonSize,
            this.toolStripSeparator3,
            this.toolStripButtonRect,
            this.toolStripButtonEllipse,
            this.toolStripButtonLine,
            this.toolStripButtonFreeLine,
            this.toolStripSeparator4,
            this.toolStripButtonFill});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1095, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNew
            // 
            this.toolStripButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNew.Image")));
            this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNew.Name = "toolStripButtonNew";
            this.toolStripButtonNew.Size = new System.Drawing.Size(69, 24);
            this.toolStripButtonNew.Text = "Новый";
            this.toolStripButtonNew.Click += new System.EventHandler(this.toolStripButtonNew_Click);
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(78, 24);
            this.toolStripButtonOpen.Text = "Открыть";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(89, 24);
            this.toolStripButtonSave.Text = "Сохранить";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonWidth
            // 
            this.toolStripButtonWidth.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonWidth.Image")));
            this.toolStripButtonWidth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonWidth.Name = "toolStripButtonWidth";
            this.toolStripButtonWidth.Size = new System.Drawing.Size(83, 24);
            this.toolStripButtonWidth.Text = "Толщина";
            this.toolStripButtonWidth.Click += new System.EventHandler(this.toolStripButtonWidth_Click);
            // 
            // toolStripButtonLineColor
            // 
            this.toolStripButtonLineColor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLineColor.Image")));
            this.toolStripButtonLineColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLineColor.Name = "toolStripButtonLineColor";
            this.toolStripButtonLineColor.Size = new System.Drawing.Size(95, 24);
            this.toolStripButtonLineColor.Text = "Цвет линии";
            this.toolStripButtonLineColor.Click += new System.EventHandler(this.toolStripButtonLineColor_Click);
            // 
            // toolStripButtonFillColor
            // 
            this.toolStripButtonFillColor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFillColor.Image")));
            this.toolStripButtonFillColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFillColor.Name = "toolStripButtonFillColor";
            this.toolStripButtonFillColor.Size = new System.Drawing.Size(104, 24);
            this.toolStripButtonFillColor.Text = "Цвет заливки";
            this.toolStripButtonFillColor.Click += new System.EventHandler(this.toolStripButtonFillColor_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonSize
            // 
            this.toolStripButtonSize.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSize.Image")));
            this.toolStripButtonSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSize.Name = "toolStripButtonSize";
            this.toolStripButtonSize.Size = new System.Drawing.Size(71, 24);
            this.toolStripButtonSize.Text = "Размер";
            this.toolStripButtonSize.Click += new System.EventHandler(this.toolStripButtonSize_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonRect
            // 
            this.toolStripButtonRect.CheckOnClick = true;
            this.toolStripButtonRect.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRect.Image")));
            this.toolStripButtonRect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRect.Name = "toolStripButtonRect";
            this.toolStripButtonRect.Size = new System.Drawing.Size(120, 24);
            this.toolStripButtonRect.Text = "Прямоугольник";
            this.toolStripButtonRect.Click += new System.EventHandler(this.toolStripButtonRect_Click);
            // 
            // toolStripButtonEllipse
            // 
            this.toolStripButtonEllipse.CheckOnClick = true;
            this.toolStripButtonEllipse.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEllipse.Image")));
            this.toolStripButtonEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEllipse.Name = "toolStripButtonEllipse";
            this.toolStripButtonEllipse.Size = new System.Drawing.Size(72, 24);
            this.toolStripButtonEllipse.Text = "Эллипс";
            this.toolStripButtonEllipse.Click += new System.EventHandler(this.toolStripButtonEllipse_Click);
            // 
            // toolStripButtonLine
            // 
            this.toolStripButtonLine.CheckOnClick = true;
            this.toolStripButtonLine.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLine.Image")));
            this.toolStripButtonLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLine.Name = "toolStripButtonLine";
            this.toolStripButtonLine.Size = new System.Drawing.Size(66, 24);
            this.toolStripButtonLine.Text = "Линия";
            this.toolStripButtonLine.Click += new System.EventHandler(this.toolStripButtonLine_Click);
            // 
            // toolStripButtonFreeLine
            // 
            this.toolStripButtonFreeLine.CheckOnClick = true;
            this.toolStripButtonFreeLine.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFreeLine.Image")));
            this.toolStripButtonFreeLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFreeLine.Name = "toolStripButtonFreeLine";
            this.toolStripButtonFreeLine.Size = new System.Drawing.Size(70, 24);
            this.toolStripButtonFreeLine.Text = "Кривая";
            this.toolStripButtonFreeLine.Click += new System.EventHandler(this.toolStripButtonFreeLine_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonFill
            // 
            this.toolStripButtonFill.CheckOnClick = true;
            this.toolStripButtonFill.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFill.Image")));
            this.toolStripButtonFill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFill.Name = "toolStripButtonFill";
            this.toolStripButtonFill.Size = new System.Drawing.Size(76, 24);
            this.toolStripButtonFill.Text = "Заливка";
            this.toolStripButtonFill.Click += new System.EventHandler(this.toolStripButtonFill_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusCoord,
            this.toolStripStatusSize,
            this.toolStripStatusLineWidth,
            this.toolStripStatusLineColor,
            this.toolStripStatusFillColor,
            this.toolStripStatusFigure,
            this.toolStripStatusFill});
            this.statusStrip1.Location = new System.Drawing.Point(0, 646);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1095, 24);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusCoord
            // 
            this.toolStripStatusCoord.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusCoord.Name = "toolStripStatusCoord";
            this.toolStripStatusCoord.Size = new System.Drawing.Size(103, 19);
            this.toolStripStatusCoord.Text = "Координаты: 0, 0";
            // 
            // toolStripStatusSize
            // 
            this.toolStripStatusSize.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusSize.Name = "toolStripStatusSize";
            this.toolStripStatusSize.Size = new System.Drawing.Size(98, 19);
            this.toolStripStatusSize.Text = "Размер: 800x600";
            // 
            // toolStripStatusLineWidth
            // 
            this.toolStripStatusLineWidth.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLineWidth.Name = "toolStripStatusLineWidth";
            this.toolStripStatusLineWidth.Size = new System.Drawing.Size(75, 19);
            this.toolStripStatusLineWidth.Text = "Толщина: 1";
            // 
            // toolStripStatusLineColor
            // 
            this.toolStripStatusLineColor.BackColor = System.Drawing.Color.Black;
            this.toolStripStatusLineColor.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLineColor.Name = "toolStripStatusLineColor";
            this.toolStripStatusLineColor.Size = new System.Drawing.Size(32, 19);
            this.toolStripStatusLineColor.Text = "       ";
            // 
            // toolStripStatusFillColor
            // 
            this.toolStripStatusFillColor.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusFillColor.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusFillColor.Name = "toolStripStatusFillColor";
            this.toolStripStatusFillColor.Size = new System.Drawing.Size(32, 19);
            this.toolStripStatusFillColor.Text = "       ";
            // 
            // toolStripStatusFigure
            // 
            this.toolStripStatusFigure.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusFigure.Name = "toolStripStatusFigure";
            this.toolStripStatusFigure.Size = new System.Drawing.Size(146, 19);
            this.toolStripStatusFigure.Text = "Фигура: Прямоугольник";
            // 
            // toolStripStatusFill
            // 
            this.toolStripStatusFill.Name = "toolStripStatusFill";
            this.toolStripStatusFill.Size = new System.Drawing.Size(87, 19);
            this.toolStripStatusFill.Text = "Заливка: Выкл";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "document.png");
            this.imageList1.Images.SetKeyName(1, "icons8-палитра-50.png");
            this.imageList1.Images.SetKeyName(2, "icons8-прямоугольник-50.png");
            this.imageList1.Images.SetKeyName(3, "icons8-эллипс-50.png");
            this.imageList1.Images.SetKeyName(4, "icons8-линия-50.png");
            this.imageList1.Images.SetKeyName(5, "icons8-волнистая-линия-50.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 670);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Рисовалка MDI";
            this.MdiChildActivate += new System.EventHandler(this.Form1_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ImageList imageList1;
    }
}