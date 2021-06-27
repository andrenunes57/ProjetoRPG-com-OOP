using System;
using System.Threading;
using ProjetoRPG.src.Enums;

namespace ProjetoRPG.src.Entities
{
    public class CharacterBase
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public CharacterClass CharacterClass { get; set; }
        public int HitPoints { get; set; }
        public int MagicPoints { get; set; }
        public bool Alive { get; set; }

        public CharacterBase()
        {
        }
        public CharacterBase(string Name, int Level, CharacterClass characterClass, int HitPoints, int MagicPoints)
        {
            this.Name = Name;
            this.Level = Level;
            this.CharacterClass = characterClass;
            this.HitPoints = HitPoints;
            this.MagicPoints = MagicPoints;
            this.Alive = true;
        }
        
        public string GetStatus()
        {
            return $"Status de {this.Name}: \n| HP: {this.HitPoints} | MP: {this.MagicPoints} |\n";
        }

        public override string ToString()
        {
            return $"| Nome: {this.Name} | Nível: {this.Level} | Classe: {this.CharacterClass} | HP: {this.HitPoints} | MP: {this.MagicPoints} |";
        }
        public string ChangeLifeStatus(CharacterBase character)
        {
            this.Alive = false;
            Console.WriteLine();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            return $"{character.Name} foi *DERROTADO*";
        }
    }
}