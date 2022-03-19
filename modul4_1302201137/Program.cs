// See https://aka.ms/new-console-template for more information
using System;
using System.Text;
using System.Linq;


using System.Threading.Tasks;
using System.Collections.Generic;


namespace modul4_1302201137
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Penjumlahan<int> Hitung = new Penjumlahan<int>();

            int x = 13;
            int y = 02;
            int z = 20;


            int Total = x + y + z;

            Hitung.JumlahTigaAngka(Total);
        }
    }


    public class Penjumlahan<T>
    {
        public void JumlahTigaAngka(T Total)
        {
            Console.WriteLine(Total);
        }
    }

}