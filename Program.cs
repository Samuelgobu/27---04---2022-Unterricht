using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27___04___2022_Unterricht
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Summe(3, 5));
            Console.WriteLine("Binärzahl eingeben:");
            string binäreingabe = Console.ReadLine();

            Console.WriteLine(BinärZuDezimal(binäreingabe));

            Console.WriteLine("Dezimalzahl eingeben:");
            int dezimaleingabe = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(DezimalZuBinär(dezimaleingabe));


        }
        
        //static int Summe (int a, int b)
        //{
        //    int summe = a + b;
        //    return summe;
        //}
        static int BinärZuDezimal(string binärzahl)
        {
            int dezimalzahl = 0;
            for (int i = 0; i < binärzahl.Length; i++)
            {
                int l = binärzahl.Length;
                int intBinär = Convert.ToInt32(binärzahl[i].ToString());
                dezimalzahl += intBinär * (int)Math.Pow(2, l-1-i);
            }
            return dezimalzahl;
        }
        static string DezimalZuBinär(int dezimalzahl)
        {
            string binärzahl = "";
            int Rest;
            int Quotient = dezimalzahl;
            while (Quotient != 0)
            {
                Rest = Quotient % 2;
                Quotient /= 2; //Quotient = Quotient / 2 ;
                binärzahl = Rest + binärzahl; // Konkatenation ist nicht kommutativ; rest + binärzahl != binärzahl + rest

            }

            return binärzahl
        }
    }
}
