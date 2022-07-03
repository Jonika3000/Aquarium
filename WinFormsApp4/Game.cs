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
        int FishIndex;
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
            foreach(var b in buttons )
            {
                if (b.Name != "button1")
                b.Click += Move;
            }
        }
        void Move(object sender, EventArgs e )
        {
            Image min1 = Image.FromFile(@"min.png");
            Image ser1 = Image.FromFile(@"ser.png");
            Image max1 = Image.FromFile(@"max.png");
            Button btn = (Button)sender;
            var idx =  buttons.FindIndex(a => a.Name == btn.Name);
            int o = 0;
            
            if (buffer == false)//если ми берем рыбу
            {
                buffer = true;
                if (buttons[idx].BackgroundImage.Size   == min1.Size)
                    FishIndex = 1;
                if (buttons[idx].BackgroundImage.Size == ser1.Size)
                    FishIndex = 2;
                if (buttons[idx].BackgroundImage.Size == max1.Size)
                    FishIndex = 3;
                if (buttons[idx].BackColor == Color.Red)
                {
                    buttons[idx].FlatStyle = FlatStyle.Flat;
                    buttons[idx].BackColor = Color.Transparent;
                    buttons[idx].FlatAppearance.MouseDownBackColor = Color.Transparent;
                    buttons[idx].FlatAppearance.MouseOverBackColor = Color.Transparent;
                }
                    buttons[idx].BackgroundImage = null;
                
            }
            else//еслы ми имеем рыбу
            {
                if (buttons[idx].BackgroundImage.Size == min1.Size)
                    o = 1;
                if (buttons[idx].BackgroundImage.Size == ser1.Size)
                    o = 2;
                if (buttons[idx].BackgroundImage.Size == max1.Size)
                    o = 3;
                if ((buttons[idx].BackColor == Color.Red) && (FishIndex<o))
                {
                    CheckRows(idx);
                    buttons[idx].BackgroundImage = null;
                    buttons[idx].BackColor = Color.Transparent;
                    buffer = false;
                }
                else if (FishIndex < o)
                {
                    buttons[idx].BackColor = Color.Red;
                    buffer = false;
                }
                
                SwitchLevel();
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
                    if (min == 0 && max == 0 && ser ==0)
                    {
                        buttons[bt].BackgroundImage = Image.FromFile(@"max.png");
                        buttons[bt].BackgroundImageLayout = ImageLayout.Stretch;
                        max++;
                        continue;
                    }
                    if (((min < (ser * 2)) || (min < (max * 2))) && fish == 1)
                    {
                        buttons[bt].BackgroundImage = Image.FromFile(@"min.png");
                        buttons[bt].BackgroundImageLayout = ImageLayout.Stretch;
                        min++;

                    }
                    else if (fish == 1)
                        fish++;
                     if ((ser < (max * 2)) && fish == 2)
                    {
                        buttons[bt].BackgroundImage = Image.FromFile(@"ser.png");
                        buttons[bt].BackgroundImageLayout = ImageLayout.Stretch;
                        ser++;

                    }
                    else if(fish == 2)
                        fish++;
                     if  ((ser>=2 || min >=2) && (fish == 3) )
                    {
                        buttons[bt].BackgroundImage = Image.FromFile(@"max.png");
                        buttons[bt].BackgroundImageLayout = ImageLayout.Stretch;
                        max++;

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
            r = r - 6;
            while (r > 0)
            { 
                if (buttons[r].Image== buttons[index].Image)
                {
                    buttons[r].BackgroundImage = null;
                    buttons[r].BackColor = Color.White;
                }
                r = r - 6;
            } 
            
        }
        private void SwitchLevel()
        {
            int count = 0;
            int count1 = 0;
            foreach (Button button in buttons)
            {
                if(button.BackgroundImage == null && button.BackColor == Color.Transparent)
                    count++;
                else if(button.BackgroundImage != null)
                    count1++;
            }
            if (count == 30)
            {
                Level++;
                RandomButtons();
            }
            if(count1 == 1)
            {
                Level++;
                RandomButtons();
            }
        }

        
        
        private void button14_Click(object sender, EventArgs e)
        {

        }
    }
         

        
}
