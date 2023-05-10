namespace Assignment_3_
{
    
       


       class Person 
    {

        string Name;
        int Pin;
        double Amount;
        int b1,b2;
      object[] database=new object[4];
        public object this[int i]
        {
          get
          {
            return database[i];
          }
          set
          {
            database[i]=value;
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
                string name = Name;

                if (name==database[0])
                {
                    Console.WriteLine("Welcome " + name );
                                  
                }
                else 
                     {
                       Console.WriteLine("Invalid name");
                       Console.WriteLine("Enter valid name");
                        PName = Console.ReadLine();
                        return;
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
                
                string name = Name.ToUpper();
                int pin = Pin;

                if (pin == (int)database[1] && name == database[0])
                {
                    Console.WriteLine("CORRECT PIN U MAY PROCEED" );
                    if(name=="MAYANK")
                     {
                       b1=20000;
                      Console.WriteLine("YOUR BALANCE IS " +b1 );
                      }
                    else
                    {
                     b2=5000;
                      Console.WriteLine("YOUR BALANCE IS " +b2 );
                    } 
                                  
                }
                else 
                     {
                       Console.WriteLine("Invalid PIN");
                       Console.WriteLine("Enter valid PIN");
                       PPin = int.Parse(Console.ReadLine());
                      
                     }
                
            }
        }
         
        public double PAmount
        {
            get
            {
                return Amount;
            }
            set
            {
                Amount = value;
                Shopping sh = new Shopping();

                if (PAmount >= 10000 && PAmount<=(int)database[2])
                {
                    sh.CanShop(); 
                }
                else
                {
                    sh.CantShop();
                }
            }
        }
    }

    class Shopping
    {
       Person P = new Person();
        public void CanShop()
        {
                Console.WriteLine("Yipppee!!! You can do shopping ...");
        }

        public void CantShop()
        {
            Console.WriteLine("Oops!!! You have unsufficient amount for shopping \nFor doing shopping you must have atleast 10000rs.");

        }

        public void personInfo()
        {
            Console.WriteLine("Enter your name : ");
            P.PName = Console.ReadLine();
            Console.WriteLine("Enter your pin : ");
            P.PPin = int.Parse(Console.ReadLine());
                       
            Console.WriteLine("Enter Amount for checking whether you can do shopping or not :");
            P.PAmount = int.Parse(Console.ReadLine());
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {   Person obj1=new Person();
             Console.WriteLine("Enter your name for database ");
             obj1[0]=Console.ReadLine();
             Console.WriteLine("Enter your pin for database ");
             obj1[1]=int.Parse(Console.ReadLine());
             Console.WriteLine("Enter your balance for database ");
             obj1[2]=int.Parse(Console.ReadLine());
                         
            var obj = new Shopping();
            obj.personInfo();
        }
    }
}
