using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Project_Prototype
{
    internal interface HeroInterface
    {
        public class CharacterInfo
        {
            private bool running = false;
            private Hero Player;
            public CharacterInfo(Hero Player)
            {
                this.Player = Player;
            }
            public void start()
            {
                running = true;
                Thread interfaceThread = new Thread(DisplayInterface);
                interfaceThread.Start();
            }
            private void DisplayInterface()
            {
                while (running)
                {
                    // this is so that everytime the player uses the spacebar the character name, hp and mp are displayed.
                    ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
                    if (KeyInfo.KeyChar == ' ')
                    {
                        Console.Write($"Name: [{Player.Name}] ");
                        Console.Write($"HP: [{Player.hp}/{Player.MaxHP}] ");
                        Console.WriteLine($"MP: [{Player.MP}/{Player.MaxMP}]");
                    }
                }
            }
        }
    }
}
