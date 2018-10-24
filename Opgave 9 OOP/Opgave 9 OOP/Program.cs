using System;

namespace Opgave_9_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opg9Wine();
            FantasyFight();
            Console.ReadLine();
        }

        private static void FantasyFight()
        {
            Race Elf = new Race("Elf", 10, 1, "Nature", "Fire");
            Race Orc = new Race("Orc", 10, 2, "Physical", "Nature");
            Race Dwarf = new Race("Dwarf", 10, 3, "Fire", "Water");
            Race Naga = new Race("Naga", 10, 4, "Water", "Physical");
            Race Player1 = new Race("", 0, 0, "", "");
            Race Player2 = new Race("", 0, 0, "", "");

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Velkommen til Fantasy Fight");

                Console.WriteLine("Du skal nu vælge en race, indtast nummeret på dit valg. \n" +
                    $"{Elf.number}. {Elf.name} \n" +
                    $"{Orc.number}. {Orc.name} \n" +
                    $"{Dwarf.number}. {Dwarf.name} \n" +
                    $"{Naga.number}. {Naga.name} \n");

                int p1 = Player1Sel(0);
                int p2 = Player2Sel(0, p1);

                Console.WriteLine("Lad kampen begynde, spiller 1 starter altid.");
                Console.WriteLine("Tryk enter for at starte spillet");
                Console.ReadLine();
                Console.Clear();
                #region p1 charsheet
                if (p1 == Elf.number)
                {
                    Player1 = Elf;
                }
                else if (p1 == Orc.number)
                {
                    Player1 = Orc;
                }
                else if (p1 == Dwarf.number)
                {
                    Player1 = Dwarf;
                }
                else if (p1 == Naga.number)
                {
                    Player1 = Naga;
                }
                #endregion
                #region p2 charsheet
                if (p2 == Elf.number)
                {
                    Player2 = Elf;
                }
                else if (p2 == Orc.number)
                {
                    Player2 = Orc;
                }
                else if (p2 == Dwarf.number)
                {
                    Player2 = Dwarf;
                }
                else if (p2 == Naga.number)
                {
                    Player2 = Naga;
                }
                #endregion

                Console.WriteLine("Spiller 1 Starter \n");
                int p1Hp = Player1.hp;
                int p2Hp = Player2.hp;
                do
                {

                    for (int k = 0; k < 1; k++)
                    {
                        Console.WriteLine("Spiller 1's tur.\n");
                        Console.WriteLine("Vil du anvende angreb 1. eller 2.?");
                        int angreb = int.Parse(Console.ReadLine());
                        if (angreb == 1)
                        {
                            if (Player1.strength == Player2.weakness)
                            {
                                Console.WriteLine($"Du angreb fjenden for {3*2} skade.");
                                p2Hp -= 3 * 2;
                            }
                            else
                            {
                                Console.WriteLine("Du angreb fjenden for 3 skade.");
                                p2Hp -= 3;
                            }
                        } 
                        else if (angreb == 2)
                        {
                            Console.WriteLine("Du angreb fjenden for 5 skade.");
                            p2Hp -= 5;
                        }
                    }
                    if (p2Hp < 1)
                    {
                        Console.WriteLine("Player 1 wins!");
                        break;
                    }
                    for (int l = 0; l < 1; l++)
                    {
                        Console.WriteLine("Spiller 2's tur.\n");
                        Console.WriteLine("Vil du anvende angreb 1. eller 2.?");
                        int angreb = int.Parse(Console.ReadLine());
                        if (angreb == 1)
                        {
                            Console.WriteLine("Du angreb fjenden for 3 skade.");
                            p1Hp -= 3;
                        }
                        else if (angreb == 2)
                        {
                            Console.WriteLine("Du angreb fjenden for 5 skade.");
                            p1Hp -= 5;
                        }
                    }
                    if (p1Hp < 1)
                    {
                        Console.WriteLine("Player 2 wins!");
                        break;
                    }
                } while (true);

                Console.WriteLine("Tryk enter for at starte et nyt spil.");
                Console.ReadLine();
                i = 0;
                Console.Clear();




            }
        }

        private static int Player1Sel(int p1)
        {
            bool p1Select = true;
            //Player 1
            Console.WriteLine("Player 1 vælger");
            p1 = int.Parse(Console.ReadLine());
            do
            {
                if (p1 == 1)
                {
                    Console.WriteLine("Player 1 valgte Elf \n");
                    p1Select = false;
                }
                else if (p1 == 2)
                {
                    Console.WriteLine("Player 1 valgte Orc \n");
                    p1Select = false;
                }
                else if (p1 == 3)
                {
                    Console.WriteLine("Player 1 valgte Dwarf \n");
                    p1Select = false;
                }
                else if (p1 == 4)
                {
                    Console.WriteLine("Player 1 valgte Naga \n");
                    p1Select = false;
                }
                else
                {
                    Console.WriteLine("Du indtastede et forkert input, prøv igen.");
                    p1 = int.Parse(Console.ReadLine());
                }
            } while (p1Select);
            return p1;

        }
        private static int Player2Sel(int p2, int p1)
        {
            //player 2
            bool p2Select = true;
            Console.WriteLine("Player 2 vælger");
            p2 = int.Parse(Console.ReadLine());
            do
            {
                if (p2 == 1 && p1 != 1)
                {
                    Console.WriteLine("Player 2 valgte Elf");
                    p2Select = false;
                }
                else if (p2 == 2 && p1 != 2)
                {
                    Console.WriteLine("Player 2 valgte Orc");
                    p2Select = false;
                }
                else if (p2 == 3 && p1 != 3)
                {
                    Console.WriteLine("Player 2 valgte Dwarf");
                    p2Select = false;
                }
                else if (p2 == 4 && p1 != 4)
                {
                    Console.WriteLine("Player 2 valgte Naga");
                    p2Select = false;
                }
                else
                {
                    Console.WriteLine("Dit input er Forkert eller allerede valgt, prøv igen. ");
                    p2 = int.Parse(Console.ReadLine());

                }
            } while (p2Select);
            return p2;
        }

        private static void Opg9Wine()
        {
            WineBox box1 = new WineBox("French Wine", "Red grape", 6, 14.99, 25.99, "France", true, 7, 16.3);
            Console.WriteLine(box1.name);
            Console.ReadLine();
        }
    }

    class WineBox
    {
        public string name;
        public string grapeType;
        public int amount;
        public double price;
        public double salePrice;
        public string country;
        public bool vintage;
        public int rating;
        public double pct;
        public WineBox(string name, string grapeType, int amount,
        double price, double salePrice, string country, bool vintage, int rating, double pct)
        {
            this.name = name;
            this.grapeType = grapeType;
            this.amount = amount;
            this.price = price;
            this.salePrice = salePrice;
            this.country = country;
            this.vintage = vintage;
            this.rating = rating;
            this.pct = pct;
        }

    }
}
