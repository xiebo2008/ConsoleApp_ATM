
using System;
using System.Collections.Generic;
using ThirdPartLib;
namespace ConsoleApp_ATM
{
    class Program
    {
        //测试一下github 
        //存储当前登录用户
       static Account currentUser;
        //使用泛型列表来存储多用户
        static List<Account> lstAccount = new List<Account>();


        static void Main()
        {
            //初始化一系列账号
            Init();
            //循环开始

           
            while (true)
            {
                 //显示一级菜单 1登录 2 开户
                 //接受用户输入 ，判断用户选择
                 //如果是1， 进入Login() ， 如果是2 进入CreateAccount()
                Console.Write("1登录 2 开户");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Login();
                        break;
                    case "2":
                        CreateAccount();
                        break;

                }
          //  循环结束
            }
             

        }
       

        static void CreateAccount()
        {
            Console.WriteLine("进入开户界面");
            Console.ReadLine();

            //开户函数
            //1 接受用户名和密码的输入
            //2 验证该用户名是否已经存在，如果存在回到第一步，如果不存在进行存储
            //3回到一级菜单
        }



        //初始化函数， 在程序的一开始进行调用
        static void Init()
        {
            
           
           Account a1 = new Account("xiebo","123",100);
             
            lstAccount.Add(a1);

            Account a2 = new Account();
            a2.username = "xiexie";
            a2.password = "123";
            a2.Balance = 200;
            lstAccount.Add(a2);
            Console.WriteLine("初始化结束，已初始化{0}个用户", lstAccount.Count);

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
                    a.Balance = 100;
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
                    Console.WriteLine("您的余额是{0}", lstAccount[index].Balance);
                    //指定当前用户
                    currentUser = lstAccount[index];
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
            //省略输入过程
            int choice = 1;
            switch (choice)
            {
                case 1: Save();
                    break;
                default: break;

            }

        }

        private static void Save()
        {
            Console.WriteLine("你要存入100元");
            Console.ReadLine();
            int money = 100000;
           
            currentUser.Balance = currentUser.Balance+money;




            Console.WriteLine("你的余额是{0}", currentUser.Balance);
            Console.ReadLine();

        }
    }
}
