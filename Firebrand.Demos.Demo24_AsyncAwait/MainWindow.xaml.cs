using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Firebrand.Demos.Demo24_AsyncAwait
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Task.Factory.StartNew(() => ExecuteLongRunningJob("Jipson"))
            //    .ContinueWith(prevTask => lblMessage.Content=prevTask.Result
            //    ,TaskScheduler.FromCurrentSynchronizationContext());

            //lblMessage.Content = ExecuteLongRunningJob("Jipson");
            UpdateButton("Jesus");
            lblMessage.Content = "Waiting...";
        }
        //
        private async void UpdateButton(string name)
        {
            var result = await ExecuteLongRunningJobAsync(name);
            lblMessage.Content = result;
        }
        private Task<string> ExecuteLongRunningJobAsync(string name)
        {
            return Task.Factory.StartNew(() => ExecuteLongRunningJob(name));
        }
        private string ExecuteLongRunningJob(string name)
        {
            Thread.Sleep(10000);
            return "Hello, " + name;
        }
    }
}
