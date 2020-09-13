using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_Homework_Task4
{
    class Car : Vehicle
    {
        public void ShowInfo()
        {
            Console.Write("Ціна автомобіля: {0}\nМаксимальна швидкість: {1} км/год\nРік випуску: {2}.\n\n", price, maxSpeed, productionYear);
        }
    }
}
