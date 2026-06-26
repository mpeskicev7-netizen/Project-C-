namespace lab1
{
    partial class SizeDialog
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupBoxPreset;
        private System.Windows.Forms.RadioButton radio320;
        private System.Windows.Forms.RadioButton radio640;
        private System.Windows.Forms.RadioButton radio800;
        private System.Windows.Forms.CheckBox checkCustom;
        private System.Windows.Forms.GroupBox groupBoxCustom;
        private System.Windows.Forms.TextBox textWidth;
        private System.Windows.Forms.TextBox textHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.groupBoxPreset = new System.Windows.Forms.GroupBox();
            this.radio800 = new System.Windows.Forms.RadioButton();
            this.radio640 = new System.Windows.Forms.RadioButton();
            this.radio320 = new System.Windows.Forms.RadioButton();
            this.checkCustom = new System.Windows.Forms.CheckBox();
            this.groupBoxCustom = new System.Windows.Forms.GroupBox();
            this.textHeight = new System.Windows.Forms.TextBox();
            this.textWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxPreset.SuspendLayout();
            this.groupBoxCustom.SuspendLayout();
            this.SuspendLayout();

            // groupBoxPreset
            this.groupBoxPreset.Controls.Add(this.radio800);
            this.groupBoxPreset.Controls.Add(this.radio640);
            this.groupBoxPreset.Controls.Add(this.radio320);
            this.groupBoxPreset.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPreset.Name = "groupBoxPreset";
            this.groupBoxPreset.Size = new System.Drawing.Size(260, 100);
            this.groupBoxPreset.TabIndex = 0;
            this.groupBoxPreset.TabStop = false;
            this.groupBoxPreset.Text = "Предустановленные размеры";

            // radio320
            this.radio320.AutoSize = true;
            this.radio320.Checked = true;
            this.radio320.Location = new System.Drawing.Point(20, 25);
            this.radio320.Name = "radio320";
            this.radio320.Size = new System.Drawing.Size(85, 21);
            this.radio320.TabIndex = 0;
            this.radio320.TabStop = true;
            this.radio320.Text = "320 x 240";

            // radio640
            this.radio640.AutoSize = true;
            this.radio640.Location = new System.Drawing.Point(20, 52);
            this.radio640.Name = "radio640";
            this.radio640.Size = new System.Drawing.Size(85, 21);
            this.radio640.TabIndex = 1;
            this.radio640.Text = "640 x 480";

            // radio800
            this.radio800.AutoSize = true;
            this.radio800.Location = new System.Drawing.Point(20, 79);
            this.radio800.Name = "radio800";
            this.radio800.Size = new System.Drawing.Size(85, 21);
            this.radio800.TabIndex = 2;
            this.radio800.Text = "800 x 600";

            // checkCustom
            this.checkCustom.AutoSize = true;
            this.checkCustom.Location = new System.Drawing.Point(18, 118);
            this.checkCustom.Name = "checkCustom";
            this.checkCustom.Size = new System.Drawing.Size(108, 21);
            this.checkCustom.TabIndex = 1;
            this.checkCustom.Text = "Свой размер";
            this.checkCustom.CheckedChanged += new System.EventHandler(this.checkCustom_CheckedChanged);

            // groupBoxCustom
            this.groupBoxCustom.Controls.Add(this.textHeight);
            this.groupBoxCustom.Controls.Add(this.textWidth);
            this.groupBoxCustom.Controls.Add(this.label2);
            this.groupBoxCustom.Controls.Add(this.label1);
            this.groupBoxCustom.Enabled = false;
            this.groupBoxCustom.Location = new System.Drawing.Point(12, 145);
            this.groupBoxCustom.Name = "groupBoxCustom";
            this.groupBoxCustom.Size = new System.Drawing.Size(260, 80);
            this.groupBoxCustom.TabIndex = 2;
            this.groupBoxCustom.TabStop = false;
            this.groupBoxCustom.Text = "Пользовательский размер";

            // textHeight
            this.textHeight.Location = new System.Drawing.Point(180, 35);
            this.textHeight.Name = "textHeight";
            this.textHeight.Size = new System.Drawing.Size(60, 22);
            this.textHeight.TabIndex = 3;
            this.textHeight.Text = "600";

            // textWidth
            this.textWidth.Location = new System.Drawing.Point(60, 35);
            this.textWidth.Name = "textWidth";
            this.textWidth.Size = new System.Drawing.Size(60, 22);
            this.textWidth.TabIndex = 2;
            this.textWidth.Text = "800";

            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Высота:";

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ширина:";

            // buttonOK
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(60, 240);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(80, 30);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);

            // buttonCancel
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(150, 240);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(80, 30);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";

            // SizeDialog
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 291);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxCustom);
            this.Controls.Add(this.checkCustom);
            this.Controls.Add(this.groupBoxPreset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
            this.Name = "SizeDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Размер рисунка";
            this.groupBoxPreset.ResumeLayout(false);
            this.groupBoxPreset.PerformLayout();
            this.groupBoxCustom.ResumeLayout(false);
            this.groupBoxCustom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
