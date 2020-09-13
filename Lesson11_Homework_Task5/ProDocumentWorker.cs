using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_Homework_Task5
{
    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ відредагований.");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Документ збережений в старому форматі, збереження в інших форматах є в версії Експерт.");
        }

    }
}
