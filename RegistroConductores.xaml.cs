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

namespace Lab2
{
    /// <summary>
    /// Lógica de interacción para RegistroConductores.xaml
    /// </summary>
    public partial class RegistroConductores : Window
    {
        public RegistroConductores()
        {
            InitializeComponent();
        }

        private void ListaConductor_Click(object sender, RoutedEventArgs e)
        {
            ListaConductor listacWindow = new ListaConductor();
            listacWindow.Show();
        }
    }
}
