namespace Tema_18_Dedicnost_Polymorfismus_Zapozdreni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //POLYMORFYSMUS 
            Console.WriteLine("Hello, World!");

            //Vytvoření objektu
            Kytara kytara1 = new Kytara();
            //Vyvolání vlastnotsi
            kytara1.Zahraj();

            Buben buben1 = new Buben();
            buben1.Zahraj();

            Console.WriteLine(Buben.JeNaladeny); //volání statické metody

            Console.WriteLine(buben1.Sound);
            Console.WriteLine(kytara1.Sound);
            
        }
    }
}
