using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBUN
{
    public class Bear : Wolf
    {
        public Bear() : base()
        {
            Character = "Big Bear";
        }

        public override void RanAway()
        {
            base.RanAway();
            Console.WriteLine("I ran away from Wolf.");
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
