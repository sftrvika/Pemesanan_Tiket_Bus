using System;
using System.Collections.Generic;
using System.Text;

namespace Tiket
{
    //turunan dari Polymorphism pada class Ticket
    //kami menggunkaan dua class yaitu BusJogtem dan Aman untuk turunan class Ticket 
    class BusJogtem : Ticket
    {
        //menampung method virtual void start() pada class Ticket
        public override void start()
        {
            Console.WriteLine("=============");
            Console.WriteLine("SUMBER MAKMUR");
            Console.WriteLine("=============");
            base.start();
            brum();
        }
        //method sendiri pada class BusJogtem
        private void brum()
        {
            Console.WriteLine("Jogja-Solo       = Rp.200.000");
            Console.WriteLine("Jogja-Semarang   = Rp.300.000");
            Console.WriteLine("Jogja-Magelang   = Rp.150.000");
        }

    }

    class Aman : Ticket
    {
        public override void start()
        {
            Console.WriteLine("==============");
            Console.WriteLine("SUMBER KENCONO");
            Console.WriteLine("==============");
            base.start();
            brum1();
        }

        private void brum1()
        {
            Console.WriteLine("Jogja-Solo       = Rp.250.000");
            Console.WriteLine("Jogja-Semarang   = Rp.350.000");
            Console.WriteLine("Jogja-Magelang   = Rp.200.000");
        }

    }

}