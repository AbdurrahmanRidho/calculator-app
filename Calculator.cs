using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "CalculatorApp";

            int a, b, menu;

            Console.WriteLine("Pilih Menu Calculator \n");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine("Input nomor menu yang diinginkan : ");
            menu = Convert.ToInt32(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Console.Write("Inputkan Nilai a = ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Inputkan Nilai b = ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Hasil Penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b));
                    break;

                case 2:
                    Console.Write("Inputkan Nilai a = ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Inputkan Nilai b = ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Hasil Pengurangan: {0} - {1} = {2}", a, b, Pengurangan(a, b));
                    break;

                case 3:
                    Console.Write("Inputkan Nilai a = ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Inputkan Nilai b = ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Hasil Perkalian: {0} * {1} = {2}", a, b, Perkalian(a, b));
                    break;

                case 4:
                    Console.Write("Inputkan Nilai a = ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Inputkan Nilai b = ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Hasil Pembagian: {0} / {1} = {2}", a, b, Pembagian(a, b));
                    break;

                default:
                    Console.WriteLine("Menu yang anda pilih tidak tersedia");
                    break;
            }
            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
