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
    /// Lógica de interacción para RegistroCamiones.xaml
    /// </summary>
    public partial class RegistroCamiones : Window
    {
        public RegistroCamiones()
        {
            InitializeComponent();
        }
        private void ListaCamionButton_Click(object sender, RoutedEventArgs e)
        {
            ListaCamion listaWindow = new ListaCamion();
            listaWindow.Show();
        }
    }
}
