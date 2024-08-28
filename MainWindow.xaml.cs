using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab2
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

        private void MenuItem_Salida_Click(object sender, RoutedEventArgs e)
        {
            RegistroSalidas salidaWindow = new RegistroSalidas();
            salidaWindow.Show();
        }
        private void MenuItem_Conductores_Click(object sender, RoutedEventArgs e)
        {
            RegistroConductores registroconductorWindow = new RegistroConductores();
            registroconductorWindow.Show();
        }
        private void MenuItem_Camiones_Click(object sender, RoutedEventArgs e)
        {
            RegistroCamiones registrocamionesWindow = new RegistroCamiones();
            registrocamionesWindow.Show();
        }

        private void MenuItem_Salidas_Clickk(object sender, RoutedEventArgs e)
        {
            ReporteSalidas registrocamionesWindow = new ReporteSalidas();
            registrocamionesWindow.Show();
        }

        private void MenuItem_Salidas_Click(object sender, RoutedEventArgs e)
        {
            ReporteSalidas registrocamionesWindow = new ReporteSalidas();
            registrocamionesWindow.Show();
        }
    }
}