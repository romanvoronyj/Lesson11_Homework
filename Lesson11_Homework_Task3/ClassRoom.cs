using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_Homework_Task3
{
    /*Створити клас, що представляє навчальний клас ClassRoom.Створіть клас учень Pupil.У тілі класу створіть методи void Study (), void Read (), void Write (), void Relax ().
Створіть 3 похідних класу ExcelentPupil, GoodPupil, BadPupil відбазового класу Pupil і перевизначите кожен з методів, в залежності від успішності учня.
Конструктор класу ClassRoom приймає аргументи типу Pupil, клас повинен складатися з 4 учнів.
Передбачте можливість того, що користувач може передати 2 або 3 аргументу.
Виведіть інформацію про те, як всі учні класу ClassRoom вміють вчитися, читати, писати, відпочивати.
    */

    class ClassRoom
    {
        public Pupil[] pupils;

        public ClassRoom(Pupil[]pupil)
        {
            this.pupils = pupil ;
        }
    }
}
