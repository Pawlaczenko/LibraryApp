using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.ViewModels
{
    public class BorrowingViewModel:ViewModelBase
    {
        private readonly Borrowing _borrowing;

        public int BookId => _borrowing.BookCopy.BookCopyId;
        public string BookTitle => _borrowing.BookCopy.Title;
        public string BorrowingDate => _borrowing.BorrowingDate.ToString("d");
        public string ReaderCardNumber => _borrowing.ReaderCardNumber;

        public BorrowingViewModel(Borrowing borrowing)
        {
            _borrowing = borrowing;
        }
    }
}
