
using System;
using ProjetoRPG.src.Enums;

namespace ProjetoRPG.src.Entities
{
    public class Knight : CharacterBase
    {
        public Knight()
        { 
        }

        public Knight(string Name, int Level, CharacterClass characterClass, int HitPoints, int MagicPoints) 
        : base(Name, Level, characterClass, HitPoints, MagicPoints)
        {
        }
        public string Attack(CharacterBase character)
        {
            int attackValue = 300;
            character.HitPoints -= attackValue;
            if (character.HitPoints > 0)
            {
                return $"{this.Name} atacou {character.Name} com dano de {attackValue}";
            }
            else
            {
                Console.WriteLine($"{this.Name} atacou {character.Name} com dano de {attackValue}"); 
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
    }
}

        //Implementar os métodos de ataques para cada classe, diminuindo o HP se aplicável
        //Implementar os métodos de tomar dano, dimunuindo o HP
        //Implementar no ToString o status do HP e MP, incluindo mensagem de "Personagem morreu", caso o HP chegue a zero
        //Implementar o tostring da cura/dano em character
        //Gravar video do console e editar com som de batalha
        //Incluir Delay para rodar os turnos! e causar tensão!
        //Dificuldade em implemnetar interface, classe abstrata
        //Aprendendo se divertinho, realizar sonho de desenvolver games