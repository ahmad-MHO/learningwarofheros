using warofheros.Enums;
using warofheros.Equipment;
using warofheros.whatcando;

namespace warofheros.Races
{
    class Mage : HEROS, IActionofheros
    {
        const int MAGE_HEALTH = 800;
        const int MAGE_ATTACK = 250;
        const int MAGE_DEFFENCE = 5;
        readonly Armor MageArmor = new Armor(Faction.MAGE);
        readonly Weapon MageWeapon = new Weapon(Faction.MAGE);


        public Mage(string Name )
        {
            faction = Faction.MAGE;
            base.name = Name;
            health = MAGE_HEALTH;
            attack = MAGE_ATTACK + MageWeapon.Attack;
            deffence = MAGE_DEFFENCE + MageArmor.Deffence;
            isalive = true;


        }



    }
}
