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
            string sum;
            string firstOperand;
            string secondOperand;
            int j=0;
            parts = str.Split(' ');
            if(parts.Length > 2)
            {
                for (int i = 0; i < parts.Length; i++)
                {
                    if (parts[i] == "+" || parts[i] == "-" || parts[i] == "X" || parts[i] == "÷")
                    {
                        if(j>=1)
                        {
                            secondOperand = strsum.Pop();
                            j--;
                            if (j <= 0)
                            {
                                return "E";
                            }
                            else
                            {
                                firstOperand = strsum.Pop();
                                j--;
                                sum = calculate(parts[i], firstOperand, secondOperand);
                                strsum.Push(sum);
                                j++;
                            }
                        }
                        else
                        {
                            return "E";
                        }
                    }
                    else
                    {
                        strsum.Push(parts[i]);
                        j++;
                    }                    
                }
                if(j==1)
                {
                    j--;
                    return strsum.Pop();
                }
                else
                {
                    return "E";
                }
            }
            return "E";
        }
    }
}
