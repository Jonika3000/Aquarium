namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BackgroundImage = Image.FromFile(@"71R5y3NAQSL.jpg");
            this.BackgroundImageLayout = ImageLayout.Zoom;
            Shown += ButtonLoad;
            button2.Click += button2_Click; 
        }
        void ButtonLoad(object sender , EventArgs e)
        {
            button1.BackColor = Color.Aqua;
            button2.BackColor = Color.Aqua;
            button1.BackgroundImage = System.Drawing.Image.FromFile(@"17550.png");
            button1.Text = "";
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button2.BackgroundImage = System.Drawing.Image.FromFile(@"close-exit-stop-button-icon-95968.png");
            button2.Text = "";
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            //button1.ImageAlign = ContentAlignment.TopCenter;
            //button1.TextAlign = ContentAlignment.MiddleRight;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form3 lf = new Form3();
            //lf.ShowDialog();
            //Game g = new Game();
            //g.ShowDialog();
        }
    }
}