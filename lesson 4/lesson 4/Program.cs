using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
           
           
            
          
            while(true)
            {
                
                string name = GetName();
               
                string secondName = GetLastname();
                string patr = GetPatronymic();
                string sum = GetfuulName(name, secondName, patr);
                Console.WriteLine(sum);
                Console.WriteLine("хотите  ввести еще имя? Yes or No");
                string shois1 = Console.ReadLine();
                if (shois1!="yes")
                {
                    break;
                }
            }

        }
        static string GetName()
        {
            Console.WriteLine("ввидите имя ");
            string firstName = Console.ReadLine();

            return firstName;
        }

        static string GetLastname()
        {
            Console.WriteLine("Ввидите фамилию");
            string lastName = Console.ReadLine();
            return lastName;
        }

        static string GetPatronymic()
        {
            Console.WriteLine("ВВидите отчесвто");
            string patronymic = Console.ReadLine();
            return patronymic;
        }
        static string GetfuulName(string firstName, string lastName, string patronymic)
        {
            
           string fullname= ($"{firstName}{lastName}{patronymic}");
            return fullname;
        }
    }
}
