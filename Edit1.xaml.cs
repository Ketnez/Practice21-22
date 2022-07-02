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
using System.Windows.Shapes;

namespace data0
{
    /// <summary>
    /// Логика взаимодействия для Edit1.xaml
    /// </summary>
    public partial class Edit1 : Window
    {
        public Edit1()
        {
            InitializeComponent();
        }

        database0Entities db = database0Entities.GetContext();

        CPU p1;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            p1 = db.CPU.Where(p => p.Код_CPU == Class1.Код_CPU).FirstOrDefault();

            tt1.Text = Convert.ToString(p1.Код_CPU);
            tt2.Text = Convert.ToString(p1.Модель);
            tt3.Text = Convert.ToString(p1.Сокет);
            tt4.Text = Convert.ToString(p1.Ядро);
            tt5.Text = Convert.ToString(p1.Техпроцесс);
            tt6.Text = Convert.ToString(p1.Частота);
            tt7.Text = Convert.ToString(p1.Тип_памяти);
            tt8.Text = Convert.ToString(p1.Стоимость);
        }

        private void bb11_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (tt1.Text.Length == 0)
            {
                errors.AppendLine("ошибка 1");
            }

            if (tt2.Text.Length == 0)
            {
                errors.AppendLine("ошибка 2");
            }

            if (tt3.Text.Length == 0)
            {
                errors.AppendLine("ошибка 3");
            }

            if (tt4.Text.Length == 0)
            {
                errors.AppendLine("ошибка 4");
            }

            if (tt5.Text.Length == 0)
            {
                errors.AppendLine("ошибка 5");
            }

            if (tt6.Text.Length == 0)
            {
                errors.AppendLine("ошибка 6");
            }

            if (tt7.Text.Length == 0)
            {
                errors.AppendLine("ошибка 7");
            }

            if (tt8.Text.Length == 0)
            {
                errors.AppendLine("ошибка 8");
            }


            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }


            p1.Код_CPU = Convert.ToInt32(tt1.Text);
            p1.Модель = Convert.ToString(tt2.Text);
            p1.Сокет = Convert.ToString(tt3.Text);
            p1.Ядро = tt4.Text;
            p1.Техпроцесс = Convert.ToString(tt5.Text);
            p1.Частота = Convert.ToString(tt6.Text);
            p1.Тип_памяти = Convert.ToString(tt7.Text);
            p1.Стоимость = Convert.ToInt32(tt8.Text);

            try
            {
                db.SaveChanges();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
