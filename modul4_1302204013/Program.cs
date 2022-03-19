using System;

namespace modul4_1302204013
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Penjumlahan jumlah = new Penjumlahan();
            Console.WriteLine("Masukkan angka pertama: ");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukkan angka kedua: ");
            double y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukkan angka ketiga: ");
            double z = Convert.ToInt32(Console.ReadLine());
            jumlah.JumlahTigaAngka(x,y,z);
        }
    }

    public class Penjumlahan
    {
        private double data;
        public void JumlahTigaAngka(double x, double y,double z)
        {
            data = x+y+z;
            Console.WriteLine("\nHasil penjumlahan dari 3 angka tersebut adalah:\n"+data);
        }
    }
}
