
using warofheros.Enums;
using warofheros.Equipment;
using warofheros.whatcando;
namespace warofheros.Races
{
    class Elf : HEROS , IActionofheros
    {
        const int ELF_HEALTH = 800;
        const int ELF_DEFFENCE = 7;
        const int ELF_ATTACK = 150;
        readonly Weapon elfweapon = new Weapon(Faction.ELF);
        readonly Armor elfarmor = new Armor(Faction.ELF);
        public Elf(string name)
        {
             faction = Faction.ELF;         
             base.name = name;
             health = ELF_HEALTH;
             attack = ELF_ATTACK + elfweapon.Attack ;
             deffence = ELF_DEFFENCE + elfarmor.Deffence;
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
