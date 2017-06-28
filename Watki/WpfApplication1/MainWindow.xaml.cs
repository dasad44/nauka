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


namespace WpfApplication1
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
        Thread t;
        int i = 0;
        private void button_Click(object sender, RoutedEventArgs e)
        {
            t = new Thread(Counting_in_main_thread);   //tworzy nowy wątek
            t.Start();  
        }
        public void Counting_in_main_thread()  //funkcja
        {
            this.Dispatcher.Invoke(() => { tmp_function(); });  //używamy kiedy chcemy coś zmienić w UI używając innego wątku
          /////////////////////////
            for (; ; )
            {
                // kod bez ingerencji w UI
            }
            ///////////////////////
        }
       
        public void tmp_function() //funkcja pomocnicza do Dispatchera
        {
            label.Content = i++;
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            t.Abort();
        }
    }
}
