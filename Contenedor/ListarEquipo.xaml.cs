using EVA1.Contenedor.Clases;
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

namespace EVA1.Contenedor
{
    /// <summary>
    /// Lógica de interacción para ListarEquipo.xaml
    /// </summary>
    public partial class ListarEquipo : Window
    {
        public ListarEquipo()
        {
            InitializeComponent();
            dgListadoEquipos.ItemsSource = EquipoCollection.ListaEquipos;
            dgListadoEquipos.CanUserAddRows = false;
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            var filaSeleccionada = (Equipo)dgListadoEquipos.SelectedItem;
            ActualizarEquipo actualizar = new(filaSeleccionada);
            actualizar.ShowDialog();
            
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            int index = dgListadoEquipos.SelectedIndex;
            EquipoCollection.ListaEquipos.RemoveAt(index);
            dgListadoEquipos.Items.Refresh();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            dgListadoEquipos.Items.Refresh();
        }
    }
}
