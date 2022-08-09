
using System;
using warofheros.Enums;

namespace warofheros.Equipment
{
    class Armor
    {
        private readonly int armor;

        public Armor( Faction faction)
        {

            switch (faction)
            {
                case Faction.HUMAN:
                    armor = 50;
                    break;
                case Faction.ELF:
                    armor = 40;
                    break;
                case Faction.ORK:
                    armor = 15;
                    break;
                case Faction.MAGE:
                    armor = 15;
                    break;
                default:
                    break;
            }

            
        }


        public int Deffence
        {
            get
            {
                

                return armor;
            }
            

        }
        
     



}
}
