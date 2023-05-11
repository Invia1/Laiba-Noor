using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHECK
{
    public class Person
    {
        string Name;
        int Pin;
        int Balance;
        int Debit;

        object[] database = new object[3];
        public object this[int i]
        {
            get
            {
                return database[i]; 
            }
            set
            {
                database[i] = value;
            }
        }

        public string PName
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
                if(Name.ToLower() == database[0].ToString().ToLower())
                {
                    Console.WriteLine("Welcome : " + Name);
                }
                else
                {
                    Console.WriteLine("Invalid Name");
                    Console.WriteLine("Enter your name again");
                    PName = Console.ReadLine();
                }
            }
        }
        public int PPin
        {
            get
            {
                return Pin;
            }
            set
            {
                Pin = value;
                if(Pin == (int)database[1])
                {
                    Console.WriteLine("-------");
                }
                else
                {
                    Console.WriteLine("Incorrect Pin");
                    Console.WriteLine("Enter your Pin again");
                    PPin = int.Parse(Console.ReadLine());
                }
            }
        }
        public int PBalance
        {
            get
            {
                return Balance;
            }
            set
            {
                Balance = value;
                if(Balance == (int)database[1])
                {
                    Console.WriteLine("Balance : {0}",Balance);
                }
            }
        }

        public int PDebit
        {
            get
            {
                return Debit;
            }
            set
            {
                Shopping sh = new Shopping();

                if (PDebit < Balance && PDebit < 10000)
                {
                    sh.cantShop();

                }
                else
                {
                    sh.canShop();
                }
            }
        }
    }

    public class Shopping
    {
        public void canShop()
        {
            Console.WriteLine("Yippeee!! You can do shopping.");
        }
        public void cantShop()
        {
            Console.WriteLine("Oops!! Either You've unsufficient balance or You're debit more amount than your balance to do shopping. \nFor doing shopping you must have atleast 10000rs.");
        }

        public void startPr()
        {
            Person obj = new Person();
            Console.WriteLine("Enter your name for database : ");
            obj[0] = Console.ReadLine();

            Console.WriteLine("Enter your Pin for database : ");
            obj[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your balance for database : ");
            obj[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("------------Consumer Details--------------");
            Console.WriteLine("Enter you name : ");
            obj.PName = Console.ReadLine();

            Console.WriteLine("Enter you Pin : ");
            obj.PPin = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter debit amount for checking whether you can do shopping or not : ");
            obj.PDebit = int.Parse(Console.ReadLine());


            //Console.WriteLine("Enter you name : ");
            //obj.PBalance = int.Parse(Console.ReadLine());


            //Console.WriteLine("Enter Your Account No. :");
            //b1.PAccNo = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your name : ");
            //b1.PName = Console.ReadLine();
            //Console.WriteLine("Balance : ");
            //b1.Pbalance = int.Parse(Console.ReadLine());

            //int remainingBal = (int)b1.Pbalance - (int)b1.PDebit;
            //Console.WriteLine("Your Remaining Balance : {0}", remainingBal);

        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Shopping sh = new Shopping();
            sh.startPr();
            Console.ReadLine();
            
        }
    }
}
