namespace Tema_17_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vytvoření class osoba.cs
            Osoba Osoba_1 = new("Jan", 20); // Osoba - název class, Osoba_1 - název 
            Osoba_1.PredstavSe(); // Volání metody class - s hodnotami z CTOR


            //Toto se potom řeší přes konstruktor (CTOR) v Osoba.cs
            Osoba_1.Jmeno = "Franta"; // Přiřazení hodnot atributům class
            Osoba_1.Vek = 25;

            Osoba_1.PredstavSe(); // - volání z Osoba.cs s přiřazenými hodnotami v Program.cs
        }
    }
}
