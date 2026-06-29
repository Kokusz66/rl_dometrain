using Firka.Components.Pages;
using Firka.Models;
using System.Collections.Generic;

namespace Firka.Services
{
    public class BookServices
    {
        private List<Book> Books = new List<Book>
        {
            new Book(1, "Harry Potter", "J.K. Rowling", 1997, true),
            new Book(2, "A Gyűrűk Ura", "J.R.R. Tolkien", 1954, false),
            new Book(3, "Dűne", "Frank Herbert", 1965, true)
        };
        
        public List<Book> GetAllBooks()
        {   
            if (this.Books.Count() != 0)
            {
                return this.Books;
            }
            else
            {
                Console.WriteLine("A lista üres.");
                List <Book> emptyList = new List<Book>();
                return emptyList;
            }
        }

        public Book GetBookById(int id)
        {
            Book result = Books[0];
            for(int i = 0; i < Books.Count; i++)
            {
                if (Books[i].Id == id)
                {
                    result = Books[i];
                }
                else
                {
                    Console.WriteLine($"A keresett {id} könyv nem található, itt az első könyv.");
                }
            }
            return result;
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void UpdateBook(Book book)
        {
            for (int i = 0; i < Books.Count; i++)
            {
                if (book.Id == Books[i].Id)
                {
                    Books[i] = book;
                }
                else
                {
                    Console.WriteLine("A keresett könyv nincs a listában, ezért nem frissíthető");
                }
            }
        }

        public void DeleteBook(int id)
        {
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].Id == id)
                {
                    Books.Remove(Books[i]);
                }
                else
                {
                    Console.WriteLine("A törölni kívánt könyv nem található a rendszerben.");
                }
            }
        }

        public void DeleteByTitle(string title)
        {
            for (int i = 0; i < Books.Count; i++)
            {
                if (title == Books[i].Title)
                {
                    Books.Remove(Books[i]);
                }
                else
                {
                    Console.WriteLine($"A keresett könyv: {title}, nem található");
                }
            }
        }
    }
}
