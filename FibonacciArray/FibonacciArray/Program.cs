using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Github:https://github.com/bynarr0w\nLinkedIn:https://www.linkedin.com/in/furkanulgen/\nDiscord:narr0w#5737\n====================================================================");
            Console.Title = "Fibonacci Calculation || Developed by Furkan Ulgen";
            UInt64[] FibonacciArray = new UInt64[2]; //Diziyi Tanımlıyoruz.
            FibonacciArray[0] = 0;//Dizinin 0. Index'ine 0 Değerini Tanımlıyoruz.
            FibonacciArray[1] = 1;//Dizinin 1. Index'ine 1 Değerini Tanımlıyoruz.
            Console.Write("How Long Do You Want Fibonacci to Continue? (min. 3) : ");//Kullanıcıdan Fibonacci Dizisinin Ne Kadar Tekrar Edeceğini Öğrenmek İçin Kullanıcıdan Sayı Girmesini İstiyoruz. 
            int tekrar = Convert.ToInt32(Console.ReadLine());//Kullanıcıdan Aldığımız string İfadeyi Int Çevirip tekrar Değişkenine Atıyoruz.
            for (int i = 2; i < tekrar; i++)//Döngümüzü Kuruyoruz.
            {
                Array.Resize(ref FibonacciArray, FibonacciArray.Length + 1);//Her Döngü Çalıştığında Array'ın Uzunluğunu 1 Artırıyoruz.
                FibonacciArray[i] = FibonacciArray[i - 1] + FibonacciArray[i - 2];//Fibonacci Mantığına Uygun İşlemi Yaptırıyoruz.
                Console.WriteLine("Result = " + "Index : ["+(i+1)+"] || " + FibonacciArray[i] + " = " + FibonacciArray[i - 1] + " + " + FibonacciArray[i - 2]);//İçinde Bulunduğumuz Döngüde Neler Olduğunu Console'a Yazdırıyoruz.

            }
            Console.ReadLine();//Sonuçları Görmek İçin Console'un Kapanmasını Engelliyoruz.
        }
    }
}
