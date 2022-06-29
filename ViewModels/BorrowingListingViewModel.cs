using LibraryApp.Commands;
using LibraryApp.Models;
using LibraryApp.Services;
using LibraryApp.Stores;
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
        private readonly Library _library;
        private readonly ObservableCollection<BorrowingViewModel> _borrowings;
        public IEnumerable<BorrowingViewModel> Borrowings => _borrowings;
        public ICommand CreateBorrowingCommand { get; }

        public BorrowingListingViewModel(Library library, NavigationService createBorrowingNavigationService)
        {
            _library = library;
            _borrowings = new ObservableCollection<BorrowingViewModel>();

            CreateBorrowingCommand = new NavigateCommand(createBorrowingNavigationService);

            UpdateBorrowings();
        }

        private void UpdateBorrowings()
        {
            _borrowings.Clear();

            foreach(Borrowing borrowing in _library.GetBorrowings())
            {
                BorrowingViewModel borrowingViewModel = new BorrowingViewModel(borrowing);
                _borrowings.Add(borrowingViewModel);
            }
        }
    }
}
