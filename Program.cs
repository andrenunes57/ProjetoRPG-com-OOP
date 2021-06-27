using System;
using System.Collections.Generic;
using System.Threading;
using ProjetoRPG.src.Entities;
using ProjetoRPG.src.Enums;

namespace ProjetoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Knight arus = new Knight("Arus", 27, Enum.Parse<CharacterClass>("Knight"), 749, 72);
            WhiteWizard jenica = new WhiteWizard("Jenica", 28, Enum.Parse<CharacterClass>("WhiteWizard"), 755, 70);
            Boss sephiroth = new Boss("Sephiroth", 100, Enum.Parse<CharacterClass>("Boss"), 900, 99);


            List<CharacterBase> heroesInBattle = new List<CharacterBase>();
            heroesInBattle.Add(arus);
            heroesInBattle.Add(jenica);

            Console.WriteLine("-------------------");
            Console.WriteLine("  * APRSENTAÇÃO *  ");
            Console.WriteLine("* DOS PERSONAGENS *");
            Console.WriteLine("-------------------");
            Console.WriteLine($"Heróis: {arus.Name}, HP: {arus.HitPoints}, CLASSE: {arus.CharacterClass}");
            Console.WriteLine($"        {jenica.Name}, HP: {jenica.HitPoints}, CLASSE: {jenica.CharacterClass}");
            Console.WriteLine();
            Console.WriteLine($"Chefão: {sephiroth.Name}, HP: {sephiroth.HitPoints}, CLASSE: {sephiroth.CharacterClass}");
            Thread.Sleep(TimeSpan.FromSeconds(6));

            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine("* INÍCIO DA BATALHA *");
            Console.WriteLine("---------------------");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            
            Console.WriteLine("--------");
            Console.WriteLine("TURNO 01");
            Console.WriteLine("--------");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            Console.WriteLine(arus.Attack(sephiroth));
            Console.WriteLine();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            Console.WriteLine(sephiroth.GetStatus());
            Console.WriteLine();
            Thread.Sleep(TimeSpan.FromSeconds(3));

            Console.WriteLine("--------");
            Console.WriteLine("TURNO 02");
            Console.WriteLine("--------");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            Console.WriteLine(sephiroth.Attack(arus, 100));
            Console.WriteLine();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            Console.WriteLine(arus.GetStatus());
            Console.WriteLine();
            Thread.Sleep(TimeSpan.FromSeconds(3));

            Console.WriteLine("--------");
            Console.WriteLine("TURNO 03");
            Console.WriteLine("--------");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            Console.WriteLine(jenica.Support(arus));
            Console.WriteLine();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            Console.WriteLine(arus.GetStatus());
            Thread.Sleep(TimeSpan.FromSeconds(3));

            Console.WriteLine("--------");
            Console.WriteLine("TURNO 04");
            Console.WriteLine("--------");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            Console.WriteLine(sephiroth.AreaAttack(heroesInBattle));
            Console.WriteLine();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            Console.WriteLine(arus.GetStatus());
            Console.WriteLine(jenica.GetStatus());
            Console.WriteLine();
            Thread.Sleep(TimeSpan.FromSeconds(5));

            Console.WriteLine("--------");
            Console.WriteLine("TURNO 05");
            Console.WriteLine("--------");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            Console.WriteLine(arus.Attack(sephiroth, 400));
            Console.WriteLine();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            Console.WriteLine(sephiroth.GetStatus());
            Console.WriteLine();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            Console.WriteLine("---------------------");
            Console.WriteLine("  * FIM DA BATALHA * ");
            Console.WriteLine("---------------------");
            Console.WriteLine("  * XP GANHO: +359 * ");
        }
    }
}
