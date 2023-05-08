using System.Linq.Expressions;
using System.Threading.Channels;

namespace Assignment_2_
{
    public class Assignment_2
    {
       public void Factorial()
        {
            Console.WriteLine("Enter a number to get its factorial:");
            int num = int.Parse(Console.ReadLine());
            int factorial = 1;
            if (num > 0)
            {
                for (int i = num; i >= 1; i--)
                {
                    factorial *= i; //1 = 1 X 5 = 5, 5 = 5 X 4 =20, 20 = 20 X 3 = 60, 60 = 60 X 2 = 120, 120 = 120 X 1 = 120 
                }
            }
            else
            {
                Console.WriteLine("Please enter positive integer!!!");
            }
            Console.WriteLine("{0} factorial is {1}",num.ToString(),factorial.ToString());
        }
       
       public void Fibonacci()
       {
            Console.WriteLine("Enter a number till you want to display fibonacci series:");
            int num = int.Parse(Console.ReadLine());
            int prevNum = -1, nextNuM = 1;
            Console.WriteLine("--------Fionacci Series :----------");

            for (int i = 0; i<num; i++)
            {
                int sum = prevNum + nextNuM; // -1 + 1 = 0, 1 + 0 = 1, 0 + 1 = 1, 1 + 1 = 2, 1 + 2 = 3, 2 + 3 = 5...CONTINUE LIKE THIS 
                Console.WriteLine(sum);
                prevNum = nextNuM;
                nextNuM = sum;
            }
       } 

        public void PrimeOrNot()
        {
            Console.WriteLine("Enter a number to check whether it's prime or not:");
            int num = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if (num == 0 || num == 1)
            {
                Console.WriteLine("Invalid Number!! [0 and 1 are not considered as prime numbers]");
            }
            else if (num == 2)
            {
                Console.WriteLine("2 is even prime number");
            }
            else
            {
                //suppose num = 4
                for (int i = 2; i <= num / 2; i++) // i <= 4 / 2 it means our loop iterate till 2 because any number can't be divided more than its half.
                {

                    if (num % i == 0)
                    {
                        isPrime = false;
                        Console.WriteLine("{0} is not a prime number", num.ToString());
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine("{0} is a prime number", num.ToString());
                }
            }

        }

        public void SwitchCase()
        {
            Console.WriteLine("Press 1 for FACTORIAL... \nPress 2 for FIBONACCI... \nPress 3 for PRIME...");
            int digit = int.Parse(Console.ReadLine());

            switch (digit)
            {
                case 1:
                    Factorial();
                    break;
                case 2:
                    Fibonacci();
                    break;
                case 3:
                    PrimeOrNot();
                    break;
            }
           
        }

        static void Main(string[] args)
        {
            Assignment_2 p = new Assignment_2();
            string confirm;
            do
            {
                p.SwitchCase();
                Console.WriteLine("Do you want to restart the program? If yes enter YES otherwise NO...");
                confirm = Console.ReadLine();
            }
            while (confirm == "YES");

        }
    }
}