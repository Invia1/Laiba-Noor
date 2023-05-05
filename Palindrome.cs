namespace Assignment1
{
    public class Palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to check whether it's palindrome or not :");
            string str = Console.ReadLine();
            string revString = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                revString += str[i];
            }
            if (str.ToLower() == revString.ToLower())
            {
                Console.WriteLine("Yes -- {0} is a palindrome string", revString);
            }
            else
            {
                Console.WriteLine("No -- {0} is not a palindrome string", revString);
            }
            Console.ReadLine();
        }
    }
}
