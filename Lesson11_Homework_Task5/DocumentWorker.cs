using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_Homework_Task5
{
    class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Документ відкритий.");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редагування документа є у версії Про.");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Збереження документа є у версії Про.");
        }
    }
}
