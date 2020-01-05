using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaultDoor4
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] Resultat = new byte[32];
            string FinalFlag;
            //on va tricher un peu sur le tableau, de base il couine sur les caractères normaux
            //et sur l'octal, on passe les deux dernières lignes en hexadécimal
            byte[] tableau =
            {
            106 , 85  , 53  , 116 , 95  , 52  , 95  , 98  ,
            0x55, 0x6e, 0x43, 0x68, 0x5f, 0x30, 0x66, 0x5f,
            0x62, 0x59, 0x74, 0x33 , 0x73, 0x5F, 0x32 , 0x30 ,
            0x31 , 0x62 , 0x33 , 0x35 , 0x32 , 0x64 , 0x36 , 0x63 ,
            };

            int i;
            for (i = 0; i<32; i++)
            {
                Resultat[i] = tableau[i];
            };

            FinalFlag = Encoding.UTF8.GetString(Resultat, 0, Resultat.Length);
            string s = "picoCTF{";
            string e = "}";
            Console.WriteLine("La clef est : {0}{1}{2}", s,FinalFlag,e);
            Console.WriteLine("Press Enter to quit");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
        }
    }
}
