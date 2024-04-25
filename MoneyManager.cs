using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Prototype
{
    public class MoneyManager
    {
        private static MoneyManager ActualMoney;
        private int money;

        private MoneyManager(int startingMoney)
        {
            money = startingMoney;
        }
        public int GetMoney()
        {
            return money;
        }
        public static MoneyManager GetInstance()
        {
           if (ActualMoney == null) 
            {
                ActualMoney = new MoneyManager(100);
            }
            return ActualMoney;
        }
        public void AddMoney(int amount)
        {
            money += amount;
        }
    }
}