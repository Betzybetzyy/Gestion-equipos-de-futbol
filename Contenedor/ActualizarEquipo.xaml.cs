using EVA1.Contenedor.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Lógica de interacción para ActualizarEquipo.xaml
    /// </summary>
    public partial class ActualizarEquipo : Window
    {
        Equipo equipoGlobal = new Equipo();
    
        public ActualizarEquipo(Equipo equipo)
        {
            InitializeComponent();
            equipoGlobal = equipo;
            CargarDatosEquipo();
        }

        private void btnActualizarEquipo_Click(object sender, RoutedEventArgs e)
        {
            Equipo temporal = new();
            temporal.NombreEquipo = txtNombreEquipo.Text;
            temporal.CantidadJugadores = Convert.ToInt32(txtJugadores.Text);
            temporal.NombreDT = txtNombreDt.Text;
            temporal.TipoEquipo = txtTipoEquipo.Text;
            temporal.CapitanEquipo = txtCapitan.Text;
            temporal.TieneSub21 = checkSub21.IsChecked.Value ? true : false;

            int index = EquipoCollection.ListaEquipos.IndexOf(this.equipoGlobal);
            EquipoCollection.ListaEquipos.RemoveAt(index);
            EquipoCollection.ListaEquipos.Insert(index, temporal);
            this.Close();
        }

        private void CargarDatosEquipo()
        {
            txtNombreEquipo.Text = equipoGlobal.NombreEquipo;
            txtJugadores.Text = equipoGlobal.CantidadJugadores.ToString();
            txtNombreDt.Text = equipoGlobal.NombreDT;
            txtTipoEquipo.Text = equipoGlobal.TipoEquipo;
            txtCapitan.Text = equipoGlobal.CapitanEquipo;
            checkSub21.IsChecked = (equipoGlobal.TieneSub21) ? true : false;
             
        }

        private static Regex s_regex = new Regex("[^0-9]+");

        private void CheckTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = s_regex.IsMatch(e.Text);
        }
    }
}
