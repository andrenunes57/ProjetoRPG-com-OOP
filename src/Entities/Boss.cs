using System;
using System.Collections.Generic;
using ProjetoRPG.src.Enums;

namespace ProjetoRPG.src.Entities
{
    public class Boss : CharacterBase
    {
        public Boss()
        { 
        }

        public Boss(string Name, int Level, CharacterClass characterClass, int HitPoints, int MagicPoints) 
        : base(Name, Level, characterClass, HitPoints, MagicPoints)
        {
        }
        public string Attack(CharacterBase character)
        {
            int attackValue = 300;
            character.HitPoints -= attackValue;
            if (character.HitPoints > 0)
            {
                return $"{this.Name} com dano de {attackValue}";
            }
            else
            {   
                Console.WriteLine($"{this.Name} com dano de {attackValue}");
                return ChangeLifeStatus(character);          
            }    
        }

        public string Attack(CharacterBase character, int bonus)
        {
            int attackValue = 300;
            character.HitPoints -= attackValue + bonus;
            if (character.HitPoints > 0)
            {
                return $"{this.Name} atacou {character.Name} com dano de {attackValue} e bonus +{bonus}!";
            }
            else
            {
                Console.WriteLine($"{this.Name} atacou {character.Name} com dano de {attackValue} e bonus +{bonus}!");
                return ChangeLifeStatus(character);      
            }
        }

        public string AreaAttack(List<CharacterBase> heroesInBattle) 
        {
            foreach (CharacterBase character in heroesInBattle)
            {
                character.HitPoints -= 300;        
            }
            return $"{this.Name} atacou TODOS OS HERÓIS com TERREMOTO!";
        }
    }
}