using System;
using System.Collections.Generic;

namespace Tiket
{
    //Menggunakan Inheritance
    class vaksin
    {
        public void yukvaksin()
        {
            Console.WriteLine("Alamat Kantor  : Toko Lestari");
            Console.WriteLine("Vaksin Ke-3    : Belum");
        }
    }
    //Menggunakan Polymorphism
    class Ticket
    {
        private void Selamat()
        {
        }

        public virtual void start()
        {
            Selamat();
        }
    }

    //Menggunakan abstract class
    abstract class loket
    {
        public abstract void ll();
        public abstract void dd();

    }

    //Menggunakan Generic class
    class Datadiri<T>
    {
        public T value;
        public Datadiri(T parameter)
        {
            this.value = parameter;
        }
    }

    //Class program
    class Program
    {
        static void Main(string[] args)
        {

            Menu menu = new Menu();
            menu.Sela();

        }
    }
}