namespace Test_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HERNÍ MENU\nN-Nová hru hra\nL-Načíst hru\nS-Nastavení\nQ-Konec hry");
            Console.WriteLine("----------------------");
            char Akce = 'Q';

            switch(Akce)
            {
                case 'N':
                    Console.WriteLine("Nová hra");
                    break;
                case 'L':
                    Console.WriteLine("Načíst hru");
                    break;
                case 'S':
                    Console.WriteLine("Nastavení");
                    break;
                case 'Q':
                    Console.WriteLine("Konec");
                    break;
                default:
                    Console.WriteLine("Neplatná akce");
                    break;
            }
        }
    }
}
