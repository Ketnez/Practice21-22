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
    /// Логика взаимодействия для Add1.xaml
    /// </summary>
    public partial class Add1 : Window
    {
        public Add1()
        {
            InitializeComponent();
        }

        database0Entities db = database0Entities.GetContext();

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

            CPU p1 = new CPU();

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
                db.CPU.Add(p1);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
