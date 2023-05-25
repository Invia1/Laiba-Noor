using System.Collections;
using System.Drawing;

namespace Arraylist
{
    public class MainApp
    {
        //This function will add the novels in the ArrayList
        public void AddData(ArrayList NovelList) 
        {
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("\nHow many novels do you want to add in the list?");

            Console.ForegroundColor = ConsoleColor.Black;
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter Novel Name : ");
                string? novelName = Console.ReadLine();

                Console.WriteLine("Enter Novel Price : ");
                double novelPrice = Convert.ToDouble(Console.ReadLine());

                NovelList.Add(novelName);
                NovelList.Add(novelPrice);
            } 
        }


        //This function will show data of the ArrayList
        public void ShowData(ArrayList NovelList)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            if(NovelList.Count == 0)
            {
                Console.WriteLine("List is empty");
            }

            Console.WriteLine("\n----------Novel List----------");
            
            for (int i = 0; i < NovelList.Count; i++)
            {
                Console.WriteLine(" ~ " + NovelList[i]);
            }
        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();

            string? confirm;
            ArrayList NovelList = new ArrayList();
            MainApp obj = new MainApp();

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\t\t\t\t\t|---------------------------------|");
            Console.WriteLine("\t\t\t\t\t|------------ArrayList------------|");
            Console.WriteLine("\t\t\t\t\t|---------------------------------|");
            Console.ResetColor();
            
            do
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("\nPress 1 To Enter Novel Name In ArrayList");
                Console.WriteLine("Press 2 To Show Novel List");
                Console.WriteLine("Press 3 To Exit The Program");

                int num = Convert.ToInt32(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        obj.AddData(NovelList);
                        break;
                    case 2:
                        obj.ShowData(NovelList);
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }

                Console.WriteLine("\nDo you want to continue the program? If yes then press 'Y'");
                confirm = Console.ReadLine();

            } while (confirm == "Y" || confirm == "y");
        }
    }
}