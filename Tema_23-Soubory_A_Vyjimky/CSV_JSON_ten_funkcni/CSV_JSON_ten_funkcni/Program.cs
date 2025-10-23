using System.Text.Json;

namespace CSV_JSON_ten_funkcni
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //CSV
            string cesta = "lide.csv";
            string[] radky = File.ReadAllLines(cesta);

            // jen zkušební, vytiskne celý array
            //foreach (var radek in radky)
            //{
            //    Console.WriteLine(radek);
            //}

            //// První řádek je hlavička, začneme od indexu 1
            //for (int i = 1; i < radky.Length; i++)
            //{
            //    string[] hodnoty = radky[i].Split(',');

            //    string jmeno = hodnoty[0];
            //    int vek = int.Parse(hodnoty[1]);
            //    string mesto = hodnoty[2];

            //    Console.WriteLine($"{jmeno} ({vek}) - {mesto}");
            //}

            int n = radky.Length;
            string[] jmena = new string[n];
            string[] prijmeni = new string[n];
            string[] mesta = new string[n];
            int[] rokyNarozeni = new int[n];

            //i je proměná, po pokaždém ciklu se přidá +1, 
            for (int i = 1; i < n; i++)
            {
                string[] aktualniRadek = radky[i].Split(';');
                jmena[i] = aktualniRadek[0];    //z řádku "i" a sloupce 0 se přidá do array jmena to co je v lide.csv na dané pozici
                prijmeni[i] = aktualniRadek[1]; //z řádku "i" a sloupce 1 se přidá do array prijmeni to co je v lide.csv na dané pozici
                mesta[i] = aktualniRadek[2];    //z řádku "i" a sloupce 2 se přidá do array mesta to co je v lide.csv na dané pozici
                rokyNarozeni[i] = int.Parse(aktualniRadek[3]);  //z řádku "i" a sloupce 3 se přidá do array rokyNarozeni to co je v lide.csv na dané pozici
            }
            foreach (var jmeno in jmena)
            {
                Console.WriteLine(jmeno);
            }

            Console.WriteLine("---------------");
            foreach(var prij in prijmeni)
            {
                Console.WriteLine(prij);
            }

            Console.WriteLine("--------------------");
            int vyskytBrno = mesta.Count(m => m == "Brno");
            Console.WriteLine(vyskytBrno);


            //JSON
            Dictionary<string, int> ucastnici = new Dictionary<string, int>()
            {
                {"Pavel", 2007 },
                {"Franta", 2000 },
                {"Jan", 2006 }
            };

            string json = JsonSerializer.Serialize(ucastnici);  //serializace do podoby zapisu
            File.WriteAllText("ucastnici.json", json); //uložit jako ucastnici.json do jsonu. uloží se to do "soubor projektu/bin/Debug/net8.0/ucastnici - otevrit v poznamkach


            //Vypsání z uloženého JSONU
            string nactenyJsonu = File.ReadAllText("ucastnici.json");
            Console.WriteLine(nactenyJsonu);
            var nactenyDict = JsonSerializer.Deserialize<Dictionary<string, int>>(nactenyJsonu);
            Console.WriteLine(nactenyDict["Jan"]);


            Console.ReadKey();
        }
    }
}
