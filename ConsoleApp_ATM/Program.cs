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
                Console.WriteLine("欢迎来到2015级 ATM 系统");
                Console.WriteLine("1 登录 2 开户");
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
            Console.WriteLine("请输入新账号");
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
