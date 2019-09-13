using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBUN
{
    public class Hare:TheBun
    {
        public Hare() : base()
        {
            Character = "Little Hare";
        }

        public override void WantsToEat()
        {
            Console.WriteLine("Little bun, little bun, I want to eat you!");
        }

        public override void ToMeet()
        {
            base.ToMeet();
        }

        public override void RanAway()
        {
            Console.WriteLine($"I ran away from Grandfather, I ran away from Grandmother.");
        }

        public void RunFromYou()
        {
            Console.WriteLine($"And I can run away from you, {Character}!");
        }
    }
}
