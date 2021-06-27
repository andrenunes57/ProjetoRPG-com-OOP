using System;
using ProjetoRPG.src.Enums;

namespace ProjetoRPG.src.Entities
{
    public class WhiteWizard : CharacterBase
    {
        public WhiteWizard()
        { 
        }

        public WhiteWizard(string Name, int Level, CharacterClass characterClass, int HitPoints, int MagicPoints) : base(Name, Level, characterClass, HitPoints, MagicPoints)
        {
        }
        public string Support(CharacterBase character)
        {
            int healingPoints = 300;
            character.HitPoints += healingPoints;
            return $"{this.Name} CUROU {character.Name} em {healingPoints} HP!";
        }

        public string Support(CharacterBase character, int bonus)
        {
            int healingPoints = 300 + bonus;
            character.HitPoints += healingPoints;
            return $"{this.Name} CUROU {character.Name} em {healingPoints} HP com bonus +{bonus}!";
        }
    }
}