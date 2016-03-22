
using System;

namespace ConsoleApp_ATM
{
    class Program
    {
        // 定义了一个Account 类型变量
       static Account  g_account;
    //    int[] arr = new int[6] ;
        static Account[] arrAccount = new Account[10];
        
        static void Main()
        {           
            while (true)
            {
                Console.WriteLine("欢迎来到九职大2015级 ATM 系统");
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
            g_account.username= Console.ReadLine();
            Console.WriteLine("请输入密码");
            g_account.password = Console.ReadLine();
            g_account.balance = 100;
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
            if (username == g_account.username && password == g_account.password)
            {
                Console.WriteLine("登录成功");
                Console.WriteLine("您的余额是{0}", g_account.balance);
                GotoSecondMenu();
            }
            else
            {
                Console.WriteLine("登录失败，请重新登录");
            }
          
        }

        private static void GotoSecondMenu()
        {

            Console.WriteLine("1存款 2取款 3转账 4查流水 5回到上级");
        }
    }
}
