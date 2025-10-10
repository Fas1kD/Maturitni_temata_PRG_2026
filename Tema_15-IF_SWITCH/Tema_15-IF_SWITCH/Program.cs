using System.ComponentModel;

namespace Tema_15_IF_SWITCH
{
    //Téma 15 - IF, SWITCH
    //if, else, else if
    //vnořené podmínky
    //logické operátory (>=, <=, ==, != - not, && - and, || - or)
    //switch, case, default - použití switch když porovnáváme jednu proměnnou s více hodnotami, když nepoúžíváme rozsahy
    //vždy musí být nějaká hodnota, a na konci musí být break, switch(proměnná){case hodnota1: break; case hodnota2: break; default: break;} - default není povinný, funguje jako else


    internal class Program
    {

        static void Main(string[] args)
        {
            //PŘ 1 SEMAFOR
            Console.WriteLine("Zadej barvu semaforu (red, orange, green): ");
            string barva = Console.ReadLine();

            switch (barva)
            {
                case "red":
                    Console.WriteLine("Stůj!");
                    break;
                case "orange":
                    Console.WriteLine("Připrav se");
                    break;
                case "green":
                    Console.WriteLine("Jdi!");
                    break;
                default:
                    Console.WriteLine("Tady něco nehraje\nJsi si jistý že si zadal správnou barvu?!");
                    break;
            }



            //PŘ 2 BANKOMAT
            Console.WriteLine("Zadejte kolik chcete vybrat:");
            int vyber = int.Parse(Console.ReadLine());
            
            if (vyber % 1000 == 0 )
            {
                int tisice = vyber / 1000;
                Console.WriteLine($"Bankomat vydal {tisice} x 1000Kč");
            }
            else if(vyber % 500 == 0)
            {
                if (vyber < 1000) //pouze pokud je cislo 500
                {
                    Console.WriteLine($"Bankomat vydal 1 x 500Kč ");
                }
                else
                {
                    int tisice = vyber / 1000;
                    Console.WriteLine($"Bankomat vydal {tisice} x 1000Kč a 1 x 500Kč ");
                }
               
            }
            else if(vyber % 100 == 0)
            {

                //kdyz je cislo mensi nez 1000
                if (vyber < 1000)
                {

                    if (vyber == 900)
                    {
                        Console.WriteLine($"Bankomat vydal 1 x 500kč a 2 x 200kč");
                    }
                    else if (vyber == 800)
                    {
                        Console.WriteLine($"Bankomat vydal 4 x 200kč");
                    }
                    else if (vyber == 700)
                    {
                        //1x500 + 1x200
                        Console.WriteLine($"Bankomat vydal 1 x 500kč a 1 x 200kč");
                    }
                    else if (vyber == 600)
                    {
                        //3x200
                        Console.WriteLine($"Bankomat vydal 3 x 200kč");
                    }
                    else if (vyber == 400)
                    {
                        //2x200
                        Console.WriteLine($"Bankomat vydal 2 x 200kč");
                    }
                    else if (vyber == 200)
                    {
                        //1x200
                        Console.WriteLine($"Bankomat vydal a 1 x 200kč");
                    }
                    else
                    {
                        Console.WriteLine("Nefunguje na radu stovek");
                    }
                }
                //kdyz je cislo vetsi nez 1000
                else
                {
                    int tisice = vyber /1000;
                    int zbytek = vyber % 1000; //to co zbyde po tisicovkach (1700 -> 700)

                    if (zbytek == 900)
                    {
                        //1x500 + 2x200

                        Console.WriteLine($"Bankomat vydal {tisice} x 1000Kč 1 x 500kč a 2 x 200kč");
                    }
                    else if (zbytek == 800)
                    {
                        //4x200
                        Console.WriteLine($"Bankomat vydal {tisice} x 1000Kč a 4 x 200kč");
                    }
                    else if (zbytek == 700)
                    {
                        //1x500 + 1x200
                        Console.WriteLine($"Bankomat vydal {tisice} x 1000Kč 1 x 500kč a 1 x 200kč");
                    }
                    else if (zbytek == 600)
                    {
                        //3x200
                        Console.WriteLine($"Bankomat vydal {tisice} x 1000Kč a 3 x 200kč");

                    }
                    else if (zbytek == 400)
                    {
                        //2x200
                        Console.WriteLine($"Bankomat vydal {tisice} x 1000Kč a 2 x 200kč");

                    }
                    else if (zbytek == 200)
                    {
                        //1x200
                        Console.WriteLine($"Bankomat vydal {tisice} x 1000Kč a 1 x 200kč");
                    }
                    else
                    {
                        Console.WriteLine("Nefunguje");
                    }
                }
            }
            else
            {
                Console.WriteLine("Číslo musí být vybráno v 1000, 500 a 200");
            }
        }





    }
}
