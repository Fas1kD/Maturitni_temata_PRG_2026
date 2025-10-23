namespace CSV_JSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cesta = "lide.csv";  // cesta k souboru je "lide.csv"
            string[] radky = File.ReadAllLines(cesta);  //ReadAllLines - vypiš všechny řádky z cesta

            foreach(var radek in radky)     //pro kazdy radek v radky vypis ten jeden radek a pokracuj dokud nebudes u posledniho radku
            {
                Console.WriteLine(radek);
            }

            var delkaRadku = radky.Length - 1;      // proměná z radky.Lenght - 1 --->>> počet řádků minus první řádek

            //array pro kazde jmeno, prijmeni,...
            string[] jmeno = new string[delkaRadku];
            string[] prijmeni = new string[delkaRadku];
            string[] misto = new string[delkaRadku];
            int[] rok = new int[delkaRadku];

            string[] aktaulniRadek = radky[1].Split(";"); //rozdeleni prvního (druhého) radku, kde je ; se dá mezera
            Console.WriteLine(aktaulniRadek[0]);    //[0] - číslo sloupce - 0-jmeno, 1-prijmeni, 2-misto, 3-rok


            //vypíše všechno z jednoho sloupce
            int i = 1;
            string[] jmeno2 = radky[i].Split(";");
            foreach (var cokoliv in radky)
            {
                if (i == radky.Length)
                {
                    Console.WriteLine("konec");
                    break;
                }
                else
                {
                    jmeno2 = radky[i].Split(";");
                    Console.WriteLine(jmeno2[0]);
                    i++;

                }
                
            }





        }
    }
}
