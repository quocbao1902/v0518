namespace v0518
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button1.Left = 0;
            button1.Left = button1.Left + 10;
            button1.Top = button1.Top + 10;
            button1.Text = "çsèH";
            button1.BackColor = Color.LightSkyBlue;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Left = button2.Left - 10;
            button2.Top = button2.Top - 10;
            button2.Text = "ÉiÉqÅ[É_";
            button2.BackColor = Color.LightSeaGreen;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Left = button3.Left - 10;
            button3.Top = button3.Top + 10;
            button3.Text = "ã„ãSîE";
            button3.BackColor = Color.MediumPurple;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Left = button4.Left + 10;
            button4.Top = button4.Top - 10;
            button4.Text = "ó∑êl";
            button4.BackColor = Color.LightYellow;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}