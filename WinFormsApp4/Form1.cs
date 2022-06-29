namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BackgroundImage = Image.FromFile(@"71R5y3NAQSL.jpg");
            this.BackgroundImageLayout = ImageLayout.Zoom;
            //button1.Image = Image.FromFile(@"C:\Users\Administrator\Pictures\forestfloor.jpg");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}