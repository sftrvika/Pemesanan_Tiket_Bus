using System;
using System.Collections.Generic;
using System.Text;

namespace Tiket
{
    //class turunan dari abstarck class loket
    class DD : loket
    {
        public override void ll()
        {
            Console.WriteLine("");
            Console.WriteLine("===============================");
            Console.WriteLine("  Tujuan anda adalah JOGJA-SOLO");
            Console.WriteLine("        BIS SUMBER MAKMUR");
            Console.WriteLine("===============================");
        }
        public override void dd()
        {
            Console.WriteLine("");
            Console.WriteLine("===================================");
            Console.WriteLine("  Tujuan anda adalah JOGJA-SEMARANG");
            Console.WriteLine("        BIS SUMBER KENCONO");
            Console.WriteLine("===================================");
        }

    }

    //class turunan dari class vaksin
    class vaksin2 : vaksin
    {
        public void yukvaksin()
        {
            Console.WriteLine("Alamat Kantor  : Indomaret");
            Console.WriteLine("Vaksin Ke-3    : Sudah");
        }
    }
}