namespace Gravity_Impact
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void pressEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
        }
    }
}
