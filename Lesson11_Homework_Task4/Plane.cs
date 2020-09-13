using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_Homework_Task4
{
    class Plane : Vehicle
    {
        public double height;
        public int passengerQuantity;
        public void ShowInfo()
        {
            Console.Write("Ціна літака: {0}\nМаксимальна швидкість: {1} км/год\nРік випуску: {2}\nВисота: {3}\nПасажиромісткість: {4}.\n\n", price, maxSpeed, productionYear, height, passengerQuantity);
        }

    }
}
