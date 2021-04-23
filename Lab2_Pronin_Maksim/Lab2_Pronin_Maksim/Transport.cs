using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_Pronin_Maksim
{
    abstract class Transport
    {
        private string name;
        internal double max_speed;
        internal double weidth;
        abstract public void GetInfo();
    }
}
