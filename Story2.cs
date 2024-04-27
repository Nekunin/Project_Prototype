﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Prototype
{
    internal class Story2
    {
        MoneyManager moneyManager = MoneyManager.GetInstance();
        int observationcount = 0;
        public string Location = "Main Town";
        public int talkcount = 0;
        int lookcount = 0;
        public void Secondpart(Hero MainChara)
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
                Console.Clear();
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
            string prompt = $"{MainChara.Name}'s Adventure";
            string[] townoptions = { "Move", "Look", "Talk", "Inventory" };
            Menu TownMenu = new Menu(prompt, townoptions);

            while (true)
            {
                int selectedIndex = TownMenu.Run();

                switch (selectedIndex)
                {
                    case 0:
                        Movement();
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
                        Inventory(MainChara);
                        break;
                }
            }
        }
        private void Movement()
        {
            if (talkcount == 0)
            {
                Console.WriteLine("You don't know anything about the town");
                Console.WriteLine("It would be wise to ask someone near you...");
                Console.ReadLine();
            }
            if (talkcount == 1)
            {
                Console.WriteLine("Not Implemented Yet");
                Console.ReadLine();
            }

        }
        private void Conversations(Hero MainChara)
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
                        moneyManager.AddMoney(100);
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
        private void Observations()
        {
            Console.WriteLine("Seems like a peacefull town");
            Console.WriteLine("The guard appears to be slacking");
            Console.ReadLine();
        }
        private void Inventory(Hero MainChara)
        {
            string InventoryP = $@"{MainChara.name}'s Inventory
HP [{MainChara.MaxHP}/{MainChara.HP}] MP [{MainChara.MaxMP}/{MainChara.MP}]
 Gold [To be Implemented Later]";
            string[] InventoryO = { "Items", "Equipment", "Key Items" };
            Menu InventoryMenu = new Menu(InventoryP, InventoryO);
            while (true)
            {
                int Inv_selectedIndex = InventoryMenu.Run();

                switch (Inv_selectedIndex)
                {
                    case 0:
                        Console.WriteLine("Not Implemented Yet");
                        break;
                    case 1:
                        Console.WriteLine("Not Implemented Yet");
                        break;
                    case 2:
                        Console.WriteLine("Not Implemented Yet");
                        break;
                }
            }
        }
        public void Equipment(Hero MainChara)
        {
            string EquipmentP = $"{MainChara.name}'s Inventory";
            string[] EquipmentO = { "Weapon", "Armor", "Boots", "Accesory" };
            Menu Equip = new Menu(EquipmentP, EquipmentO);
            while (true)
            {
                int selectedIndex = Equip.Run();

                switch (selectedIndex)
                {
                    case 0:
                        Console.WriteLine("Not Implemented Yet");
                        break;
                    case 1:
                        Console.WriteLine("Not Implemented Yet");
                        break;
                    case 2:
                        Console.WriteLine("Not Implemented Yet");
                        break;
                }
            }
        }
        public void EquipWeapon(Hero MainChara, Weapons X)
        {
            if 
        }
    }
}
