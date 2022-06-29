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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            BackgroundImage = Image.FromFile(@"71R5y3NAQSL.jpg");
            this.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Image =  Image.FromFile(@"C:\Users\Administrator\Pictures\forestfloor.jpg");
        }
    }
}
