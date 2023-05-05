namespace Repeated_Char

{
    public class Repeated
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name to check repeated characters and its count :");
            string name = Console.ReadLine();

            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char ch in name)
            {
                if (dict.ContainsKey(ch))
                {
                    dict[ch]++;
                }
                else
                {
                    dict.Add(ch, 1);
                }
            }

            foreach (var repeat in dict)
            {
                if (repeat.Value > 1 && repeat.Key != ' ')
                {
                    Console.WriteLine("{0} repeats {1} times", repeat.Key, repeat.Value);

                }
            }

            Console.ReadLine();
        }
    }
}