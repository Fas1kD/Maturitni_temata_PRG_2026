using System.Text.Json;

namespace Procvicovani_CSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cesta = "Cisla.csv";
            string vypisTextu = File.ReadAllText(cesta);
            string[] radky = File.ReadAllLines(cesta);
            Console.WriteLine(vypisTextu);
            Console.WriteLine("-----------");

            foreach (string s in radky)
            {
                Console.WriteLine(s);
            }

            string[] jmena = new string[radky.Length];

            for (int i = 1; i < radky.Length; i++)
            {
                string[]aktualniRadek = radky[i].Split(';');
                jmena[i] =aktualniRadek[0]; //slopec, i = řádek
            }
            foreach(var jmeno1 in jmena)
            {
                Console.WriteLine(jmeno1);
            }


            //JSON
            Dictionary<string, int> lidi = new Dictionary<string, int>()
            {
                {"Franta", 18 },
                {"Zdenek", 20 }
            };

            string json = JsonSerializer.Serialize(lidi);
            File.WriteAllText("lidi.json", json);

            string nactenyJsonu = File.ReadAllText("lidi.json");
            Console.WriteLine(nactenyJsonu);



            Console.ReadKey();
        }
    }
}
