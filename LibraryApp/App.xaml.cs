using LibraryApp.AppDbContext;
using LibraryApp.Exceptions;
using LibraryApp.Models;
using LibraryApp.Services;
using LibraryApp.Stores;
using LibraryApp.ViewModels;
using Microsoft.EntityFrameworkCore;
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
        private const string CONNECTION_STRING = "Data Source=library.db";

        private readonly Library _library;
        private readonly NavigationStore _navigationStore;
        public App()
        {
            _library = new Library("Biblioteka Nova");
            _navigationStore = new NavigationStore(); 
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite(CONNECTION_STRING).Options;
            using (LibraryDbContext dbContext = new LibraryDbContext(options))
            {
                dbContext.Database.Migrate();
            };

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
