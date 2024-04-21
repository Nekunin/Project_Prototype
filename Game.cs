using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Prototype
{
    class Game
    {
        public void start()
        {

            RunMainMenu();
        }
        private void RunMainMenu()
        {
            string prompt = @"

 _   .-')            _ .-') _           _  .-')     _ (`-.                   
( '.( OO )_         ( (  OO) )         ( \( -O )   ( (OO  )                  
 ,--.   ,--.)    ,--.\     .'_          ,------.  _.`     \  ,----.          
 |   `.'   | .-')| ,|,`'--..._)   .-')  |   /`. '(__...--'' '  .-./-')       
 |         |( OO |(_||  |  \  ' _(  OO) |  /  | | |  /  | | |  |_( O- )      
 |  |'.'|  || `-'|  ||  |   ' |(,------.|  |_.' | |  |_.' | |  | .--, \      
 |  |   |  |,--. |  ||  |   / : '------'|  .  '.' |  .___.'(|  | '. (_/      
 |  |   |  ||  '-'  /|  '--'  /         |  |\  \  |  |      |  '--'  |       
 `--'   `--' `-----' `-------'          `--' '--' `--'       `------'        
Welcome to MJD-RPG, what would you like to do?
(Hint: use the arrow keys)";
            string[] options = { "Play", "Help", "Exit" };

            Menu mainMenu = new Menu(prompt, options);
            int SelectedIndex = mainMenu.Run();

            switch (SelectedIndex)
            {
                case 0:
                    Play();
                    break;
                case 1:
                    Help();
                    break;
                case 2:
                    ExitGame();
                    break;
            }
        }
        private void ExitGame()
        {
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
            //Close the console app 
            Environment.Exit(0);
        }
        private void Help()
        {
            Console.Clear();
            Console.WriteLine("Text based game");
            Console.WriteLine("controls using the menu, you select your choices using the arrow key and enter");
            Console.WriteLine("use the move function to go to the dungeon");
            Console.WriteLine("if your HP reaches 0 you will be sent back to the menu");
            Console.WriteLine("Press any key to return to the main menu");
            Console.ReadKey(true);
            RunMainMenu();
        }
        private void Play()
        {
            Console.WriteLine("we will add something later");
            ExitGame();
        }
    }
}
