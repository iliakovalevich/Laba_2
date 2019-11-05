using ConsoleApp1;
using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//new commit
namespace Laba_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = "";
                string stroka = "";
                int count = 0;
                IOF iof = new IOF();
                IOC ioc = new IOC();
                Symbol symbol = new Symbol();
                Sentence sentence = new Sentence();
                Text text = new Text();
                path = ioc.Messeges(path);
                stroka = iof.Read(path);
                ioc.Output(stroka);

                do
                {
                    count = ioc.OutputMenu();
                    switch (count)
                    {
                        case 1:
                            text.DeleteSpaces(stroka);
                            Console.WriteLine(text);
                            sentence.Processing(stroka);
                            break;
                        case 0:
                            return;
                    }
                } while (count != 0);


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
