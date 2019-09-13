using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBUN
{
    public class Wolf : Hare
    {
        public Wolf() : base()
        {
            Character = "Grey Wolf";
        }

        public override void RanAway()
        {
            base.RanAway();
            Console.WriteLine("I run away from Hare.");
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
