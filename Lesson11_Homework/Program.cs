using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть будь-який текст: ");
            string valueUser = Console.ReadLine();
            Console.WriteLine();

            Printer myPrinter = new Printer();
            myPrinter.Print(valueUser);

            PrinterRed myPrinterRed = new PrinterRed();
            Printer printerRedColour = myPrinterRed;
            PrinterRed printerRed = (PrinterRed)printerRedColour;//upcast !!!
            printerRed.Print(valueUser);

            PrinterYellow myPrinterYellow = new PrinterYellow();
            Printer printerYellowColour = myPrinterYellow;
            PrinterYellow printerYellow = (PrinterYellow)printerYellowColour;
            printerYellow.Print(valueUser);

            Console.ReadKey();

        }
    }
}
