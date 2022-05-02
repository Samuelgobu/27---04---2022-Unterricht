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
            //Menü:
            string nochmal = "j";
            
            do
            {
                string auswahl;
                Console.WriteLine("Zahlensysteme");
                Console.WriteLine("1: Umwandlung von dezimal zu binär");
                Console.WriteLine("2: Umwandlung von binär zu dezimal");
                Console.WriteLine("3: Umwandlung von dezimal zu hexadezimal");
                Console.WriteLine("4: Umwandlung von hexadezimal zu dezimal ");
                Console.Write("Auswahl: ");
                auswahl = Console.ReadLine();

                switch (auswahl)
                {
                    case "1":
                        Console.Write("Dezimal eingeben:");
                        int dezimaleingabe = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("[" + dezimaleingabe + "]_10 = [" + DezimalZuBinär(dezimaleingabe));
                        break;
                        //--------------------
                    case "2":
                        Console.Write("Binärzahl eingeben:");
                        string binäreingabe = Console.ReadLine();
                        Console.WriteLine("[" + binäreingabe + "]_2 = [" + BinärZuDezimal(binäreingabe));

                        break;
                        //--------------------
                    case "3":
                        



                        break;
                       //--------------------
                    case "4":
                        



                        break;
                       //--------------------
                }





            } while (nochmal == "j" || nochmal == "J");









            //Console.WriteLine(Summe(3, 5));


            //Console.WriteLine("Binärzahl eingeben:");
            //string binäreingabe = Console.ReadLine();
            //Console.WriteLine(BinärZuDezimal(binäreingabe));

            //Console.WriteLine("Dezimalzahl eingeben:");
            //int dezimaleingabe = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(DezimalZuBinär(dezimaleingabe));


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

            return binärzahl;
        }
        static int BuchstabeZuZahl(string buchstabe)
        {
            int zahl;
            if (Convert.ToInt32(buchstabe) < 10)
            {
                zahl = Convert.ToInt32(buchstabe);
            }
            else
            {
                switch (buchstabe.ToUpper())
                {
                    case "A":
                        zahl = 10;
                        break;
                    case "B":
                        zahl = 11;
                        break;
                    case "C":
                        zahl = 12;
                        break;
                    case "D":
                        zahl = 13;
                        break;
                    case "E":
                        zahl = 14;
                        break;
                    case "F":
                        zahl = 15;
                        break;

                    default:
                        
                        zahl = Convert.ToInt32(buchstabe);
                        break;
                
                }

                return zahl;

            }
        }

        static string ZahlZuBuchstabe(int zahl)
            {
                string buchstabe;
                if ()
            }
        static int HexadezimalZuDezimal(string hexadezimal)
        {
            int dezimalzahl = 0;
            for (int i = 0; i < hexadezimalzahl.Length; i++)
            {
                int l = hexadezimalzahl.Length;
                int stelle = BuchstabeZuZahl(hexadezimalzahl[i].ToString());
                if (stelle == -1)
                {
                    return 
                }
            }
        }
    }
}
