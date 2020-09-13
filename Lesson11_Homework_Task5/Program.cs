using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_Homework_Task5
{
    class Program
    {
        /*Створити клас DocumentWorker.
        У тілі класу створіть три методу OpenDocument (), EditDocument (), SaveDocument ().
     У тіло кожного з методів додайте вивід на екран відповідних рядків: "Документ відкритий",
     "Редагування документа є у версії Про", "Збереження документа є у версії Про".
     Створіть похідний клас ProDocumentWorker.
     Перевизначите відповідні методи, при перевизначенні методів виводите наступні рядки:
     "Документ відредагований", "Документ збережений в старому форматі, збереження в інших форматах є в версії Експерт".

     Створіть похідний клас ExpertDocumentWorker від базового класу ProDocumentWorker. Перевизначите відповідний метод. 
     При виклику даного методу необхідно виводити на екран "Документ збережений в новому форматі".
     У тілі методу Main () реалізуйте можливість прийому від користувача номера ключа доступу pro і exp. 
     Якщо користувач не вводить ключ, він може користуватися тільки безкоштовною версією (створюється екземпляр базового класу), 
     якщо користувач ввів номера ключа доступу pro і exp, то повинен створитися екземпляр відповідної версії класу, приведений до базового - DocumentWorker.
     */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            DocumentWorker docWorker = new DocumentWorker();
            ProDocumentWorker proDocWorker = new ProDocumentWorker();
            ExpertDocumentWorker expDocWorker = new ExpertDocumentWorker();




            var keyDemo = 1010;
            var keyPro = 8888;
            var keyExp = 1111;


            Console.WriteLine("Увага! Для Вас доступна демо-версія програми. Редагування та збереження документа доступне у версіях PRO та EXPERT.\nДля продовження роботи у демо-версії натисніть 1010.");
            Console.Write("Для переходу до версії PRO або EXP введіть ключ:");
            int key = Int32.Parse(Console.ReadLine());
            if (key == keyDemo)
            {
                docWorker.OpenDocument();
                docWorker.EditDocument();
                docWorker.SaveDocument();

                Console.Write("\nДля переходу до версій PRO або EXP введіть ключ:");
                key = Int32.Parse(Console.ReadLine());
                if (key == keyPro )
                {
                    Console.WriteLine("Вітаємо, Ви увійшли у PRO версію програми!");
                    proDocWorker.EditDocument();
                    proDocWorker.SaveDocument();
                    Console.Write("\nДля переходу до версії EXPERT введіть ключ:");
                    key = Int32.Parse(Console.ReadLine());
                    if (key == keyExp)
                    {
                        Console.WriteLine("Вітаємо, Ви увійшли у PRO версію програми!");
                        expDocWorker.SaveDocument();
                    }
                    else
                    {
                        Console.WriteLine("Ви ввели невірний ключ!");
                    }
                }
                else if (key == keyExp)
                {
                    Console.WriteLine("Вітаємо, Ви увійшли у PRO версію програми!");
                    expDocWorker.OpenDocument();
                    expDocWorker.EditDocument();
                    expDocWorker.SaveDocument();
                }
                else if (key != keyExp && key !=keyPro)
                {
                    Console.WriteLine("Ви ввели невірний ключ!");
                }
            }
            else if(key == keyPro )
            {
                Console.WriteLine("Вітаємо, Ви увійшли у PRO версію програми!");
                proDocWorker.OpenDocument();
                proDocWorker.EditDocument();
                proDocWorker.SaveDocument();
                Console.Write("\nДля переходу до версії EXPERT введіть ключ:");
                key = Int32.Parse(Console.ReadLine());
                if (key == keyExp)
                {
                    Console.WriteLine("Вітаємо, Ви увійшли у EXPERT версію програми!");
                    expDocWorker.SaveDocument();
                }

            }
            else if (key == keyExp)
            {
                Console.WriteLine("Вітаємо, Ви увійшли у EXPERT версію програми!");
                expDocWorker.OpenDocument();
                expDocWorker.EditDocument();
                expDocWorker.SaveDocument();
            }
            Console.ReadKey();

        }
    }
}