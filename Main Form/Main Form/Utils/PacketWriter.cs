﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Form
{
 
    class PacketWriter
    {
        public static byte[] sendString(string msg)
        {
            byte[] data = Encoding.ASCII.GetBytes(msg);
            return data;
        }
    }


}
