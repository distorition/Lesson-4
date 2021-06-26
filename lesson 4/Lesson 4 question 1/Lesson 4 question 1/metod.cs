using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_question_1
{
  static  class metod
    {

        static void Main(string[] args)
        {
            (string name, string secondname, string lastname)[] users = CreatUsers();
            ShouMenu(users);
        }

            static (string name, string secondname, string lastname)[] CreatUsers()
        {

            Console.WriteLine("Ввидите кол-во пользователей");

            int count = WriteNum();
            (string name, string secondname, string lastname)[] users = new (string name, string secondname, string lastname)[count];
            for (int i = 0; i < users.Length; i++)
            {
                
                users[i] = Makeusers();

                Console.WriteLine($"Добавили пользователей {UserInfo(users[i])}");
            }

            Console.WriteLine("Добавили всех пользователей");

            return users;

        }


        static void ShouMenu((string name, string secondname, string lastname)[] users)
        {
            int choise;
            do
            {
                choise = WriteNum();
                switch (choise)
                {
                    case 1:
                        PrintAllUsers(users);
                            break;
                    case 2:
                        PrintSelecteduser(users);
                        break;
                    default:
                        break;

                }
            } while (choise != 3);
                 

        }

        static int GetNum()
        {
            Console.WriteLine("1-просмотр введенных пользоватлей");
            Console.WriteLine("2-просмотр конткретного пользователя");
            Console.WriteLine("3-закрыть программу");
            return WriteNum();
        }


        static (string userName, string secondDname,string lastname) Makeusers()
        {
            Console.WriteLine("Ввидите имя пользователя");
            string userName = Console.ReadLine();
            Console.WriteLine("Ввидите фамилию пользователя");
            string seconDname = Console.ReadLine();
            Console.WriteLine("ввидите отчесвто");
            string lastName = Console.ReadLine();

            return (userName, seconDname, lastName);
        }


       static string UserInfo((string userName, string secondDname, string lastname)user)
        {
            return ($"{user.lastname} {user.userName} {user.secondDname}");

        }


       static int WriteNum()
        {
           return Convert.ToInt32(Console.ReadLine());
        }

        static void PrintUser((string userName, string secondDname, string lastname)user)
        {
            Console.WriteLine(UserInfo(user));
        }

       static void PrintAllUsers((string userName, string secondDname, string lastname)[] users)
        {
            Console.WriteLine("Выводим всех пользователей");
            for(int i=0;i<users.Length;i++)
            {
                PrintUser(users[i]);
            }
        }


        static void PrintSelecteduser((string userName, string secondDname, string lastname)[] users)
        {
            int indexUser;
            do

            {
                Console.WriteLine($"Ввидите индекс пользователя от 0 до {users.Length - 1}");
                indexUser = WriteNum();

            } while (indexUser < 0 || indexUser >= users.Length);

            PrintUser(users[indexUser]);

        }
    }
}
