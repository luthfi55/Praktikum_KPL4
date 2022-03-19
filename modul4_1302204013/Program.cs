using System;
using System.Collections.Generic;

namespace modul4_1302204013
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // nim = 1302204013

            Penjumlahan jumlah = new Penjumlahan();
            Console.WriteLine("Masukkan angka pertama: ");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukkan angka kedua: ");
            double y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukkan angka ketiga: ");
            double z = Convert.ToInt32(Console.ReadLine());
            jumlah.JumlahTigaAngka(x, y, z);

            SimpleDataBase<double> data = new SimpleDataBase<double>();
            data.AddNewData(13f);
            data.AddNewData(02f);
            data.AddNewData(20f);
            data.PrintAllData();

        }
    }

    public class Penjumlahan
    {
        private double data;
        public void JumlahTigaAngka(double x, double y, double z)
        {
            data = x + y + z;
            Console.WriteLine("\nHasil penjumlahan dari 3 angka tersebut adalah:\n" + data);
        }
    }

    public class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }

        public void AddNewData(T databaru)
        {
            storedData.Add(databaru);
            inputDates.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine("\nData " + (i + 1) + " berisi: " + storedData[i] + " yang disimpan pada waktu UTC: " + inputDates[i] + " AM");
            }
        }
    }
}
