﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_103022300101
{
    class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric halo = new HaloGeneric();
            halo.SapaUser("Deru");
        }
    }

    public class HaloGeneric
    {
        public void SapaUser<T>(T user)
        {
            Console.WriteLine($"Halo user {user}");
        }
    }

}
