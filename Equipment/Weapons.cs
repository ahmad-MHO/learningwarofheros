
using warofheros.Enums;

namespace warofheros.Equipment
{
    class Weapon
    {
        private readonly int attack;
        public Weapon( Faction faction)
        {
            switch (faction)
            {
                case Faction.HUMAN:
                    attack = 100;
                    break;
                case Faction.ELF:
                    attack = 120;
                    break;
                case Faction.ORK:
                    attack = 130;
                    break;
                case Faction.MAGE:
                    attack = 175;
                    break;
                default:
                    break;
            }
        }

        public int Attack 
        {
            get
            {
                return attack;
            }
            
        }
    }
}
