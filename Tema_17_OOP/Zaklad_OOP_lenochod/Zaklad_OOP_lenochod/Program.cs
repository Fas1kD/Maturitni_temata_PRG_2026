namespace Zaklad_OOP_lenochod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Lenochod lenochod1 = new Lenochod("Jara", 2022, 25);
            Console.WriteLine(lenochod1.Name);
            Console.WriteLine(lenochod1);


            // value types
            string Jmeno = "Jakub";
            string Jmeno2 = Jmeno;
            Jmeno = "Karel";
            Console.WriteLine(Jmeno2);  //Vypíše Jakub


            // reference types a garbage collector
            Lenochod lenochod2 = lenochod1;
            Console.WriteLine(lenochod2.Hmotnost); //10
            lenochod1.Hmotnost = 100;
            Console.WriteLine(lenochod2.Hmotnost); //100



        }
    }
}
