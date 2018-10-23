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
                Console.Clear();
                //#region p1 charsheet
                //if (p1 == Elf.number)
                //{
                //    int p1Hp = Elf.hp;
                //    string p1Weakness = Elf.weakness;
                //}
                //else if (p1 == Orc.number)
                //{
                //    int p1Hp = Orc.hp;
                //    string p1Weakness = Orc.weakness;
                //}
                //else if (p1 == Dwarf.number)
                //{
                //    int p1Hp = Dwarf.hp;
                //    string p1Weakness = Dwarf.weakness;
                //}
                //else if (p1 == Naga.number)
                //{
                //    int p1Hp = Naga.hp;
                //    string p1Weakness = Naga.weakness;
                //}
                //#endregion
                //#region p2 charsheet
                //if (p2 == Elf.number)
                //{
                //    int p2Hp = Elf.hp;
                //    string p2Weakness = Elf.weakness;
                //}
                //else if (p2 == Orc.number)
                //{
                //    int p2Hp = Orc.hp;
                //    string p2Weakness = Orc.weakness;
                //}
                //else if (p2 == Dwarf.number)
                //{
                //    int p2Hp = Dwarf.hp;
                //    string p2Weakness = Dwarf.weakness;
                //}
                //else if (p2 == Naga.number)
                //{
                //    int p2Hp = Naga.hp;
                //    string p2Weakness = Naga.weakness;
                //}
                //#endregion

                Console.WriteLine("Spiller 1 Starter");
                int p1Hp = 10;
                int p2Hp = 10;
                do
                {

                    for (int k = 0; k < 1; k++)
                    {
                        Console.WriteLine("Vil du anvende angreb 1. eller 2.?");
                        int angreb = int.Parse(Console.ReadLine());
                        if (angreb == 1)
                        {
                            Console.WriteLine("Du angreb fjenden for 3 skade.");
                            p2Hp -= 3;
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
