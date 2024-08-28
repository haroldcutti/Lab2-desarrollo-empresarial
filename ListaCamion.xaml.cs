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
    /// Lógica de interacción para ListaCamion.xaml
    /// </summary>
    public partial class ListaCamion : Window
    {
        public ListaCamion()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            List<Registro> datos = new List<Registro>
            {
                new Registro { PesoMaximo = 5000, Placa = "ABC123", PesoVacio = 2000 },
                new Registro { PesoMaximo = 6000, Placa = "DEF456", PesoVacio = 2200 },
                new Registro { PesoMaximo = 5500, Placa = "GHI789", PesoVacio = 2100 },
                new Registro { PesoMaximo = 6500, Placa = "JKL012", PesoVacio = 2300 },
                new Registro { PesoMaximo = 7000, Placa = "MNO345", PesoVacio = 2400 },
                new Registro { PesoMaximo = 8000, Placa = "PQR678", PesoVacio = 2500 },
                new Registro { PesoMaximo = 7500, Placa = "STU901", PesoVacio = 2600 },
                new Registro { PesoMaximo = 9000, Placa = "VWX234", PesoVacio = 2700 },
                new Registro { PesoMaximo = 9500, Placa = "YZA567", PesoVacio = 2800 },
                new Registro { PesoMaximo = 10000, Placa = "BCD890", PesoVacio = 2900 },
            };

            DatosListView.ItemsSource = datos; // Asigna la lista de datos al ListView
        }
    }

    public class Registro
    {
        public int PesoMaximo { get; set; }
        public string Placa { get; set; }
        public int PesoVacio { get; set; }
    }
}