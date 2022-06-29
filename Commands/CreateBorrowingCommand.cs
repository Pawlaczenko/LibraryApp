using LibraryApp.Exceptions;
using LibraryApp.Models;
using LibraryApp.Services;
using LibraryApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LibraryApp.Commands
{
    internal class CreateBorrowingCommand : CommandBase
    {
        private readonly Library _library;
        private readonly CreateBorrowingViewModel _createBorrowingViewModel;
        private readonly NavigationService _borrowingViewNavigationService;

        public CreateBorrowingCommand(CreateBorrowingViewModel borrowing, Library library, NavigationService borrowingViewNavigationService)
        {
            _library = library;
            _createBorrowingViewModel = borrowing;
            _borrowingViewNavigationService = borrowingViewNavigationService;

            _createBorrowingViewModel.PropertyChanged += OnViewModelPropertyChanged;
        }

        public override bool CanExecute(object parameter)
        {
            return !string.IsNullOrEmpty(_createBorrowingViewModel.CardNumber) && base.CanExecute(parameter);
        }

        public override void Execute(object? parameter)
        {
            Borrowing borrowing = new Borrowing(
                new BookCopy(
                _createBorrowingViewModel.BookId, "Shrek"),
                _createBorrowingViewModel.BorrowingDate,
                _createBorrowingViewModel.CardNumber);

            try
            {
                _library.CreateBorrowing(borrowing);
                MessageBox.Show("Successfully borrowed book.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                _borrowingViewNavigationService.Navigate();
            }
            catch (BorrowingConflictException ex)
            {
                MessageBox.Show("This book is already borrowed.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void OnViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(CreateBorrowingViewModel.CardNumber))
            {
                OnCanExecutedChanged();
            }
        }
    }
}
