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
    /// Lógica de interacción para ListaConductor.xaml
    /// </summary>
    public partial class ListaConductor : Window
    {
        public ListaConductor()
        {
            InitializeComponent();
            CargarDatos(); // Llama a la función para cargar datos al inicializar la ventana
        }

        private void CargarDatos()
        {
            List<Conductor> datos = new List<Conductor>
            {
                new Conductor { Nombre = "Juan Pérez", Licencia = "A1", Telefono = "987654321", Vehiculo = "Toyota" },
                new Conductor { Nombre = "María López", Licencia = "B2", Telefono = "976543210", Vehiculo = "Honda" },
                new Conductor { Nombre = "Carlos Ruiz", Licencia = "A3", Telefono = "965432109", Vehiculo = "Nissan" },
                new Conductor { Nombre = "Ana García", Licencia = "C4", Telefono = "954321098", Vehiculo = "Ford" },
                new Conductor { Nombre = "Luis Martínez", Licencia = "A5", Telefono = "943210987", Vehiculo = "Chevrolet" },
                new Conductor { Nombre = "Laura Fernández", Licencia = "B6", Telefono = "932109876", Vehiculo = "Hyundai" },
                new Conductor { Nombre = "Pedro Sánchez", Licencia = "A7", Telefono = "921098765", Vehiculo = "Kia" },
                new Conductor { Nombre = "Lucía Torres", Licencia = "C8", Telefono = "910987654", Vehiculo = "Volkswagen" },
                new Conductor { Nombre = "Javier Castro", Licencia = "A9", Telefono = "909876543", Vehiculo = "Mazda" },
                new Conductor { Nombre = "Sofía Romero", Licencia = "B10", Telefono = "898765432", Vehiculo = "Subaru" },
            };

            DatosConductorListView.ItemsSource = datos; // Asigna la lista de datos al ListView
        }
    }

    public class Conductor
    {
        public string Nombre { get; set; }
        public string Licencia { get; set; }
        public string Telefono { get; set; }
        public string Vehiculo { get; set; }
    }
}