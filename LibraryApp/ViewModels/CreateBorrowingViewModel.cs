using LibraryApp.Commands;
using LibraryApp.Models;
using LibraryApp.Services;
using LibraryApp.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LibraryApp.ViewModels
{
    public class CreateBorrowingViewModel : ViewModelBase
    {
        private string _cardNumber;
        public string CardNumber
        {
            get { return _cardNumber; }
            set
            {
                _cardNumber = value;
                OnPropertyChanged(nameof(CardNumber));
            }
        }

        private int _bookId;
        public int BookId
        {
            get { return _bookId; }
            set
            {
                _bookId = value;
                OnPropertyChanged(nameof(BookId));
            }
        }

        private DateTime _borrowingDate = DateTime.Now;
        public DateTime BorrowingDate
        {
            get { return _borrowingDate; }
            set
            {
                _borrowingDate = value;
                OnPropertyChanged(nameof(BorrowingDate));
            }
        }

        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

        public CreateBorrowingViewModel(Library library, NavigationService borrowingViewNavigationService)
        {
            SubmitCommand = new CreateBorrowingCommand(this, library, borrowingViewNavigationService);
            CancelCommand = new NavigateCommand(borrowingViewNavigationService);
        }
    }
}
