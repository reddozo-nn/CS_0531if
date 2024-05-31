namespace CS_0531if
{
    public partial class Form1 : Form
    {
        int vx = -10;
        int vy = -10;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;
            if (label1.Left < 0)
            {
                vx = 15;
            }
            if (label1.Top < 0)
            {
                vy = 15;
            }
            if (label1.Top > 447)
            {
                vy = -15;
            }
            if (label1.Left > 763)
            {
                vy = -15;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}