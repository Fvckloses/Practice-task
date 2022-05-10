using ApplicationContextDB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace task1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private const string ConnectionString = @"Data Source=D:\MEGA\C# practice_College\college-practice\topic30_DataBases\task1\bin\Debug\net5.0-windows\DBTur_firm.db;";

        public void OnStartup(object sender, StartupEventArgs e)
        {
            //var builder = new DbContextOptionsBuilder<ApplicationContext>();
            //builder.UseSqlite(ConnectionString);
            //var options = builder.Options;
            //var context = new ApplicationContext(options)
            var context = new ApplicationContext(
                new DbContextOptionsBuilder<ApplicationContext>()
                    .UseSqlite(ConnectionString)
                    .Options);
            //context.Database.EnsureCreated();
            var window = new MainWindow(context);
            window.ShowDialog();
        }
    }
}
