using Assignment_10.BLL;
using Assignment_10.Functionality;
using Assignment_10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;

namespace Assignment_10.UI
{
    class BookMainApp
    {
        public static void Main()
        {
            int isbn;
            string confirm;
            Book book;
            IBookMethods bl = new BookServices();

            do
            {
            Console.WriteLine("Press 1 to Add Books in List");
            Console.WriteLine("Press 2 to Show Books List");
            Console.WriteLine("Press 3 to Update Books in List");
            Console.WriteLine("Press 4 to Delete Books in List");
            Console.WriteLine("Press 5 to Search Books in List");
            Console.WriteLine("Press 6 to Count Books in List");
            Console.WriteLine("Press 7 to Exit the program");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num) 
                { 
                case 1 :
                        book = new Book();
                        Console.WriteLine("Enter the ISBN : ");
                        book.ISBN = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter the Title : ");
                        book.Title = Console.ReadLine();

                        Console.WriteLine("Enter the Author : ");
                        book.Author = Console.ReadLine();

                        Console.WriteLine("Enter the Price : ");
                        book.Price = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter the Genre : ");
                        book.Genre = Console.ReadLine();

                        bl.CreateBooks(book);
                        
                        break;
                    case 2:
                        Console.WriteLine("--------Books List--------");
                        IEnumerable<Book> bookList = (from bk in bl.GetBookList()
                                                      select bk).ToList();
                        foreach(Book bks in bookList)
                        {
                            Console.WriteLine("Book ISBN : " + bks.ISBN);
                            Console.WriteLine("Title : "+bks.Title);
                            Console.WriteLine("Author : "+bks.Author);
                            Console.WriteLine("Price : "+bks.Price);
                            Console.WriteLine("Genre : "+bks.Genre);
                            Console.WriteLine("");
                        }

                        break;
                    case 3:
                        Console.WriteLine("Which book do you want to update? Please enter ISBN no. : ");
                        isbn = Convert.ToInt32(Console.ReadLine());
                        bl.UpdateBooks(isbn);
                        break;
                    case 4:
                        Console.WriteLine("Which book do you want to delete? Please enter ISBN no. : ");
                        isbn = Convert.ToInt32(Console.ReadLine());
                        bl.DeleteBook(isbn);
                        break;
                    case 5:
                        Console.WriteLine("Which book do you want to search? Please enter ISBN no. : ");
                        isbn = Convert.ToInt32(Console.ReadLine());
                        bl.SearchBook(isbn);
                        break;
                    case 6:
                        bl.CountBook();
                        break;
                    case 7 :
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine("Do you want to continue the program? If Yes Press 'Y' else 'N'");
                confirm = Console.ReadLine();
            } while (confirm == "Y") ;

            Console.ReadLine();
        }
    }
}
