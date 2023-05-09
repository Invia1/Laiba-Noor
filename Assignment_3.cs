namespace Assignment_3_
{
    class Person 
    {

        string Name;
        double Amount;


        public string PName
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
                if (string.IsNullOrEmpty(Name) || Name == " ")
                {
                    Console.WriteLine("You can't leave this field empty, Please enter your name .....");
                     string name = Console.ReadLine();
                     Name = name;
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

                if (PAmount >= 10000)
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
            Console.WriteLine("Enter Amount for checking whether you can do shopping or not :");
            P.PAmount = int.Parse(Console.ReadLine());
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Shopping();
            obj.personInfo();
        }
    }
}
