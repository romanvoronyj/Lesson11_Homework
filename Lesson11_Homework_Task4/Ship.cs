using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_Homework_Task4
{
    class Ship : Vehicle
    {
        public int passengerQuantity;
        public string homePort;
        public void ShowInfo()
        {
            Console.Write("Ціна корабля: {0}\nМаксимальна швидкість: {1} км/год\nРік випуску: {2}\nПасажиромісткість: {3}\nПорт приписки: {4}.", price, maxSpeed, productionYear, passengerQuantity, homePort);
        }
    }
}
