using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab1
{
    public partial class SizeDialog : Form
    {
        public Size SelectedSize { get; private set; }

        public SizeDialog()
        {
            InitializeComponent();
        }

        public void SetCurrentSize(Size size)
        {
            if (size.Width == 320 && size.Height == 240)
                radio320.Checked = true;
            else if (size.Width == 640 && size.Height == 480)
                radio640.Checked = true;
            else if (size.Width == 800 && size.Height == 600)
                radio800.Checked = true;
            else
            {
                checkCustom.Checked = true;
                textWidth.Text = size.Width.ToString();
                textHeight.Text = size.Height.ToString();
            }
        }

        private void checkCustom_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxCustom.Enabled = checkCustom.Checked;
            radio320.Enabled = !checkCustom.Checked;
            radio640.Enabled = !checkCustom.Checked;
            radio800.Enabled = !checkCustom.Checked;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (checkCustom.Checked)
            {
                if (int.TryParse(textWidth.Text, out int width) &&
                    int.TryParse(textHeight.Text, out int height) &&
                    width > 0 && height > 0)
                {
                    SelectedSize = new Size(width, height);
                }
                else
                {
                    MessageBox.Show("Введите корректные положительные числа!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.DialogResult = DialogResult.None;
                    return;
                }
            }
            else
            {
                if (radio320.Checked)
                    SelectedSize = new Size(320, 240);
                else if (radio640.Checked)
                    SelectedSize = new Size(640, 480);
                else
                    SelectedSize = new Size(800, 600);
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}