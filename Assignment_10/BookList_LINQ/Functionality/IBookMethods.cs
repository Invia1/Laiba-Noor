using Assignment_10.Models;
using System;
using System.Collections.Generic;

namespace Assignment_10.Functionality
{
    public interface IBookMethods
    {
        int CreateBooks(Book book);
        IEnumerable<Book> GetBookList();

        
        void UpdateBooks(int isbn);
        void SearchBook(int isbn);
        void DeleteBook(int isbn);
        void CountBook();

    }
}
