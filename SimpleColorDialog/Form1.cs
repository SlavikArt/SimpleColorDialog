namespace SimpleColorDialog
{
    public partial class Form1 : Form
    {
        private ColorDialog colorDialog1;
        public Form1()
        {
            InitializeComponent();
            colorDialog1 = new ColorDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                BackColor = colorDialog1.Color;
        }
    }
}