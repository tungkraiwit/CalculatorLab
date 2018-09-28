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
            parts = str.Split(' ');
            for (int i = 0; i < parts.Length; i++)
            {
                if (isNumber(parts[i]))
                {
                    strsum.Push(parts[i]);
                }
                else if (isOperator(parts[i]))
                {
                    if(strsum.Count < 2)
                    {
                        return "E";
                    }
                    else
                    {
                        string secondOperand = strsum.Pop();
                        string firstOperand = strsum.Pop();
                        strsum.Push(calculate(parts[i], firstOperand, secondOperand,4));
                    }                    
                }
            }
            if (strsum.Count == 1)
            {
                return strsum.Pop().ToString();
            }
            return "E";
        }
    }
}
