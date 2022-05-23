namespace WinFormsApp8
{
    public partial class Form1 : Form
    { Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        
            private void button1_MouseHover(object sender, EventArgs e)
            {
                int x = rand.Next(480);
                int y = rand.Next(480);
                button1.Location = new Point(x, y);
            }
       
    }
}