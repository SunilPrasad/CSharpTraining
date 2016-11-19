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

namespace ThreadResponsivenessExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool _isRunning = true;
        private int _lastNumber = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Start_OnClick(object sender, RoutedEventArgs e)
        {
           Thread thread = new Thread(Start);
           thread.Start();

        }

        private void Stop_OnClick(object sender, RoutedEventArgs e)
        {
            _isRunning = false;
            _lastNumber = Convert.ToInt32(numberText.Text);
        }

        private void Start()
        {
            _isRunning = true;

            while (_isRunning)
            {
                Thread.Sleep(100);
                _lastNumber = _lastNumber + 1;
                Dispatcher.Invoke(() => numberText.Text = _lastNumber.ToString());
            }
        }
    }
}
