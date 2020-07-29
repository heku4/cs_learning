// http://acm.sgu.ru/lang/problem.php?contest=2&problem=2023

using System;
using System.Linq;
using System.Collections.Generic;

namespace cs_learning
{
    class SecondArraySearch
    {
        public void FindEquals()
        {
            int firstLength = int.Parse(Console.ReadLine());
            int[] firstArray = Console.ReadLine().Split().Select(e => int.Parse(e)).ToArray();
            int secondLength = int.Parse(Console.ReadLine());
            int[] secondArray = Console.ReadLine().Split().Select(e => int.Parse(e)).ToArray();
            List<int> resultList = new List<int>();

            for (int i = 0; i < firstLength; i++)
            {
                for (int j = 0; j < secondLength; j++)
                {
                    if (firstArray[i] == secondArray[j])
                    {
                        resultList.Add(firstArray[i]);
                        break;
                    }

                }

            }

            int[] resultArray = resultList.ToArray();

            Console.Write("{0} \n", resultArray.Length);
            if (resultArray.Length != 0)
            {
                for (int i = 0; i < resultArray.Length; i++)
                {
                    Console.Write("{0} ", resultArray[i]);
                }
            }

        }
    }
}