using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Project_Prototype
{
    internal class Story2
    {

        int observationcount = 0;

        public string Location = "Main Town";
        public static int talkcount = 0;
        int lookcount = 0;

        public void Secondpart(Hero MainChara, int x)
        {

            Console.Clear();
            Console.WriteLine("You reach the small town and are greeted by a guard");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(@"NNNNNNNNNX0kl:ckXNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNkodk0KKKKNNNXKOkdoloOXNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN
NNNNNNNNNX0xl:cdKNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNKdlddloxodxxxxxdolc:;:dKNNNNNNNNNNNNNNNNNNNNNNNNNNNNN
NNNNNNNNNKkdoccokXNNNNNNNNNNNNNNNNNNNNNNNNNNNNN0l:c:;:ccllccllclc;,,;;cxKNNNNNNNNNNNNNNNNNNNNNNNNNNN
NNNNNNNNXOdoc;;:lxKNNNNNNNNNNNNNNNNNNNNNNNNNNNKxl;;;;,:ll:::cclc;',,,''c0NNNNNNNNNNNNNNNNNNNNNNNNNNN
NNNNNNNN0dlcc:ccco0NNNNNNNNNNNNNNNNNNNNNNNNNNNXOo:;,..''',;:cc:;,;:::;;oKNNNNNNNNNNNNNNNNNNNNNNNNNNN
NNNNNNNNN0o::cccoOXNNNNNNNNNNNNNNNNNNNNNNNNNNNXxc;;,''.';;;:::::ccccccccdKNNNNNNNNNNNNNNNNNNNNNNNNNN
NNNNNNNNNXxc;::;:o0NNNNNNNNNNNNNNNNNNNNNNNNNNNKl..';:::clolc:::cccllllcccoOKK0KNNNNNNNNNNNNNNNNNNNNN
NNNNNNNNNXd::;;;:lONNNNNNNNNNNNNNNNNNNNNNNNNNNNx,;ccoooooolc:::clllollcc:;;;:dKWNXKKNNNNNNNNNNNNNNNN
NNNNNNNNNXdcl:;:ookNNNNNNNNNNNNNNNNNNNNNNNNNNNW0c'',:lllollcc:::ccccc::;;,',dK0xocckNNNNNNNNNNNNNNNN
NNNNNNNNNXOxl,;;ckKXWWNNNNNNNNNNNNNNNNNNNWWWWWWXo..';:clllc;:::;cc:::::::::cll;,,,:ONNNNNNNXXXNNNNNN
NNNNNNNNNNNXd,;;c0NNWNNWNNWWWWNNNNNNNNNNNWNNNNWNd'.,::::;,'.'::cccclccloxkxdlc::cccd0XKOxoc:;:xXNNNN
NNNNNNNNNNNNO:,;:kNWNNNNNNWWWWWWWNNNWWNNWWWNNWWNx,';c:;,'...,::;;ccllodxO0KKKOxdolc:::,'......,dXNNN
NNNNNNNNNNNN0c,:cxNNNNNWWWWWWWWNNNWWWNNNWWWWWWNXd;';;,'.....,,',;:::llllx0NWWXOoc;,'.........'.;kNNN
NNNNNNNNNNNWKl',,oXWNNWWWWWWWWWNNWWWWWNWNNWWN0dc,'','.     .'''',,,::;;:cokkddxxdl:;''''....',,'oXNN
NNNNNNNNNNNNXo'.'oXWNNWWWWWWWWWWWWWWWWWWWNWWNOl;''''...   ...''...,,,,;;;;;;cx0K0koc;,''....,;,'cKNN
NNNNNNNNNNNNNx,.'lXWNNNWWWWWWWNWWWWWWWWNWWWWNKdc:,'........',,...,;,;;;,,,;coxO0K0kdl:,'....,;;'lKNN
kkO0KKXNNNNNNk;''cKWWNNWNNNNNNNWWWWWWWWWWWWNOc..;;''..';c:;;::,..'..',,',,;:ldk0NNKkdc;''...';,:ONNN
lllooodONNNNNO;'':0WNNNNNNNNNNNNWWWWWWWNWNXk;...:lcc::clcc;;ll:;,. ..',;;;::loodxkkxdlc:;,...',lKNNN
ooooddokXNNNN0:'';kNNNNNNNNNNNNNNNNNNNNWNKx;..,lddolloxkko::cc:,. ':::ccccc;;;:lkXWWNKOxdl:,,,';xXNN
::::clokNNNNNKc'',xNNNNNNNNNNNNNNNNNNNNX0x;..coodxxxk0XNKdll::,...,ccl:,'''..,:oxOKNWNXKOxl:,;;;dXNN
cclccllkXNNNNKl'''oXNNNNNNNNNNNNNNNNNNN0xl'.ldlcdOO0KXNWKddo::,...........'',,;:cloxOKNXKOdc;,,;l0NN
llllllokXNNNNXo''.lKNNNNNNNNNNNNNNNNNNKxol;okdlokO00XNWWX0xl::;....    ..''',;;;;:cldkOkdl:,...,;o0N
lllllookXNNNNXd,'.:0NNNNNNNNNNNNNNNNNNNKKOxkocokO00KXNWWWXOo:;;'...    .'::;::;::::;;,'.       ...l0
lllc::cxXNNNNNx,'.;ONNNNNNNNNNNNNNNNNNNNNK0Ooldxk00KKKKOkdc;,','.      ..cc,'..''.......         .c0
llllc:lONNNNNNk;'.,xNNNNNNNNNNNNNNNNNNNNX00Ooodxkkkxdolc:;;;,'...       ................         .cK
llllloONNNNNNNO;'''dNNNNNNNNNNNNNNNNNNNNKkxc;;:cc:::::::::;;;'....        'codxxo:'......        .,x
lllccoONNNNNNN0:'''oXNNNNNNNNNNNNNNNNNNNOl;'....',,,;:::::;......         ,odkKNNKxc,.....      ...c
lllcclONNNNNNNKc'''lXNNNNNNNNNNNNNNNNNNXd,.,'....'',,,;;,,,'''''..       .;odkOOxo:,........    ...'");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("[Guard: Haven't seen your face before.");
            if (MainChara.name == "Reset")
            {
                Console.WriteLine("You do know that there are no Gods in these lands right?");
                Console.WriteLine("why is there a sister like yourself over here?]");
                Console.ReadLine();
                Console.WriteLine("You explain your situation");
                Console.ReadLine();
                Console.WriteLine("very well go on!");
                Console.WriteLine("You have been granted access to the city");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Guard: Can't say I remember seeing you before");
                Console.WriteLine("Guard: But people like you are sent to die in that cursed forest everyday");
                Console.WriteLine("I will grant you access because you look stupid");
                Console.ReadLine();
                Console.WriteLine("You are offended but grateful nonetheless");
                Console.ReadLine();
            }
            Town(MainChara);
        }
        public static void Town(Hero MainChara) 
        {
        string prompt = $"{MainChara.Name}'s Adventure";
            string[] townoptions = { "Move", "Look", "Talk", "Inventory" };
            Menu TownMenu = new Menu(prompt, townoptions);

            while (true)
            {
                int selectedIndex = TownMenu.Run();

                switch (selectedIndex)
                {
                    case 0:
                        Movement(MainChara);
                        break;
                    case 1:
                        Observations();
                        break;
                    case 2:
                        if (talkcount == 0)
                        {
                            Conversations(MainChara);
                            talkcount++;
                        }
                        else
                        {
                            if (talkcount >= 1)
                            {
                                if (MainChara.Name == "Leon")
                                {
                                    Console.WriteLine("[Guard: Back so soon? don't worry about the money");
                                    Console.WriteLine("I would have probably spent it on booze either way]");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.WriteLine("[Guard: Glad to see you are still alive miss]");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                            }
                        }
                        break;
                    case 3:
                        Inventory_Equipment.Inventory(MainChara);
                        break;
                }
            }
        }
        public static void Movement(Hero MainChara)
        {
            if (talkcount == 0)
            {
                Console.WriteLine("You don't know anything about the town");
                Console.WriteLine("It would be wise to ask someone near you...");
                Console.ReadLine();
            }
            if (talkcount == 1)
            {
                string FirstPrompt = "Where should I go?";
                string[] FirstOptions = { "Don't Move", "Shop", "Inn", "Forest of Despair" };
                Menu FirstDisplacement = new Menu(FirstPrompt, FirstOptions);
                int selectedIndex = FirstDisplacement.Run();
                switch (selectedIndex)
                {
                    case 0:
                        return;
                    case 1:
                        Shop.shop(MainChara);
                        break;
                    case 2:
                        Console.WriteLine("Welcome!");
                        Console.WriteLine("would you like to spend 50 GOLD to stay for the night?");
                        Console.ReadLine();
                        string prompt = "ANSWER";
                        String[] options = { "Yes", "No" };
                        Menu INN = new Menu(prompt, options);
                        int index = INN.Run();
                        switch (index)
                        {
                            case 0:
                                if (MainChara.MONEY >= 50) 
                                {
                                    MainChara.HP = MainChara.MaxHP;
                                    MainChara.MP = MainChara.MaxMP;
                                    MainChara.MONEY -= 50;
                                    Console.WriteLine("Thanks for satying with us!");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("I am sorry it seems that you are broke");
                                    Console.WriteLine("Come back once you are able to pay");
                                    Console.ReadLine();
                                }
                                return;
                            case 1:
                                Console.WriteLine("Oh okay, come back if you change your mind!");
                                Console.ReadLine();
                                return;
                        }
                        return;
                    case 3:
                        Dungeon DespairForest = new Dungeon(MainChara, 50);
                        return;
                }
            }

        }
        private static void Conversations(Hero MainChara)
        {
            if (talkcount == 0)
            {
                Console.Clear();
                Console.WriteLine("[Guard: you are still here?");
                Console.WriteLine("Oh right you don't know anything about this town...");
                Console.WriteLine("if you take a right next to that house over there you will find a shop");
                Console.WriteLine("they have a great selection of equipment and items");
                Console.WriteLine("if you take a left instead you will find an inn; it is not cheap but you will regain your strength");
                Console.WriteLine("if you want to earn some money instead your best bet is leaving the town and going to the forest of despair]");
                Console.ReadLine();
                if (talkcount == 0)
                {
                    if (MainChara.Name == "Leon")
                    {
                        Console.WriteLine("[Guard: Here, I will lend you some money; you can pay me back later]");
                        Hero.AddMoney(MainChara, 100);
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("[Guard: I will lend you some money; you can pay me back later]");
                        Console.ReadLine();
                        Console.WriteLine("You reject the offer");
                        Console.ReadLine();
                        Console.WriteLine("Guard: Well I hope you don't come to regret your choice");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
            }
        }
        private static void Observations()
        {
            Console.WriteLine("Seems like a peacefull town");
            Console.WriteLine("The guard appears to be slacking");
            Console.ReadLine();
        }
    }
}
