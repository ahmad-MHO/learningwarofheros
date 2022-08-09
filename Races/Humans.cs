
using warofheros.Enums;
using warofheros.Equipment;
using warofheros.whatcando;

namespace warofheros.Races

{
    class Humans : HEROS, IActionofheros
    {
        
        const int HUMAN_HEALTH = 1000;
        const int HUMAN_DEFFENCE = 10;
        const int HUMAN_ATTACK = 100;
        readonly Weapon humanweapon = new Weapon(Faction.HUMAN);
        readonly Armor humanarmor = new Armor(Faction.HUMAN);

        public Humans(string name)
        {
            base.name = name;
            health = HUMAN_HEALTH;
            attack = HUMAN_ATTACK + humanweapon.Attack;
            deffence = HUMAN_DEFFENCE + humanarmor.Deffence;
            faction = Faction.HUMAN;
            isalive = true;

        }
        public string Name
        {
            get
            {
                return name;
            }
        }

        public int Health
        {
            get
            {
                return health;
            }
        }
        public int Attack
        {
            get
            {
                return attack;
            }
        }
        public int Deffence
        {
            get
            {     
                return deffence;
            }
        }




    }
}
