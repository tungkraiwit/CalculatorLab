using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPE200Lab1
{
    public class RPNCalculatorEngine :CalculatorEngine 
    {
        public string Process(string str)
        {
            // your code here
            Stack<string> strsum = new Stack<string>();
            string[] parts;
            string firstOperand;
            string secondOperand;
            parts = str.Split(' ');
            for (int i = 0; i < parts.Length; i++)
            {
                if (isNumber(parts[i]) && parts.Length >=3 )
                {
                    strsum.Push(parts[i]);
                }
                else if(strsum.Count >=2 )
                {
                    secondOperand = strsum.Pop();
                    firstOperand = strsum.Pop();
                    strsum.Push(calculate(parts[i], firstOperand, secondOperand));
                }
                else if (strsum.Count == 1 && i == parts.Length-1 && !isOperator(parts[i]))
                {
                    return strsum.Pop();
                }
                else
                {
                    return "E";
                }
            }
            if (strsum.Count == 1 )
            {
                return strsum.Pop();
            }
            return "E";
        }
    }
}
