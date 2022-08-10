namespace TastaturUndMaus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_input_KeyDown(object sender, KeyEventArgs e)
        {
            lbl_input.Text = "KeyDown, Code: " + e.KeyCode +
                             ", Value: " + e.KeyValue +
                             ", Alt: " + e.Alt +
                             ", Control: " + e.Control +
                             ", Shift: " + e.Shift;

            if (e.KeyCode == Keys.Return)
                lbl_input.Text += ", Return";
            else if (e.KeyCode == Keys.Delete)
                lbl_input.Text += ", Delete";
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lbl_mouse.Text = "MouseDown, X: " + e.X +
                             ", Y: " + e.Y +
                             ", Button: " + e.Button +
                             ", Clicks: " + e.Clicks;
        }
    }
}