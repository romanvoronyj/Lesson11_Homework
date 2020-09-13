using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_Homework_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Pupil badPupil = new BadPupil();
            badPupil.Study();
            badPupil.Read();
            badPupil.Write();
            badPupil.Relax();

            Pupil goodPupil = new GoodPupil();
            goodPupil.Study();
            goodPupil.Read();
            goodPupil.Write();
            goodPupil.Relax();


            Pupil excelentPupil = new ExcelentPupil();
            excelentPupil.Study();
            excelentPupil.Read();
            excelentPupil.Write();
            excelentPupil.Relax();


            //ClassRoom myClassroom = new ClassRoom(new Pupil[3]); - до кінця не зміг розібратись


            Console.ReadKey();
        }

    }
}
