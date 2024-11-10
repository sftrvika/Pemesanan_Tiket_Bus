using System;
using System.Collections.Generic;
using System.Text;

namespace Tiket
{
    class Alamat
    {
        // ini menggunakan Generic Class
        public string rt;
        public string rw;
        public string kecamatan;
        public string kabupaten;
        public string provinsi;

        public Alamat(string rt, string rw, string kecamatan, string kabupaten, string provinsi)
        {
            this.rt = rt;
            this.rw = rw;
            this.kecamatan = kecamatan;
            this.kabupaten = kabupaten;
            this.provinsi = provinsi;
        }
    }

    class Nasabah
    {
        // ini menggunakan Generic Classpublic string rt;
        public string nama;
        public string alamatRumah;
        public string NomorHp;
        public long nik;

        public Nasabah(string nama, string alamatRumah, string NomorHp, long nik)
        {
            this.nama = nama;
            this.alamatRumah = alamatRumah;
            this.NomorHp = NomorHp;
            this.nik = nik;
        }
    }
}