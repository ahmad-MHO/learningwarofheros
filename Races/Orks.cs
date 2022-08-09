
using warofheros.Enums;
using warofheros.Equipment;
using warofheros.whatcando;
namespace warofheros.Races
{
    class Orks : HEROS, IActionofheros
    {
        const int ORK_HEALTH = 1600;
        const int ORK_ATTACK = 200;
        const int ORK_DEFFENCE = 10;
        readonly Weapon orkweapon = new Weapon(Faction.ORK);
        readonly Armor orkarmor = new Armor(Faction.ORK);
        public Orks(string name)
        {
            base.name = name;
            health = ORK_HEALTH;
            attack = ORK_ATTACK + orkweapon.Attack; 
            deffence = ORK_DEFFENCE + orkarmor.Deffence ;
            faction = Faction.ORK;
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

