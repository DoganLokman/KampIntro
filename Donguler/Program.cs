using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //değişkenlerle yapılış şekli 

            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java Kursu";
            string kurs4 = "Python";
            string kurs5 = "C++";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            
            //array = dizi

            string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs", "Java Kursu","Python","C++"};

            Console.WriteLine("---for başladı---");

            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("---for bitti---");
            Console.WriteLine("---foreach başladı---");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("---foreach bitti---");
            Console.WriteLine("Sayfa Sonu - footer");
        }
    }
}
