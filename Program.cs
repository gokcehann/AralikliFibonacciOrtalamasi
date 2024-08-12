using System;
using System.Collections.Generic;
using System.Linq;

class Program
    {
        public static void Main(string[] args) {
            Console.WriteLine("Lütfen alt sınırı belirleyiniz: ");
            var altSinir=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen üst sınırı belirleyiniz: ");
            var ustSinir=Convert.ToInt32(Console.ReadLine());

            Fibonacci fibonacciHesapla=new Fibonacci();
            List<int> fibonacciDizisi=fibonacciHesapla.DiziElemani(altSinir, ustSinir);

            Ortalama ortalamaHesapla=new Ortalama();
            double ortalama=ortalamaHesapla.OrtalamaHesapla(fibonacciDizisi);

            Console.WriteLine("Bu aralıktaki fibonacci sayılarının ortalaması: " + ortalama);
        }
    }