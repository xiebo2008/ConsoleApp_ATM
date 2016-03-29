
using System;
using System.Collections.Generic;
namespace ConsoleApp_ATM
{
    class Program
    {
      static Account currentUser;
        //使用泛型列表
        static List<Account> lstAccount = new List<Account>();


        static void Main()
        {
            Init();
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

        //初始化函数， 会在程序的一开始进行调用
        private static void Init()
        {
            Console.WriteLine(lstAccount.Count);
            Account a1 = new Account();
            a1.username = "xiebo";
            a1.password = "123";
            a1.balance = 100;
            lstAccount.Add( a1);

            Account a2 = new Account();
            a2.username = "xiexie";
            a2.password = "123";
            a2.balance = 200;
            lstAccount.Add( a2);
            Console.WriteLine("初始化结束");
            Console.WriteLine(lstAccount.Count);

        }

        private static void Create()
        {
            Console.WriteLine("请输入新账号");
            string username = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string password = Console.ReadLine();
            Account a = new Account();
            a.username = username;
            a.password = password;
            a.balance = 100;

            lstAccount.Add( a);
            //for (int index = 0; index < lstAccount.Count; index++)
            //{
            //    if (lstAccount[index].username == null)
            //    {
            //        lstAccount[index] = a;
            //    }
            //}


            Console.WriteLine("开户成功.....按任意键退出");
            Console.ReadLine();
          
        }


        static void Login()
        {
            Console.WriteLine("请输入账号");
            string username = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string password = Console.ReadLine();
            for (int index = 0; index < lstAccount.Count; index++)
            {
                if (username == lstAccount[index].username && password == lstAccount[index].password)
                {
                    Console.WriteLine("登录成功");
                    Console.WriteLine("您的余额是{0}", lstAccount[index].balance);
                    GotoSecondMenu();
                }
            } 
            Console.WriteLine("登录失败，请重新登录");
            

        }

        private static void GotoSecondMenu()
        {

            Console.WriteLine("1存款 2取款 3转账 4查流水 5回到上级");
            Console.ReadLine();
        }
    }
}
