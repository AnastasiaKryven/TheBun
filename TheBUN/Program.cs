using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TheBUN
{
    class Program
    {
        static void Main(string[] args)
        {          
                TheBun bun = new TheBun();
                bun.WantsToEat();
                bun.Recipe();
                bun.RanAway();
                Hare hare = new Hare();
                hare.ToMeet();
                hare.WantsToEat();
                hare.RanAway();
                hare.RunFromYou();
                WriteLine("Will The Bun seet on the nose to sing a song?");
                var a = ReadLine();
                if (a == "1") { WriteLine("The Bun eaten!"); ReadKey(); return; }
                Wolf wolf = new Wolf();
                wolf.ToMeet();
                wolf.WantsToEat();
                wolf.RanAway();
                wolf.RunFromYou();
                WriteLine("Will The Bun seet on the nose to sing a song?");
                a = ReadLine();
                if (a == "1") { WriteLine("The Bun eaten!"); ReadKey(); return; }
                Bear bear = new Bear();
                bear.ToMeet();
                bear.WantsToEat();
                bear.RanAway();
                bear.RunFromYou();
                WriteLine("Will The Bun seet on the nose to sing a song?");
                a = ReadLine();
                if (a == "1") { WriteLine("The Bun eaten!"); ReadKey(); return; }
                Fox fox = new Fox();
                fox.ToMeet();
                fox.WantsToEat();
                fox.RanAway();
                fox.RunFromYou();
                WriteLine("Will The Bun seet on the nose to sing a song?");
                a = ReadLine();
                if (a == "1") { WriteLine("The Bun eaten!"); ReadKey(); return; }
                WriteLine("The end!");

            ReadKey();
        }

      
    }
}
