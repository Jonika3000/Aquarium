using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            BackgroundImage = Image.FromFile(@"71R5y3NAQSL.jpg");
            this.BackgroundImageLayout = ImageLayout.Zoom;
            button1.BackgroundImage = System.Drawing.Image.FromFile(@"close-exit-stop-button-icon-95968.png");
            button1.Text = "";
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Click += button1_Click;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }
    }
}
