using LibraryApp.Exceptions;
using LibraryApp.Models;
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
        protected override void OnStartup(StartupEventArgs e)
        {
            Library library = new Library("Biblioteka Nova");

            try
            {

                library.CreateBorrowing(new Borrowing(
                    new BookCopy(1, "Diuna"), new DateTime(2022, 4, 4), "123123123"));
                library.CreateBorrowing(new Borrowing(
                    new BookCopy(2, "Pablo Escobar"), new DateTime(2022, 4, 4), "123123123"));
            }
            catch (BorrowingConflictException ex)
            {

            }

            IEnumerable<Borrowing> borrowings = library.GetBorrowings();

            base.OnStartup(e);
        }
    }
}
