using System;

namespace calisma03_sifreleme_Main__
{
    class Program
    {
        static void Main(string[] args) 
        //    *****     ACIKLAMA  *****
        // terminalde dotnet run komutunun yanına şifrelemek istediğini kelimeyi girin
        // mesela 'dotnet run sifreleyici' gibi
        // sonra istenilen adımları takip edin.
        {
            Console.WriteLine("Hello World!");
            if (args.Length != 1)
            {
                Console.WriteLine("Hatalı kullalım...");
                return;
            }
            Console.Write("Anahtarı girin :");
            string anahtar = Console.ReadLine();

            int XOR = 0;
            //Console.WriteLine(anahtar.Length);
            for (int i = 0; i < anahtar.Length; ++i)
            {
                // Console.WriteLine(anahtar[i]+"2");
                // Console.WriteLine((int)anahtar[i]+2);
                XOR += (int)anahtar[i];
                //Console.WriteLine(args[0].Length);
            }
            char[] sifre = new char[args[0].Length];

            for (int i = 0; i < args[0].Length; ++i)
            {
                sifre[i] = (char)(XOR^(int)args[0][i]);
                
            }
            Console.WriteLine(sifre);


        }
    }
}
