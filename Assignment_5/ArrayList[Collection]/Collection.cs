
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_
{
    public class NovelEntry 
    { 
        ArrayList NovelList = new ArrayList()
        {
            "~ A Thousand Splendid Suns",
            "~ Dumplin",
            "~ Poems for the sign",
            "~ The Mountain is YOU",
            "~ Free Mind",
            "~ The Fells the moon and my soul",
            "~ Ikigai",
            "~ Atomic Habits",
            "~ You'll come back to yourself journal",
            "~ The strength in our scars"
        };

        public void IterateList()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("*-*-*----List of Novels----*-*-*\n");
            foreach (var novels in NovelList)
            {
                Console.WriteLine(novels);
            }
        }
        public void AddNovel()
        {
            IterateList();
            Console.WriteLine("\nEnter the number of novels you want add : ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter the novel you want to add in list : ");

            for (int i = 1; i<=num; i++)
            {
                NovelList.Add(Console.ReadLine());

            }
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("\n-------List of Novels After Adding More Novels-------\n");
            foreach (var novels in NovelList)
            {
                Console.WriteLine(novels);
            }

        }

        public void UpdateNovel()
        {
            IterateList();
            Console.WriteLine("\nEnter the total of novel you want to update : ");
            int total = int.Parse(Console.ReadLine());
           

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine("\nEnter the index number where you want update novel : ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("\nEnter the novel you want to add in list : ");
                string novel = Console.ReadLine();
                NovelList[num] = novel;
            }
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("\n-------List of Novels After Updating Novels-------\n");
            foreach (var novels in NovelList)
            {
                Console.WriteLine(novels);
            }
        }

        public void InsertNovel()
        {
            IterateList();
            Console.WriteLine("\nEnter the total of novel you want to insert : ");
            int total = int.Parse(Console.ReadLine());


            for (int i = 0; i < total; i++)
            {
                Console.WriteLine("\nEnter the index number where you want insert novel : ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("\nEnter the novel you want to add in list : ");
                NovelList.Insert(num, Console.ReadLine());
            }
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("\n-------List of Novels After Inserting Novels-------\n");
            foreach (var novels in NovelList)
            {
                Console.WriteLine(novels);
            }
        }

        public void SearchNovel()
        {
            IterateList();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nEnter the number of novels you want to search : ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("\nEnter the novel name you want to search : ");
                string str = Console.ReadLine();
                bool true_false = NovelList.Contains(str);
                Console.WriteLine("\nIs list contains novel \"{0}\"? : {1}", str, true_false);
            }
        }

        public void RemoveNovel()
        {
            IterateList();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nEnter the number of novel you want to remove : ");
            int num = int.Parse (Console.ReadLine());

            for(int i =0; i<num; i++)
            {
                Console.WriteLine("\nEnter the novel name you want to remove : ");
                NovelList.Remove(Console.ReadLine());
            }

            Console.WriteLine("\n-------List of Novels After Removing-------\n");
            foreach (var novels in NovelList)
            {
                Console.WriteLine(novels);
            }
        }
       
    }

    class Collection
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.WriteLine("NOTE :\tYellow color list defines novels before applying any method to them.\n\tCyan color lists define novels after applying methods to them.\n");
            NovelEntry obj = new NovelEntry();

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("Press 1 for adding novels in the list..");
            Console.WriteLine("Press 2 for updating novels in the list..");
            Console.WriteLine("Press 3 for inserting novels in the list..");
            Console.WriteLine("Press 4 for searching novels in the list..");
            Console.WriteLine("Press 5 for removing novels in the list..");
            Console.WriteLine("Press 6 for exit the program..");

            int num = int.Parse(Console.ReadLine());

            switch (num) 
            {
                case 1:
                    obj.AddNovel();
                    break;
                case 2:
                    obj.UpdateNovel();
                    break;
                case 3:
                    obj.InsertNovel();
                    break;
                case 4:
                    obj.SearchNovel();
                    break;
                case 5:
                    obj.RemoveNovel();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
            }
            Console.ReadLine();
        }
    }
}
