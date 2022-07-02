using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using System.Data.Entity;

namespace data0
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db.CPU.Load();
            Grid1.ItemsSource = db.CPU.Local.ToBindingList();
        }

        database0Entities db = database0Entities.GetContext();

        private void q1_Click(object sender, RoutedEventArgs e)
        {
            Add1 f = new Add1();
            f.ShowDialog();
            Grid1.Focus();

            db.CPU.Load();
            Grid1.ItemsSource = db.CPU.ToList();
            Grid1.ItemsSource = db.CPU.Local.ToBindingList();
        }

        private void q2_Click(object sender, RoutedEventArgs e)
        {
            int indexRow = Grid1.SelectedIndex;
            if (indexRow != -1)
            {
                CPU row = (CPU)Grid1.Items[indexRow];

                Class1.Код_CPU = row.Код_CPU;
                Class1.Модель = row.Модель;
                Class1.Сокет = row.Сокет;
                Class1.Ядро = row.Ядро;
                Class1.Техпроцесс = row.Техпроцесс;
                Class1.Частота = row.Частота;
                Class1.Тип_памяти = row.Тип_памяти;
                Class1.Стоимость = row.Стоимость;

                Edit1 f = new Edit1();
                f.ShowDialog();

                Grid1.Items.Refresh();
                Grid1.Focus();
            }
        }

        private void q3_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result;
            result = MessageBox.Show("удалить запись?", "удаление записи", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    CPU row = (CPU)Grid1.SelectedItems[0];

                    db.CPU.Remove(row);
                    db.SaveChanges();
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("выберите запись");
                }
            }
        }

        private void w1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void w2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void w3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void e1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void e2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void e3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void r1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void r2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void r3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void t1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void t2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void t3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void y1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void y2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void y3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void u1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void u2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void u3_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
