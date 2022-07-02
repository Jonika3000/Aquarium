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
        int Level = 1;
        bool buffer;
        public Game()
        {
            InitializeComponent();
            buttons = new List<Button>() { button2, button3 , button4, button5, button6, button7 ,
                                           button8 , button9 , button10 , button11 , button12 , button13 ,
                                           button14 , button15 , button16 , button17 , button18 , button19 ,
                                           button20 , button21 , button22 , button23 , button24 , button25 , 
                                           button26 , button27 , button28 , button29 , button30 , button31 };
            BackgroundImage = Image.FromFile(@"71R5y3NAQSL.jpg");
            this.BackgroundImageLayout = ImageLayout.Zoom;
            Shown += First;
            button1.BackgroundImage = System.Drawing.Image.FromFile(@"close-exit-stop-button-icon-95968.png");
            button1.Text = "";
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Click += button1_Click;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void First(object sender , EventArgs e)
        {
            RandomButtons();
        }
        void Move(object sender, EventArgs e )
        {
            Button btn = (Button)sender;
            if(buffer == false)//если ми берем рыбу
            {
                buffer = true;
                btn.BackgroundImage = null;
            }
            else//еслы ми имеем рыбу
            {
                if (btn.BackColor == Color.Red)
                {
                    
                }
            }
        }
        private void RandomButtons()
        {
          Random rnd1 = new Random();//
          Random rnd = new Random();//riba
            int max = 0;
            int min = 0;
            int ser = 0;
            int fish_count = 0;
            switch (Level)
            {
                case 1:
                    fish_count= rnd.Next(3,5);
                    break;
                case 2:
                    fish_count=rnd.Next(4, 7);
                    break;
                case 3:
                    fish_count=rnd.Next(7, 10);
                    break;
                case 4:
                    fish_count=rnd.Next(10, 12);
                    break;
                case 5:
                    fish_count=rnd.Next(13, 15);
                    break;
            }
            for (int i =0; i< fish_count; i++)
            {
                int bt=0;
                int fish = rnd.Next(1, 3);
                switch (Level)
                {
                    case 1:
                        bt= rnd1.Next(2, 7);
                        break;
                    case 2:
                        bt=rnd1.Next(8, 13);
                        break;
                    case 3:
                        bt=rnd1.Next(14, 19);
                        break;
                    case 4:
                        bt=rnd1.Next(20, 25);
                        break;
                    case 5:
                        bt=rnd1.Next(26, 31);
                        break;
                }
                if (buttons[bt].BackgroundImage == null)
                {

                    switch (fish)
                    {
                        case 1:
                            if (((ser != 0) || (max != 0)) && ((min < (ser * 2)) || (min < (max * 2))))
                            {
                                buttons[bt].BackgroundImage = Image.FromFile(@"min.png");
                                buttons[bt].BackgroundImageLayout = ImageLayout.Stretch;
                                min++;
                            }
                            else
                            goto A;
                                 break;
                        case 2:
                        A:
                            if (ser < (max * 2))
                            {
                                buttons[bt].BackgroundImage = Image.FromFile(@"ser.png");
                                buttons[bt].BackgroundImageLayout = ImageLayout.Stretch;
                                ser++;
                            }
                            else
                                goto B;
                            break;
                        case 3:
                            B:
                                buttons[bt].BackgroundImage = Image.FromFile(@"max.png");
                                buttons[bt].BackgroundImageLayout = ImageLayout.Stretch;
                                max++;
                            break;
                    }
                }
                else
                    i--;
            }
            
        }
        private void CheckRows(int index)
        {
            int r;
            r = index;
            do
            { 
                r = r - 6;
                if (buttons[r].ImageIndex == index)
                {
                    buttons[r].BackgroundImage = null;
                    buttons[r].BackColor = Color.White;
                }
            }while(r > 0);
            
        }
        private void SwitchLevel()
        {
            int count = 0;
            foreach (Button button in buttons)
            {
                if(button.BackgroundImage == null)
                    count++;
            }
            if(count == 30)
            {
                Level++;
                RandomButtons();            }
        }
        private void button14_Click(object sender, EventArgs e)
        {

        }
    }
         

        
}
