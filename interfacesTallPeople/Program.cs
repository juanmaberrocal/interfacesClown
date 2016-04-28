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
            ScaryScary fingersTheClown = new ScaryScary("big shoes", 14);
            FunnyFunny someFunnyClown = fingersTheClown;
            IScaryClown someOtherScaryClown = someFunnyClown as IScaryClown;
            someOtherScaryClown.Honk();
            someOtherScaryClown.ScareLittleChildren();
            Console.ReadKey();

            //TallGuy tallguy = new TallGuy() { Name = "Jimmy", Height = 74 };
            //tallguy.TalkAboutYourself();
            //tallguy.Honk();
        }
    }
}
