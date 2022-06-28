using LibraryApp.Exceptions;
using LibraryApp.Models;
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
        public App()
        {
            _library = new Library("Biblioteka Nova");
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_library)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
