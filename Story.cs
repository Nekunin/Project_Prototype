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
        int observationcount = 0;
        public string Location = "Starting Area";
        public void StartingGame(Hero MainChara)
        {
            Console.Clear();
            Console.WriteLine($"Welcome to a new world!");
            if (MainChara.Name == "Reset")
            {
                Console.WriteLine($"You are a young priestess named {MainChara.Name}");
                Console.WriteLine("Your strength is comparable to a wet noodle, and your defense is akin to a sheet of paper");
                Console.WriteLine("Taking hits could be fatal for you!");
                Console.WriteLine("your true strength lies in your explosive magical power and super human speed");
                Console.WriteLine("make sure to stock up on magic potions and buy protective equipment that won't hinder your speed");
            }
            else
            {
                Console.WriteLine($"You are a young warrior named {MainChara.Name}");
                Console.WriteLine("You might not be the brightest tool in the shed, but your strength and toughness knows no bounds.");
                Console.WriteLine("Some enemies are immune to physical attacks so you should stock up bombs");
                Console.WriteLine("Focus on getting stronger weapons and you will succeed, as long as you don't get unlucky");

            }
            Console.WriteLine("I pray for your good fortune.");
            Console.ReadLine();

            //designed so that everytime you press h it will show you the current hp, mp and your name, but it makes the game extremely slow so I cutted it
            //HeroInterface.CharacterInfo HeroMenu = new HeroInterface.CharacterInfo(MainChara);
            //HeroMenu.start();
            //Console.Clear();
            string prompt = $"{MainChara.Name}'s Adventure";
            string[] options = { "Move", "Look", "Talk", "Inventory" };
            Menu DailyLifeMenu = new Menu(prompt, options);

            while (true)
            {
                int selectedIndex = DailyLifeMenu.Run();

                switch (selectedIndex)
                {
                    case 0:
                        Movement();
                        break;
                    case 1:
                        Observations();
                        break;
                    case 2:
                        Conversations();
                        break;
                    case 3:
                        Console.WriteLine("It has not been implemented yet");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
        private void Observations()
        {
            if (Location == "Starting Area")
            {
                if (observationcount == 0)
                {
                    Console.WriteLine("You see a small town");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine(@"XxXXXxx++;;;;;+;;;;;;;;;;;+++++;;::::::::::::::::::::::::::::+++xX+;;;;;;;;;;;++;;;;;;;::;;:::::::::
$XXXXX+;xx+;+;;++++X+;;;++++++++++++xx+;;;;;::::::::::::::::;xXXX$XX+::;+++;;+++++++++++::::::::::::
XXxXXXXXxXx++++++;++++;;++++++++++++xx+++;;;;::::;::::;++xXXX$$$$$$$$Xx+++++++++++++::::::::::::::::
XXX$$XX$XXXx+++x+++xx+;;;;+;++++++++++++++;;;++++++xXXX$$$$X$$$$$$$$$$$XXX++++;;+;;::::::::::::;;;;+
$$$$$$$$$$XX+xxXxXxxxx+;;;+++;;;;;;;++++++++++XXXX$$$$$$$$$XXXXX::;;XX$$$$XX++++++++;;:::::::;;;++++
$$$$$$$$$$XXXx++XxXxxX+;;;+;;;++++;;+++++xXX$$$$$$$XXXx+Xx:::;+XxXXxXX+x$$$$XX+xXXX+;;;;;+++xxXXXXXX
$$$$$XX$$$$XXXXXxX$XXx;;;;x;;;;;;;+++++++X$$$$XXXX$$$$$XXXxxx++X;;;;Xx;;;x++XXXX$$$XXx++xXXXXXXXXXXX
$$$XXXXX$$$XX$XXXXx+x+;::;+;;;;;;;;;;;+x$XXXXXXXXXxXX$XXXX$XXXxxxXXXXXx+XXXX$$$$X$$$$$XXXXXXXXXXXXXX
$$$$$$XXX$$XX$XXx+;:....::;;:;;;;;;;++$$$$XX++XXXXx+++++++XXxXXXxxxxxXXX$$$$$$$$$$$$$$$$$XXXXXXXXXXX
$$$$$$$$$$$$X$$X;:.......:;::::...:;$$$XXx;;++XXXxxxXXXXXXXXXX+xXXXX$$$XXXXXX$$x;::;X+X$$$XXXXXXXXXX
$$$$$$$$$$$$$XXX+::...::.:;::::::::;;Xx+++:+++XXXXXxXXXxxx+xXXXX$$$$$$$$$$$$XXx+;;;+X+;;+$$$$XXXXXXX
$$$$$$$$$$$X$XXXX++++;:..:;;;;;;;;;::;;;;+++++XXXXXXX++XXXXX$$$XXXXXXXX;:;;::+x;:;;+X++++xxX$$$$XXXX
$$$$$$$$$$$XXXXXXxxx+++++;;;:;;;;;;;;;;;;++;++XXX++XXX$$$$$$$$$$$$Xx+++;;;;::+x::::;X+::;++;;+X$$$$$
$$$$$$$XXX$XXX$XXXxxxx++x++++++;;;:::;;;;+;++++xxX$$$$$XXXxXx++;;+x++++++++++x+++xxxxxxxxx++++++X$$$
$$$$$$$XXXX$$$$$XXXX$XXxx+++++++++xxx;;;;xxxxX$$$$$$$$$XXXX$$XXxX$$$$$$$$$XXXXXxxxx+++++++++;+$$$$$$
XXxXXXXXXXxXXX$$XXXXXXXXXxxXXxxxxxxX+;;+X+xX$X$XXXXXXXxX+xX$$XX$$$$$$$$$$$$$$$$$$$$$$$$$$$$&&&$xXXXx
XxxXXXXxXXXxxxxXXXXxxxXXXXXXXXXXxxxxxX$$XXXXXXxXx+++++$XXXX$XXXXX$$X$$$$$$$$$$$$$$$$$$$$$$$$$$$XxXXX
XXXX;++XXXxxx+;;;xXXXXXxx+++xXXx+xXXx+;++;;::++x:;;+++XXXXXXXXXXXXXXXXXXXXXXXXXXX$$XXXXXX$XXXXXxXXXX
x+XXX;:+X++x+++++;:::;++Xxxx+x;;++++++;+++;;;++x:;;+++XXX$XXXxXXX$XXXXXXXXXXXXXXXXXXXXXX$$XXXXXXxXXX
X+xxXx;;;;+++++;+;:    .:;;:;++;;;++++;++++++++x;;;+++XXX$XXXXXXXXXXXx;;+;;++xXXXXXXXXX$$$XXXXXXXXxX
++X+;;++;;++X+++x+.   ...;+x+xXXXxXx++;++++++x++++;+++XXX$X$XXXXXXXXXx;+x+++xxxXXX$XXXXXX$$XxXXxxXXX
;;;x++xxx+xxxxXX+:.......:;xXXX+++;:::::++++++;+XXX++xXXX$X$XXXXXXXXX+;+xxXX+XXX$$$XXXX$X$X$XXXXXXXX
X+;X$$XXxXX$X$x;:..........:+x;:+X+::::;+;::;+;:XXX++x$X$$X$XXXXX$XXX++++++++x++XxX$$$$$$$$$XX$$$XXX
$$$$x+XxXX$$X+;:............:;+;++X$$+;:::::;;:.XXX++x$$XX$$XXXXX$$$$X$$$$$$$X+xX+X$$$$$$XXXXXXXXXX$
x+++XxX$XXX+;;::::..:::......::;++++xX$+;;::::::XXX;;+XXXXXx++++++++xxxXXXXxXX+XXxXxxxXXXXXxxxxxxxxx
XXXXXXXxX++;;::::::::::.::::.:::;+x+;++xXX+;::::::::;+++++++::;++xx++++xx++++++++++;;+++++xxxXX++xXX
xXXXxXX+++;;:::::::::::::::::::::;+xx+;+xXX$$x;+++;:::::::;+++xxXXX$Xxx++;;+++;:;;++++;;::::::::::;+
xX$XX++++;;::::::::::::::::::::::::;++x++++xXXXXx;:;+++++xXXx+;;:::::::::..::..:::;;;+++xXx++++++xXx
XXx+++++;;;::::::::::::::::::::::::::;++xx++++XXx+;:::..::..:....:::::::::::::::;++++xx;;;++++Xxx++x
Xx+x+++++;;::::::::::::::::::::::::::::;+;;:.................:.::;+;+;+++++;+xx++xXxx;;;;xX+xxxXXXXX");
                    observationcount++;
                }
                else
                {
                    Console.WriteLine(@"XxXXXxx++;;;;;+;;;;;;;;;;;+++++;;::::::::::::::::::::::::::::+++xX+;;;;;;;;;;;++;;;;;;;::;;:::::::::
$XXXXX+;xx+;+;;++++X+;;;++++++++++++xx+;;;;;::::::::::::::::;xXXX$XX+::;+++;;+++++++++++::::::::::::
XXxXXXXXxXx++++++;++++;;++++++++++++xx+++;;;;::::;::::;++xXXX$$$$$$$$Xx+++++++++++++::::::::::::::::
XXX$$XX$XXXx+++x+++xx+;;;;+;++++++++++++++;;;++++++xXXX$$$$X$$$$$$$$$$$XXX++++;;+;;::::::::::::;;;;+
$$$$$$$$$$XX+xxXxXxxxx+;;;+++;;;;;;;++++++++++XXXX$$$$$$$$$XXXXX::;;XX$$$$XX++++++++;;:::::::;;;++++
$$$$$$$$$$XXXx++XxXxxX+;;;+;;;++++;;+++++xXX$$$$$$$XXXx+Xx:::;+XxXXxXX+x$$$$XX+xXXX+;;;;;+++xxXXXXXX
$$$$$XX$$$$XXXXXxX$XXx;;;;x;;;;;;;+++++++X$$$$XXXX$$$$$XXXxxx++X;;;;Xx;;;x++XXXX$$$XXx++xXXXXXXXXXXX
$$$XXXXX$$$XX$XXXXx+x+;::;+;;;;;;;;;;;+x$XXXXXXXXXxXX$XXXX$XXXxxxXXXXXx+XXXX$$$$X$$$$$XXXXXXXXXXXXXX
$$$$$$XXX$$XX$XXx+;:....::;;:;;;;;;;++$$$$XX++XXXXx+++++++XXxXXXxxxxxXXX$$$$$$$$$$$$$$$$$XXXXXXXXXXX
$$$$$$$$$$$$X$$X;:.......:;::::...:;$$$XXx;;++XXXxxxXXXXXXXXXX+xXXXX$$$XXXXXX$$x;::;X+X$$$XXXXXXXXXX
$$$$$$$$$$$$$XXX+::...::.:;::::::::;;Xx+++:+++XXXXXxXXXxxx+xXXXX$$$$$$$$$$$$XXx+;;;+X+;;+$$$$XXXXXXX
$$$$$$$$$$$X$XXXX++++;:..:;;;;;;;;;::;;;;+++++XXXXXXX++XXXXX$$$XXXXXXXX;:;;::+x;:;;+X++++xxX$$$$XXXX
$$$$$$$$$$$XXXXXXxxx+++++;;;:;;;;;;;;;;;;++;++XXX++XXX$$$$$$$$$$$$Xx+++;;;;::+x::::;X+::;++;;+X$$$$$
$$$$$$$XXX$XXX$XXXxxxx++x++++++;;;:::;;;;+;++++xxX$$$$$XXXxXx++;;+x++++++++++x+++xxxxxxxxx++++++X$$$
$$$$$$$XXXX$$$$$XXXX$XXxx+++++++++xxx;;;;xxxxX$$$$$$$$$XXXX$$XXxX$$$$$$$$$XXXXXxxxx+++++++++;+$$$$$$
XXxXXXXXXXxXXX$$XXXXXXXXXxxXXxxxxxxX+;;+X+xX$X$XXXXXXXxX+xX$$XX$$$$$$$$$$$$$$$$$$$$$$$$$$$$&&&$xXXXx
XxxXXXXxXXXxxxxXXXXxxxXXXXXXXXXXxxxxxX$$XXXXXXxXx+++++$XXXX$XXXXX$$X$$$$$$$$$$$$$$$$$$$$$$$$$$$XxXXX
XXXX;++XXXxxx+;;;xXXXXXxx+++xXXx+xXXx+;++;;::++x:;;+++XXXXXXXXXXXXXXXXXXXXXXXXXXX$$XXXXXX$XXXXXxXXXX
x+XXX;:+X++x+++++;:::;++Xxxx+x;;++++++;+++;;;++x:;;+++XXX$XXXxXXX$XXXXXXXXXXXXXXXXXXXXXX$$XXXXXXxXXX
X+xxXx;;;;+++++;+;:    .:;;:;++;;;++++;++++++++x;;;+++XXX$XXXXXXXXXXXx;;+;;++xXXXXXXXXX$$$XXXXXXXXxX
++X+;;++;;++X+++x+.   ...;+x+xXXXxXx++;++++++x++++;+++XXX$X$XXXXXXXXXx;+x+++xxxXXX$XXXXXX$$XxXXxxXXX
;;;x++xxx+xxxxXX+:.......:;xXXX+++;:::::++++++;+XXX++xXXX$X$XXXXXXXXX+;+xxXX+XXX$$$XXXX$X$X$XXXXXXXX
X+;X$$XXxXX$X$x;:..........:+x;:+X+::::;+;::;+;:XXX++x$X$$X$XXXXX$XXX++++++++x++XxX$$$$$$$$$XX$$$XXX
$$$$x+XxXX$$X+;:............:;+;++X$$+;:::::;;:.XXX++x$$XX$$XXXXX$$$$X$$$$$$$X+xX+X$$$$$$XXXXXXXXXX$
x+++XxX$XXX+;;::::..:::......::;++++xX$+;;::::::XXX;;+XXXXXx++++++++xxxXXXXxXX+XXxXxxxXXXXXxxxxxxxxx
XXXXXXXxX++;;::::::::::.::::.:::;+x+;++xXX+;::::::::;+++++++::;++xx++++xx++++++++++;;+++++xxxXX++xXX
xXXXxXX+++;;:::::::::::::::::::::;+xx+;+xXX$$x;+++;:::::::;+++xxXXX$Xxx++;;+++;:;;++++;;::::::::::;+
xX$XX++++;;::::::::::::::::::::::::;++x++++xXXXXx;:;+++++xXXx+;;:::::::::..::..:::;;;+++xXx++++++xXx
XXx+++++;;;::::::::::::::::::::::::::;++xx++++XXx+;:::..::..:....:::::::::::::::;++++xx;;;++++Xxx++x
Xx+x+++++;;::::::::::::::::::::::::::::;+;;:.................:.::;+;+;+++++;+xx++xXxx;;;;xX+xxxXXXXX");
                }
            }
        }
        private void Conversations()
        {
            if (Location == "Starting Area")
            {
                Console.WriteLine("There is no one to talk to");
            }

        }
        private void Movement()
        {
            if (observationcount == 0)
            {
                Console.WriteLine("You don't know where to go");
                Console.WriteLine();
                Console.WriteLine("Maybe if you were to take a look at your surroundings...");
            }
            if (observationcount > 0)
            {
                string FirstPrompt = "Where should I go?";
                string[] FirstOptions = { "Don't Move", "Town" };
                Menu FirstDisplacement = new Menu(FirstPrompt, FirstOptions);
                int selectedIndex = FirstDisplacement.Run();

                switch (selectedIndex)
                {
                    case 0:
                        Console.WriteLine("There is nothing to do here though?");
                        break;
                    case 1:
                        Console.WriteLine("it has not been implemented yet");
                        break;
                }
            }
        }
    }
}


