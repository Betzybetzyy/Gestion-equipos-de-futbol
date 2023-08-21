using EVA1.Contenedor.Clases;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Lógica de interacción para AgregarEquipo.xaml
    /// </summary>


    public partial class AgregarEquipo : Window
    {
        public AgregarEquipo()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void btnAgregarEquipo_Click(object sender, RoutedEventArgs e)
        {
            string NombreEquipo = txtNombreEquipo.Text;
            int CantidadJugadores = Convert.ToInt32(txtJugadores.Text);
            string NombreDT = txtNombreDt.Text;
            string TipoEquipo = txtTipoEquipo.Text;
            string CapitanEquipo = txtCapitan.Text;
            bool TieneSub21 = checkSub21.IsChecked.Value ? true : false;

            Equipo equipo = new(NombreEquipo, CantidadJugadores, NombreDT, TipoEquipo, CapitanEquipo, TieneSub21);

            EquipoCollection.ListaEquipos.Add(equipo);

            this.Close();
        }

        private static Regex s_regex = new Regex("[^0-9]+");

        private void CheckTextInput(object sender, TextCompositionEventArgs e )
        {
            e.Handled = s_regex.IsMatch(e.Text);
        }
    }
}
