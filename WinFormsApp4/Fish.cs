using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    public class Fish
    {
        public int Status { get; set; }
        public int Count { get; set; }
        public int MaxCount { get; set; }
        public Fish(int obj_status,int obj_count)
        {
            Status = obj_status;
            Count = obj_count;
            if (obj_status == 1)
                MaxCount = 2;
            else if(obj_status == 2 || obj_status == 3)
                MaxCount = 3;

        }
    }
}
