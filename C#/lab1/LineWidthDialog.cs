using System;
using System.Windows.Forms;

namespace lab1
{
    public partial class LineWidthDialog : Form
    {
        public LineWidthDialog()
        {
            InitializeComponent();

            comboBoxWidth.Items.Clear();
            comboBoxWidth.Items.Add(1);
            comboBoxWidth.Items.Add(2);
            comboBoxWidth.Items.Add(5);
            comboBoxWidth.Items.Add(8);
            comboBoxWidth.Items.Add(10);
            comboBoxWidth.Items.Add(12);
            comboBoxWidth.Items.Add(15);

            comboBoxWidth.SelectedIndex = 0;
        }

        public int SelectedWidth
        {
            get
            {
                return Convert.ToInt32(comboBoxWidth.Text);
            }
        }

        public int WidthValue
        {
            get => Convert.ToInt32(comboBoxWidth.Text);
            set => comboBoxWidth.Text = value.ToString();
        }
    }
}
