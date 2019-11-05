using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Sentence : Text 
    {
        string sent = "";
        int j = 0,k=0;
        public void Processing(string stroka)
        {
            for (int i = 0; i < stroka.Length; i++)
            {
                if (stroka[i] != '.' && stroka[i]!='!' && stroka[i]!='?')
                {
                    if (stroka[i]!=' ') {  sent += stroka[i]; listwordsinsentences[j]++; }
                    else { if (stroka[i - 1] != ' ') { sent += stroka[i]; k++; } }
                }
                else
                {
                    sent += stroka[i];
                    sentences.Add(sent);
                    listwordsinsentences.Add(k);
                    k = 0;
                    sent = "";
                    j++;
                }
            }
            int[] wordsinsemtences = listwordsinsentences.ToArray<int>();
            Array.Sort(wordsinsemtences);
            
        }
    }
}
