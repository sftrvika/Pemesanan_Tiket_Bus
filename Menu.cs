using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tiket
{
    //Tampilan untuk menu
    class Menu
    {
        private int pilih;

        public void Sela()
        {
            //Memilih menu
            Console.WriteLine("===============");
            Console.WriteLine("|| MENU TIKET||");
            Console.WriteLine("===============");
            Console.WriteLine("1. Pemesanan Tiket Bus");
            Console.WriteLine("2. Info Harga Tiket");
            Console.WriteLine("3. Exit");
            Console.WriteLine("PILIH = ");
            pilih = int.Parse(Console.ReadLine());
            if (pilih == 1)//jika memilih 1 maka akan...
            {
                //Membaca dari Class DD pada method ll
                DD dd = new DD();
                dd.ll();
                //Membaca dari Class Nasabah dengan menginputkan nama, alamat rumah, nomor telepon, nik
                Console.WriteLine("Data diri: ");
                Nasabah nasabah = new Nasabah("Vika", "Bantul", "0899797991", 899798686);
                Datadiri<Nasabah> nasabah1 = new Datadiri<Nasabah>(nasabah);
                Console.WriteLine("nama           : {0}" + Environment.NewLine + "Alamat Rumah   : {1}" + Environment.NewLine +
                "Nomor Hp       : {2}" + Environment.NewLine + "nik            : {3}"
                , nasabah1.value.nama, nasabah1.value.alamatRumah, nasabah1.value.NomorHp, nasabah1.value.nik);
                //Membaca dari class vaksin 
                vaksin datavaksin1 = new vaksin();
                datavaksin1.yukvaksin();
                //Membaca dari class alamat
                Alamat alamat = new Alamat("12", "13", "Tritenggo", "Bantul", "DIY");
                Datadiri<Alamat> alamat1 = new Datadiri<Alamat>(alamat);
                Console.WriteLine("rt             : {0}" + Environment.NewLine + "rw             : {1}" + Environment.NewLine + "kecamatan      : {2}" + Environment.NewLine +
                "kabupaten      : {3}" + Environment.NewLine + "provinsi       : {4}"
                , alamat1.value.rt, alamat1.value.rw, alamat1.value.kecamatan, alamat1.value.kabupaten, alamat1.value.provinsi);
                Console.WriteLine("");

                DD dd1 = new DD();
                dd1.dd();
                Console.WriteLine("Data diri: ");
                Nasabah nasabahh = new Nasabah("Sri", "Condogcatur", "0876852675", 623466023664);
                Datadiri<Nasabah> nasabah2 = new Datadiri<Nasabah>(nasabahh);
                Console.WriteLine("nama           : {0}" + Environment.NewLine + "Alamat Rumah   : {1}" + Environment.NewLine +
                "Nomor Hp       : {2}" + Environment.NewLine + "nik            : {3}"
                , nasabah2.value.nama, nasabah2.value.alamatRumah, nasabah2.value.NomorHp, nasabah2.value.nik);
                vaksin2 datavaksin2 = new vaksin2();
                datavaksin2.yukvaksin();

                Alamat alamatt = new Alamat("02", "10", "Depok", "Sleman", "DIY");
                Datadiri<Alamat> alamat2 = new Datadiri<Alamat>(alamatt);
                Console.WriteLine("rt             : {0}" + Environment.NewLine + "rw             : {1}" + Environment.NewLine + "kecamatan      : {2}" + Environment.NewLine +
                "kabupaten      : {3}" + Environment.NewLine + "provinsi       : {4}"
                , alamat2.value.rt, alamat2.value.rw, alamat2.value.kecamatan, alamat2.value.kabupaten, alamat2.value.provinsi);
                Console.WriteLine("");


            }//jika memilih 2 maka akan...
            else if (pilih == 2)
            {
                //Membaca dari class BusJogtem pada method start()
                Ticket tiket = new BusJogtem();
                tiket.start();
                Console.WriteLine("");
                //Membaca dari class Aman pada method start()
                Ticket tiket1 = new Aman();
                tiket1.start();
            }//jika memilih 3 maka akan keluar
            else if (pilih == 3)
            {

            }
        }
    }
}