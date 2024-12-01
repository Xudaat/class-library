using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class Library
    {
        private List<Book> _books = new List<Book>();

        public Book this[int index]
        {
            get => index >= 0 && index < _books.Count ? _books[index] : null;
        }

        public void AddBook(Book book)
        {
            if (book == null)
                throw new ArgumentNullException(nameof(book));
            _books.Add(book);
        }

        public List<Book> FindAllBooksByName(string value)
        {
            return _books.Where(b => b.Name.Contains(value, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public Book FindBookByCode(string code)
        {
            return _books.FirstOrDefault(b => b.Code == code);
        }

        public void RemoveAllBooksByName(string value)
        {
            _books.RemoveAll(b => b.Name.Contains(value, StringComparison.OrdinalIgnoreCase));
        }

        public List<Book> SearchBooks(string value)
        {
            return _books.Where(b =>
                b.Name.Contains(value, StringComparison.OrdinalIgnoreCase) ||
                b.AuthorName.Contains(value, StringComparison.OrdinalIgnoreCase) ||
                b.PageCount.ToString().Contains(value))
                .ToList();
        }

        public List<Book> FindAllBooksByPageCountRange(int min, int max)
        {
            return _books.Where(b => b.PageCount >= min && b.PageCount <= max).ToList();
        }

        public void RemoveBookByCode(string code)
        {
            var book = FindBookByCode(code);
            if (book != null)
                _books.Remove(book);
        }
    }
}
