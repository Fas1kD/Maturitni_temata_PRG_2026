using System.Reflection.Emit;

namespace Tema_23_Soubory_A_Vyjimky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Práce s .txt .json .csv
            //třída File a StreamReader
            //Vyjímky - try catch finally, vyhození vyjímky přes throw


            //TŘÍDA FILE - má statické metody (statické metody patří ke třídě, ne k objektu)

            //File.WriteAllText("soubor.txt", "Ahoj světe"); //vytvoří soubor pokud neexistuje, pokud existuje, přepíše ho
            //File.AppendAllText("soubor.txt", "\nDalší řádek"); //přidá text na konec souboru
            //string[] radky = { "První řádek", "Druhý řádek", "Třetí řádek" };
            //File.WriteAllLines("soubor.txt", radky); //vytvoří soubor a zapíše do něj pole řádků

            //https://www.canva.com/design/DAGm1GvkccQ/MjO5gxR9tSz_Hyrr0DtK_Q/view?utm_content=DAGm1GvkccQ&utm_campaign=designshare&utm_medium=link2&utm_source=uniquelinks&utlId=h80b3f3e7cc#5

            //19.7.x
            //SOUBOR SE NACHÁZÍ VE SLOŽCE PROJEKTU /bin/debug/net8.0/

            //1
            string cesta = "pozdrav.txt";
            string text = "Ahoj světe";
            File.WriteAllText(cesta, text);

            //2
            File.AppendAllText(cesta, "\nJak se máš?");

            //3
            string[] zvirata = { "Pes", "Kočka", "Králík" };
            File.WriteAllLines("zvirata.txt", zvirata);

            //4
            string vypis = File.ReadAllText("pozdrav.txt");
            Console.WriteLine(vypis);

            //5
            string[] radky = File.ReadAllLines("zvirata.txt");
            foreach (string zvire in radky)
            {
                Console.WriteLine(zvire);
            }

            //6

            if (File.Exists("tajemstvi.txt"))
            {
                Console.WriteLine("Soubor existuje");
            }
            else
            {
                Console.WriteLine("Soubor neexistuje");
            }

            //7
            int pocetradku = 0;
            foreach (string zvire in radky)
            {
                pocetradku= pocetradku + 1;
            }
            Console.WriteLine(pocetradku);

            //8
            File.WriteAllText("backup_zvirata.txt", File.ReadAllText("zvirata.txt")); //záloha souboru


            //9

            string[] radkyVtabulce =
            {
                "Karel,17,1",
                "Monika,18,2",
                "Tereza,16,1"
            };

            File.WriteAllLines("noviStudenti.csv", radkyVtabulce);






            Console.ReadKey();


        }
    }
}
