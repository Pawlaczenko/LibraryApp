using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LibraryApp.ViewModels
{
    public class BorrowingListingViewModel :ViewModelBase
    {
        private readonly ObservableCollection<BorrowingViewModel> _borrowings;
        public IEnumerable<BorrowingViewModel> Borrowings => _borrowings;
        public ICommand CreateBorrowingCommand { get; }

        public BorrowingListingViewModel()
        {
            _borrowings = new ObservableCollection<BorrowingViewModel>();

            CreateBorrowingCommand = new NavigateCommand();

            _borrowings.Add(new BorrowingViewModel(new Borrowing(new BookCopy(1, "Diuna"), DateTime.Now, "123123123")));
            _borrowings.Add(new BorrowingViewModel(new Borrowing(new BookCopy(2, "Diuna 2"), DateTime.Now, "123123123")));
            _borrowings.Add(new BorrowingViewModel(new Borrowing(new BookCopy(3, "Diuna 3"), DateTime.Now, "123123123")));
            _borrowings.Add(new BorrowingViewModel(new Borrowing(new BookCopy(4, "Koniec Świata"), DateTime.Now, "43213123")));
        }
    }
}
