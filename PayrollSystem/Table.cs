using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    class Table
    {
        static readonly int tableWidth = 73;

        public void ViewTable( string[] columNames, string[] data)
        {
            string[] arr = new string[data.Length]; 
            for (int i=0; i < data.Length; i++)
            {
                arr[i] = "";
            }
            Console.WriteLine("\n");
            PrintLine();
            PrintRow(columNames);
            PrintLine();
            PrintRow(data);
            PrintRow(arr);
            PrintLine();
            Console.ReadLine();
        }

        static void PrintLine()
        {
            Console.WriteLine(new string('*', tableWidth));
        }

        static void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }

        static string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
    }
}
