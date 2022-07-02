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
        List<Button> buttons;
        public Game()
        {
            InitializeComponent();
            buttons = new List<Button>() { button2, button3 , button4, button5, button6, button7 , button8 , button9,
            button10 , button11 , button12 , button13 , button14 , button15 , button16 , button17 ,
            button18 , button19 , button20 , button21 , button22 , button23 , button24 , button25 , button26 , button27,
            button28 , button29 , button30 , button31 };
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
        private void RandomButtons(object sender , EventArgs e )
        {
          Random rnd1 = new Random();
          Random rnd = new Random();
            rnd1.Next(2, 30);


        }
        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void aye()
        {

        }
    }
}
