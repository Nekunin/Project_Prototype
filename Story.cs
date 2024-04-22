using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Project_Prototype
{
    public class Story
    {
        public void StartingGame(Hero MainChara)
        {
            Console.WriteLine($"Welcome to a new world your name is {MainChara.Name}!");
            if ( MainChara.Name == "Reset") {
                Console.WriteLine("Your physical capabilities are low, but your magic and speed are high");
                Console.WriteLine("The key to your success lies within the correct usage of your magic points");
                Console.WriteLine("since your defenses are extremely low, buying an armor should be your priority");
            }
            else
            {
                Console.WriteLine("while your magic and speed are mediocre, your strenght and toughness knows no bounds.");
                Console.WriteLine("Some enemies are immune to physical attacks so you should stock up items that produce magical damage.");
                Console.WriteLine("Focus on getting stronger weapons and you will succeed, as long as you don't get unlucky");

            }
        }

    }
}
