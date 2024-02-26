using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsAndLoops
{
    internal class CaseCheck
    {
        public void CheckCase(string text)
        {
            if(string.IsNullOrEmpty(text)) return;
            text = text.Trim(' ');
            char ch = text[0];
            if(ch>='a' && ch<='z')
            {
                Console.WriteLine("It is in Small case");
            }
            else if(ch>='A' && ch<='Z')
            {
                Console.WriteLine("It is in Upper case ");
            }
        }
    }
}
