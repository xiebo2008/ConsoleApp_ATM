using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ATM
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("欢迎来到 to ATM System");
                Console.WriteLine("1 Login 2 Create Account");
                string input = Console.ReadLine();
                int choice = 0;

                bool result = int.TryParse(input, out choice);
                if (result)
                {
                    switch (choice)
                    {
                        case 1:
                            Login();
                            break;
                        case 2:
                            Create();
                            break;
                        default: break;

                    }
                }
            }



        }

        private static void Create()
        {
            Console.WriteLine("Please input your new account");
            Console.ReadLine();
        }

        private static void Login()
        {
            Console.WriteLine("Please input your account");
            Console.ReadLine();
            //if you   successe to login
            //show the second menu
            // 1  Save 2 Withdraw 3 transfer 4 detail(last 10 records) 5 logout 

        }

    }
}
