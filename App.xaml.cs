using LibraryApp.Exceptions;
using LibraryApp.Models;
using LibraryApp.Services;
using LibraryApp.Stores;
using LibraryApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace LibraryApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly Library _library;
        private readonly NavigationStore _navigationStore;
        public App()
        {
            _library = new Library("Biblioteka Nova");
            _navigationStore = new NavigationStore(); 
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = MakeBorrowingListingViewModel(); //starging page view model
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }

        private CreateBorrowingViewModel MakeCreateBorrowingViewModel()
        {
            return new CreateBorrowingViewModel(_library, new NavigationService(_navigationStore, MakeBorrowingListingViewModel));
        }

        private BorrowingListingViewModel MakeBorrowingListingViewModel()
        {
            return new BorrowingListingViewModel(_library ,new NavigationService(_navigationStore, MakeCreateBorrowingViewModel));
        }
    }
}
