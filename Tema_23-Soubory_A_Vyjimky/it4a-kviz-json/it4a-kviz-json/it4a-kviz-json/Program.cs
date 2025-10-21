using System.Text.Json;
using System.Text.Json.Nodes;

namespace it4a_kviz_json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonText = File.ReadAllText("food.json");    // načtení obsahu souboru food.json do proměnné jsonText
            JsonNode root = JsonNode.Parse(jsonText);   // parsování JSON textu do struktury JsonNode

            // Získání jedné otázky
            //string otazka = root["categories"].ToString();
            //Console.WriteLine(otazka);


            Console.WriteLine(root["categories"][1]["questions"][0]); //z jsonu food.json vytáhne první otázku z druhé kategorie



            for (int i = 0; i < 5; i++)         // cyklus pro vypsání prvních pěti otázek z druhé kategorie
            {
                Console.WriteLine(root["categories"][1]["questions"][i]);
            }

            Console.ReadKey();
        }
    }
}
