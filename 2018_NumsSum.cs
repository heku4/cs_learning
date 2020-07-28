// http://acm.sgu.ru/lang/problem.php?contest=2&problem=2018

using System;
using System.Linq;
using System.Collections.Generic;

namespace cs_learning
{
    class NumsSum 
    {
        void StackPacker(List<char> operations, char operatorSymbol, int repeatValue)
        {
            for (int i = 0; i < repeatValue; i++)
            {
                // if (operations.Capacity > size) break;
                operations.Add(operatorSymbol);
            }
        }
        public void CalculateSum()
        {
            Console.ReadLine();
            int[] nums = Console.ReadLine().Split().Select(e => int.Parse(e)).ToArray();
            List<char> operationsList = new List<char>();
            operationsList.Capacity = nums.Length;
            int sum = 0;


            for (int i = 1; i <= nums.Length; i++)
            {
                if (i % 2 != 0 && operationsList.Count < nums.Length) StackPacker(operationsList, '+', i);
                else if (operationsList.Count < nums.Length) StackPacker(operationsList, '-', i);

            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (operationsList[i] == '+') sum += nums[i];
                else sum -= nums[i];
            }

            Console.Write(sum);
        }
    }
}