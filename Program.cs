using System;
using warofheros.Equipment;
using warofheros.Races;
using warofheros.whatcando;

namespace warofheros
{
    class Program 
    {
        static void Main()
        {

            Console.WriteLine("do you wanna play a fun game");
            Console.WriteLine("lets do it ");
            ONEONONE fighting = new ONEONONE();
            HEROS hero = fighting.Creatingahero();
            HEROS enemy = fighting.Creatinganenemy();
            Console.WriteLine($"health {hero.health}  deffence {hero.deffence}    attack {hero.attack}");
            Console.WriteLine($"health {enemy.health}  deffence {enemy.deffence}    attack {enemy.attack}");
            hero.AddAttribut(hero);
            hero.Fight(hero, enemy);
            Console.WriteLine(fighting.deffence); // = 0 , this must be unaccesable and fighting must not have a deffence 
            Console.WriteLine($"health {hero.health}  deffence {hero.deffence}    attack {hero.attack}");
            Console.WriteLine($"health {enemy.health}  deffence {enemy.deffence}    attack {enemy.attack}");
            hero.Creatingahero();










        }
    }
}
