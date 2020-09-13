using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_Homework_Task4
{
    class Program
    {
        /*Створити клас Vehicle.
     У тілі класу створіть поля: координати і параметри засобів пересування (ціна, швидкість, рік випуску).
     Створіть 3 похідних класу Plane, саг і Ship.
     Для класу Plane повинна бути визначена висота і кількість пасажирів.
     Для класу Ship - кількість пасажирів і порт приписки.
     Написати програму, яка виводить на екран інформацію про кожний засіб пересування.
*/
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Plane myPlane = new Plane();
            myPlane.price = 2000000;
            myPlane.maxSpeed = 1080;
            myPlane.productionYear = 2017;
            myPlane.height = 4.5;
            myPlane.passengerQuantity = 9;
            myPlane.ShowInfo();

            Car myCar = new Car();
            myCar.price = 60000;
            myCar.maxSpeed = 250;
            myCar.productionYear = 2018;
            myCar.ShowInfo();
            

            Ship myShip = new Ship();
            myShip.price = 100000000;
            myShip.maxSpeed = 40;
            myShip.productionYear = 2013;
            myShip.passengerQuantity = 1950;
            myShip.homePort = "Rotterdam";
            myShip.ShowInfo();

            Console.ReadKey();
        }
    }
}
