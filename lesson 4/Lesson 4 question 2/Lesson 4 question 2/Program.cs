using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Sum(1, 2, 31, 2412, 412, 412, 412, 4);
            Console.WriteLine(num);

        }

        static int Sum (params int[]num)
        {
            int Sum = 0;
            for(int i=0;i<num.Length;i++)
            {
                Sum += num[i];
            }

            return Sum;
        }
      
    }
}
