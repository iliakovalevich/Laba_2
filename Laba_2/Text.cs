using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Text
    {
       protected List<string> sentences = new List<string>();
       protected List<int> listwordsinsentences = new List<int>();
       string textWithoutSpaces = "";



        public void DeleteSpaces(string stroka)
        {

            for (int i = 0; i < stroka.Length - 1; i++)
            {
                if (stroka[i] != ' ')
                {
                    textWithoutSpaces += stroka[i];
                }
                else
                {
                    if (stroka[i] == ' ' && stroka[i + 1] != ' ')
                    {
                        textWithoutSpaces += stroka[i];
                    }
                }
            }
            
        }
    }
}
