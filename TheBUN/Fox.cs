using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBUN
{
    public class Fox : Bear
    {
        public Fox() : base()
        {
            Character = "Old Fox";
        }

        public override void RanAway()
        {
            base.RanAway();
            Console.WriteLine("I ran away from Bear.");
        }

        public override void ToMeet()
        {
            base.ToMeet();
        }

        public override void WantsToEat()
        {
            base.WantsToEat();
        }
    }
}
