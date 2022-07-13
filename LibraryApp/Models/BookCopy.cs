using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public class BookCopy
    {
        public int BookCopyId { get; set; }
        public string Title { get; set; }
        public bool IsBorrowed { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
        public ICollection<Borrowing> Borrowings { get; set; }

        //public BookCopy(int bookCopyId, string title, DateTime releaseDate, Category category, bool isBorrowed = false)
        //{
        //    BookCopyId = bookCopyId;
        //    Title = title;
        //    IsBorrowed = isBorrowed;
        //    ReleaseDate = releaseDate;
        //    Category = category;
        //}

        //public override bool Equals(object? obj)
        //{
        //    return obj is BookCopy bookCopy && BookCopyId == bookCopy.BookCopyId;
        //}

        //public override string ToString()
        //{
        //    return $"{BookCopyId} - {Title}";
        //}

        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(BookCopyId, Title);
        //}

        //public static bool operator == (BookCopy book1, BookCopy book2)
        //{
        //    if (book1 is null && book2 is null) return true;
        //    return !(book1 is null) && book1.Equals(book2);
        //}

        //public static bool operator != (BookCopy book1, BookCopy book2)
        //{
        //    return !(book1 == book2);
        //}
    }
}
