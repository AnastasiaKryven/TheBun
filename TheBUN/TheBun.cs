using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBUN
{
    public class TheBun: IGrandfather, IGrandmother
    {

        public string Character { get; set; }
       
        public virtual void WantsToEat()
        {
            Console.WriteLine("One day the old man says to his wife «Please, bake me a bun».");
        }

        public void Recipe()
        {
            Console.WriteLine("The old woman takes some flour, some sour cream, some butter and some water,\n and makes a bun. She puts it on the windowsill to cool.");
        }

        public virtual void RanAway()
        {
            Console.WriteLine("But the bun cannot sit on the windowsill! It jumps from the windowsill\n to the bench, from the bench to the floor, from the floor to the door,\n and runs away.");
        }

        public virtual void ToMeet()
        {
            Console.WriteLine($"The bun runs along the road and meets a {Character}");
        }
    }
}
