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
    /// Lógica de interacción para ReporteSalidas.xaml
    /// </summary>
    public partial class ReporteSalidas : Window
    {
        public ReporteSalidas()
        {
            InitializeComponent();
            CargarDatos(); // Llama a la función para cargar datos al inicializar la ventana
        }

        private void CargarDatos()
        {
            List<Salida> datos = new List<Salida>
            {
                new Salida { Fecha = DateTime.Now.AddDays(-1), Peso = 2000, TipoAuto = "Camión", NombreTransportista = "Juan Pérez", PesoIngreso = 1800, PesoSalida = 2000, FechaYHora = DateTime.Now.AddDays(-1).ToString() },
                new Salida { Fecha = DateTime.Now.AddDays(-2), Peso = 2200, TipoAuto = "Furgoneta", NombreTransportista = "María López", PesoIngreso = 2100, PesoSalida = 2200, FechaYHora = DateTime.Now.AddDays(-2).ToString() },
                new Salida { Fecha = DateTime.Now.AddDays(-3), Peso = 2500, TipoAuto = "Camión", NombreTransportista = "Carlos Ruiz", PesoIngreso = 2400, PesoSalida = 2500, FechaYHora = DateTime.Now.AddDays(-3).ToString() },
                new Salida { Fecha = DateTime.Now.AddDays(-4), Peso = 2700, TipoAuto = "Camioneta", NombreTransportista = "Ana García", PesoIngreso = 2600, PesoSalida = 2700, FechaYHora = DateTime.Now.AddDays(-4).ToString() },
                new Salida { Fecha = DateTime.Now.AddDays(-5), Peso = 3000, TipoAuto = "Camión", NombreTransportista = "Luis Martínez", PesoIngreso = 2900, PesoSalida = 3000, FechaYHora = DateTime.Now.AddDays(-5).ToString() },
                new Salida { Fecha = DateTime.Now.AddDays(-6), Peso = 3200, TipoAuto = "Furgoneta", NombreTransportista = "Laura Fernández", PesoIngreso = 3100, PesoSalida = 3200, FechaYHora = DateTime.Now.AddDays(-6).ToString() },
                new Salida { Fecha = DateTime.Now.AddDays(-7), Peso = 3400, TipoAuto = "Camión", NombreTransportista = "Pedro Sánchez", PesoIngreso = 3300, PesoSalida = 3400, FechaYHora = DateTime.Now.AddDays(-7).ToString() },
                new Salida { Fecha = DateTime.Now.AddDays(-8), Peso = 3600, TipoAuto = "Camioneta", NombreTransportista = "Lucía Torres", PesoIngreso = 3500, PesoSalida = 3600, FechaYHora = DateTime.Now.AddDays(-8).ToString() },
                new Salida { Fecha = DateTime.Now.AddDays(-9), Peso = 3800, TipoAuto = "Furgoneta", NombreTransportista = "Javier Castro", PesoIngreso = 3700, PesoSalida = 3800, FechaYHora = DateTime.Now.AddDays(-9).ToString() },
                new Salida { Fecha = DateTime.Now.AddDays(-10), Peso = 4000, TipoAuto = "Camión", NombreTransportista = "Sofía Romero", PesoIngreso = 3900, PesoSalida = 4000, FechaYHora = DateTime.Now.AddDays(-10).ToString() },
            };

            DatosSalidasListView.ItemsSource = datos; // Asigna la lista de datos al ListView
        }
    }

    public class Salida
    {
        public DateTime Fecha { get; set; }
        public double Peso { get; set; }
        public string TipoAuto { get; set; }
        public string NombreTransportista { get; set; }
        public double PesoIngreso { get; set; }
        public double PesoSalida { get; set; }
        public string FechaYHora { get; set; }
    }
}