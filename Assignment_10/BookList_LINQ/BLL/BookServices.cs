using Assignment_10.Functionality;
using Assignment_10.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_10.BLL
{
    public class BookServices :IBookMethods
    {
        List<Book> bookList = new List<Book>();

        public int CreateBooks(Book book)
        {
            bookList.Add(book);
            return 1;
        }

        public IEnumerable<Book> GetBookList()
        {
            return bookList;
        }

        public void UpdateBooks(int isbn)
        {
            try
            {
                foreach (var BOOK in bookList.Where(b => b.ISBN == isbn))
                {
                    if (BOOK.ISBN == isbn) 
                    {
                        Console.WriteLine("Enter the Updated Title : ");
                        BOOK.Title = Console.ReadLine();

                        Console.WriteLine("Enter the Updated Author : ");
                        BOOK.Author = Console.ReadLine();

                        Console.WriteLine("Enter the Updated Price : ");
                        BOOK.Price = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter the Updated Genre : ");
                        BOOK.Genre = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Invalid ISBN !! Please Try Again");
                    }
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DeleteBook(int isbn)
        {
            try
            {
                foreach (var BOOK in bookList.Where(b => b.ISBN == isbn))
                {
                    if (BOOK.ISBN == isbn)
                    {
                      bookList.Remove(BOOK);
                      Console.WriteLine("Book has been deleted successfully!!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid ISBN !! Please Try Again");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void SearchBook(int isbn)
        {
            try
            {
                foreach (var BOOK in bookList.Where(b => b.ISBN == isbn))
                {
                    if (BOOK.ISBN == isbn)
                    {
                        Console.WriteLine("Book ISBN : " + BOOK.ISBN);
                        Console.WriteLine("Title : " + BOOK.Title);
                        Console.WriteLine("Author : " + BOOK.Author);
                        Console.WriteLine("Price : " + BOOK.Price);
                        Console.WriteLine("Genre : " + BOOK.Genre);
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("Book not found!! Try Again");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void CountBook()
        {
            int count = (from bk in bookList select bk).Count();
            Console.WriteLine("Count of available books in list : {0}",count.ToString());
        }

    }
}

