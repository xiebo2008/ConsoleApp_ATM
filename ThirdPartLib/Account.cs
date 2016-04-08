using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdPartLib
{
    public class Account  
    {
        public static int Count = 0;

        //静态构造函数
        static Account()
        {
            Count = 0;
            Console.WriteLine("没有构造一个实例");
           
        }

        ////无参构造函数  与类同名
        public Account()
        {
            Count++;
            Console.WriteLine("Account被构造");
        }

        //有参构造函数
        public Account(string name, string pass, int money)
        {
            Count++;
            this.username = name;
            this.password = pass;
            this.balance = money;
            Console.WriteLine("Account被构造 ,username:{0}",username);
        }

        //实例变量 field
        public   string username;
      public  string password;
        //私有变量
      private  int balance;
       public int Balance
        {
            //访问符
            get { return balance; }

            //设置
          set
            {
                if (value > 200000)
                {
                    Console.WriteLine("一次存不了这么，存款失败");
                }
                else {
                    this.balance = value;
                }
              
            }
                
        }
    }
}
