namespace Test_IF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DEN
            Console.WriteLine("Zadejte den\n1 - Ponděli\n2 - Úterý\n3 - Středa \n4 - Čtvrtek\n5 - Pátek\n6 - Sobota \n7 - Neděle\n------------\nDen: ");
            int den;
            //Ověření zda je číslo
            if (!int.TryParse(Console.ReadLine(), out den))
            {
                Console.WriteLine("Špatně zadaný den");
                return;
            }
            //Ověření zda je číslo v rozsahu 1-7
            else if (den < 1 || den > 7)
            {
                Console.WriteLine("Špatně zadaný den");
                return;
            }
            else
            {
                //VĚK
                Console.WriteLine("Zadejte věk: ");
                int vek;
                //Ověření zda je číslo
                if (!int.TryParse(Console.ReadLine(), out vek))
                {
                    Console.WriteLine("Špatně zadaný věk");
                    return;
                }
                else
                {
                    float cena = 150; // základní cena

                    //Ověření zda je věk kladná
                    if (vek <= 0)
                    {
                        Console.WriteLine("Chyba: Záporný věk");
                    }
                    else if (vek <= 15)
                    {
                        float cena_deti = cena / 2; //50% sleva deti
                        if (den == 2) //úterý 20% sleva
                        {
                            float zaverecna_cena = cena_deti / 100 * 80;
                            Console.WriteLine($"Cena: {zaverecna_cena}");
                        }
                        else if (den >= 1 && den <= 7)
                        {
                            Console.WriteLine($"Cena: {cena_deti}");
                        }
                        else
                        {
                            Console.WriteLine("Špatně zadaný den");
                        }

                    }
                    else if (vek > 15 && vek <65) //bez slevy
                    {
                        if (den == 2)
                        {
                            float zaverecna_cena = cena / 100 * 80; //Úterý 20% sleva
                            Console.WriteLine($"Cena: {zaverecna_cena}");
                        }
                        else
                        {
                            Console.WriteLine($"Cena: {cena}");
                        }
                    }
                    else if (vek >= 65) 
                    {
                        float cena_senior = cena / 100 * 70; //Senioři 30% sleva
                        if (den == 2) //Úterý 20% sleva
                        {
                            float zaverecna_cena = cena_senior / 100 * 80;
                            Console.WriteLine($"Cena: {zaverecna_cena}");
                        }
                        else
                        {
                            Console.WriteLine($"Cena {cena_senior}");
                        }

                    }
                }


            }


           
        }
    }
}
