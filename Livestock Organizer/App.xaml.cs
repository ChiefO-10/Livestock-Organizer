using LivestockOrganizer.ViewModels;
using LivestockOrganizer.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace LivestockOrganizer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var view = new MainView();
            var viewmodel = new MainViewModel(); 
            view.DataContext = viewmodel;
            view.Show();
        }
    }
}
