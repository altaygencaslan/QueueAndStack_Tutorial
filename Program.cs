using System;
using System.Collections.Generic;

namespace QueueAndStack_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> strKuyruk = new Queue<string>();
            Stack<string> strYigin = new Stack<string>();

            Console.WriteLine("Lütfen 5 giriş yapınız. Bu giriş sayı, isim, harf vb. şeyler olabilir.");
            for (int i = 0; i < 5; i++)
            {
                string girdi = Console.ReadLine();
                strKuyruk.Enqueue(girdi); //Queue'ya veri eklendi
                strYigin.Push(girdi); //Stack'e veri eklendi
            }

            Console.WriteLine("Queue \t Stack");
            for (int i = 0; i < 5; i++)
            {
                string veri = string.Format("{0} \t {1}", strKuyruk.Dequeue(), strYigin.Pop());
                Console.WriteLine(veri);
            }

            Console.WriteLine("Görüldüğü üzere\nQueue (F)ist (I)n (F)irst (O)ut şeklinde çalışır," +
                              "\nStack (L)ast (I)n (F)irst (O)ut şeklinde çalışır.");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
