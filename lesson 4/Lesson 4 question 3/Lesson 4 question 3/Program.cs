using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_question_3
{
    enum Season
    {
        Winter=1,
        Spring,
        Summer,
        Autum
    }
    class Program
    {
        static void Main(string[] args)
        {

            Seas();

        }

        static void Seas()
        {
            int sum;
            try
            {
                Console.WriteLine("ввидите число от 1 до 4");
                sum = Convert.ToInt32(Console.ReadLine());





                switch (sum)
                {
                    case 1:
                        Console.WriteLine("Winter");
                        break;
                    case 2:
                        Console.WriteLine("Spring");
                        break;
                    case 3:
                        Console.WriteLine("Summer");
                        break;
                    case 4:
                        Console.WriteLine("Autum");
                        break;
                    default:
                        Console.WriteLine("Ошибка вввидите число от 1 до 4");
                        Seas();
                        break;

                }
            }
            catch
            {
                Console.WriteLine("Былла введена буквва а не цифра ");
                Seas();
            }

            
            
          



        }
            
        

    }
}
