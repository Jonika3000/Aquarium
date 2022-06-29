using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace WinFormsApp4
{
    public partial class Form3 : Form
    {
        Timer t;
        DateTime dt = DateTime.Now;
        
        public Form3()
        {
            InitializeComponent();
            
            t = new Timer();
            t.Interval = 1000;
            Shown += Update;
        }
        void Update(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Now.AddSeconds(5.0);
            if (dt < dt1)
            {
                this.Close();
            }
            
        }
    }
}
