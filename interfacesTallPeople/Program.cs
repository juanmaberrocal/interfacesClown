using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacesTallPeople
{
    class Program
    {
        static void Main(string[] args)
        {
            TallGuy tallguy = new TallGuy() { Name = "Jimmy", Height = 74 };
            tallguy.TalkAboutYourself();
            tallguy.Honk();
        }
    }
}
