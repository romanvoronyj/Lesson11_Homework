using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_Homework_Task3
{
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Cхильність учня до навчання: погана.");
        }
        public override void Read()
        {
            Console.WriteLine("Cхильність учня до читання: погана.");
        }
        public override void Write()
        {
            Console.WriteLine("Cхильність учня до письма: погана.");
        }
        public override void Relax()
        {
            Console.WriteLine("Cхильність учня до відпочинку: погана.");
        }

    }
}
