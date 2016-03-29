
using System;
using System.Collections.Generic;
namespace ConsoleApp_ATM
{
    class Program
    {
        //存储当前登录用户
       static Account currentUser;
        //使用泛型列表来存储多用户
        static List<Account> lstAccount = new List<Account>();


        static void Main()
        {
            //初始化用户
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

        //初始化函数， 在程序的一开始进行调用
        private static void Init()
        {
           
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
            Console.WriteLine("初始化结束，已初始化{0}个用户",lstAccount.Count);
            

        }
        /// <summary>
        /// 判断用户是否已经存在于用户列表中， 如果不存在返回false， 存在则返回true
        /// </summary>
        /// <param name="username"></param>
         /// <returns></returns>
        static bool IsExist(string username)
        {
            for (int index = 0; index < lstAccount.Count; index++)
            {
                if (lstAccount[index].username == username)
                {
                    return true;
                }
            }
            return false;
        }

        private static void Create()
        {
           
            while (true)
            {
                Console.WriteLine("请输入新账号");
                string username = Console.ReadLine();
                if (!IsExist(username))
                {
                    Console.WriteLine("请输入密码");
                    string password = Console.ReadLine();
                    Account a = new Account();
                    a.username = username;
                    a.password = password;
                    a.balance = 100;
                    lstAccount.Add(a);
                    Console.WriteLine("开户成功.....按任意键退出");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("该帐号已经存在");                

                }
            }


        }


        static void Login()
        {
            Console.WriteLine("请输入账号");
            string username = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string password = Console.ReadLine();
            bool isValid = false;
            for (int index = 0; index < lstAccount.Count; index++)
            {
                if (username == lstAccount[index].username && password == lstAccount[index].password)
                {
                    Console.WriteLine("登录成功");
                    Console.WriteLine("您的余额是{0}", lstAccount[index].balance);
                    isValid = true;
                    GotoSecondMenu();
                }
            } 
            if (!isValid )
            { Console.WriteLine("登录失败，请重新登录"); }
           
            

        }

        private static void GotoSecondMenu()
        {

            Console.WriteLine("1存款 2取款 3转账 4查流水 5回到上级");
            Console.ReadLine();
        }
    }
}
