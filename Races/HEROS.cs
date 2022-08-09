
using System;
using warofheros.Enums;
using warofheros.whatcando;


namespace warofheros.Races
{
    abstract class  HEROS 
    {
        public string name;
        public int health;
        public int attack;
        public int deffence;
        public Faction faction;
        public bool isalive;
        public string playernaming;
        public string enemynaming;
        public  void Fight(HEROS hero1, HEROS hero2)
        {
            Random rand = new Random();
            int hero1health = hero1.health;
            int hero2health = hero2.health;
            int damege;
            while (hero1health > 0 && hero2health > 0)
            {

                if (rand.Next(0, 10) < 5)
                {
                    damege = hero1.attack / hero2.deffence;
                    hero2health -= damege;
                    if (hero2health <= 0)
                    {
                        hero2health = 0;
                        Console.WriteLine($"the battel has ended and {hero1.name} is victorious on {hero2.name} with {hero1health} health remaning");
                    }
                    else
                    {
                        Tools.Colorfulwriting(text: $"player {hero1.name} did {damege} of damege to {hero2.name} health: {hero2health}", ConsoleColor.Red);
                    }
                }
                else
                {
                    damege = hero2.attack / hero1.deffence;
                    hero1health -= damege;

                    if (hero1health <= 0)
                    {

                        hero1health = 0;
                        Console.WriteLine($"the battel has ended and {hero2.name} is victorious on {hero1.name} with {hero2health} health remaning");
                    }
                    else
                    {
                        Tools.Colorfulwriting(text: $"player {hero2.name} did {damege} of damege to {hero1.name} health: {hero1health}", ConsoleColor.Red);
                    }
                }



            }
        }
        public void Hello()
        {
            Console.WriteLine("hello");
        }

        public void AddAttribut(HEROS hero)
        {
            Console.WriteLine("now it's time to customise your hero");
            for (int i = 0; i < 5; i++)
            {

            increasingattribut:
                Console.WriteLine($"you have {5 - i} attribut point you can allocate");
                Console.WriteLine("choose attribut to increase \n 1- health (HP +100)\n 2- attack (ATT +20) \n 3- deffence (DFF + 5)");
                int attributtoincrease = int.Parse(Console.ReadLine());
                if (attributtoincrease == 1)
                {
                    hero.health += 100;

                }
                else if (attributtoincrease == 2)
                {
                    hero.attack += 20;
                }
                else if (attributtoincrease == 3)
                {
                    hero.deffence += 5;
                }
                else
                {
                    Console.WriteLine("wrong input try again");
                    goto increasingattribut;
                }


            }
        }
        
        public HEROS Creatingahero()
        {
            Console.WriteLine("first you need a name:");
            playernaming = Console.ReadLine();
        startcreating:
            Console.WriteLine("now choose you race");
            Console.WriteLine("1-Humans \n2-Orks \n3-Elf \n4-Mage ");


            int racechoosing = int.Parse(Console.ReadLine());
            switch (racechoosing)
            {
                case 1:
                    return
                    _ = new Humans(playernaming);

                case 2:
                    return
                    _ = new Orks(playernaming);

                case 3:
                    return
                    _ = new Elf(playernaming);

                case 4:
                    return
                    _ = new Mage(playernaming);

                default:
                    Console.WriteLine("wrong input try again");
                    goto startcreating;

            }


        }
        public HEROS Creatinganenemy()
        {
            Console.WriteLine("now who is your enemy:");
            enemynaming = Console.ReadLine();
        startcreating:
            Console.WriteLine("now choose a race");
            Console.WriteLine("1-Humans \n2-Orks \n3-Elf \n4-Mage ");
            int racechoosing = int.Parse(Console.ReadLine());
            switch (racechoosing)
            {
                case 1:
                    Humans enemyhumanhero = new Humans(enemynaming);
                    Attributingenemy(enemyhumanhero);
                    return
                    enemyhumanhero;

                case 2:
                    Orks enemyorkhero = new Orks(enemynaming);
                    Attributingenemy(enemyorkhero);
                    return
                        enemyorkhero;
                case 3:
                    Elf enemyelfhero = new Elf(enemynaming);

                    Attributingenemy(enemyelfhero);
                    return
                        enemyelfhero;
                case 4:
                    Mage enemymagehero = new Mage(enemynaming);
                    Attributingenemy(enemymagehero);
                    return
                        enemymagehero;
                default:
                    Console.WriteLine("wrong input try again");
                    goto startcreating;

            }


        }

        private void Attributingenemy(HEROS enemy)
        {
            for (int i = 0; i < 5; i++)
            {
                Random rand = new Random();
                int X = rand.Next(1, 3);
                if (X == 1)
                {
                    enemy.health += 100;

                }
                else if (X == 2)
                {
                    enemy.attack += 20;
                }
                else
                {
                    enemy.deffence += 5;
                }

            }
        }
    }
      
 
}