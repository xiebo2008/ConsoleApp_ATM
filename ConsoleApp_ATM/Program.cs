using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ATM
{
    class Program
    {
        static string g_username;
        static string g_password;
        static int g_balance=0;
        static int add(int a, int b)
        {
            int c = a + b;
            return c;
        }
        static void Main()
        {
           // Console.WriteLine("请输入A,B整数");
           //int a = int.Parse( Console.ReadLine());
           //int b = int.Parse(Console.ReadLine());
           // int c = add(a, b);
            //Console.WriteLine("最后的结果:" + c.ToString());

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
            g_username= Console.ReadLine();
            Console.WriteLine("请输入密码");
            g_password = Console.ReadLine();
            g_balance = 100;
            Console.WriteLine("开户成功.....按任意键退出");
            Console.ReadLine();
           // return 0;
        }

     
        static void Login()
        {
            Console.WriteLine("请输入账号");
            string username = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string password = Console.ReadLine();
            if (username == g_username && password == g_password)
            {
                Console.WriteLine("登录成功");
                Console.WriteLine("您的余额是{0}", g_balance);
                GotoSecondMenu();

            }
            else
            {
                Console.WriteLine("登录失败，请重新登录");
            }
            //if you   successe to login
            //show the second menu
            // 1  Save 2 Withdraw 3 transfer 4 detail(last 10 records) 5 logout 

        }

        private static void GotoSecondMenu()
        {

            Console.WriteLine("1存款 2取款 3转账 4查流水 5回到上级");
        }
    }
}
