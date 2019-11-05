using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class IOC
    {
        public string Messeges(string path)
        {
            Console.WriteLine("Enter the path to the file:");
            path=Console.ReadLine();
            return path;
        }


        public int OutputMenu()
        {
            int count = 0;

            try
            {
                Console.WriteLine("Select menu item:\n 1-Ascending words in a sentence\n 2-Read from file\n 0-Exit from the program");
                count = int.Parse(Console.ReadLine());
                if ((count != 1) && (count != 2) && (count != 3) && (count != 4) && (count != 0))
                {
                    throw new Exception("Please input 1,2 or 3 !");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");

            }

            return count;
        }



        public void Output(string output)
        {
            Console.WriteLine(output);
        }




    }
}
