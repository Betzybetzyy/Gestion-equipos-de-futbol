using EVA1.Contenedor;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EVA1
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

        private void MenuItem_AgregarEquipo_Click(object sender, RoutedEventArgs e)
        {
            Contenedor.AgregarEquipo agregarEquipoWindow = new AgregarEquipo();
            agregarEquipoWindow.ShowDialog();
        }
        private void MenuItem_ListarEquipo_Click(Object sender, RoutedEventArgs e)
        {
            Contenedor.ListarEquipo listarEquipoWindows = new ListarEquipo();
            listarEquipoWindows.ShowDialog();
        }

        private void MenuItem_AcercaDe_Click(object sender, RoutedEventArgs e)
        {
            Contenedor.AcercaDe acercaDeWindow = new AcercaDe();
            acercaDeWindow.ShowDialog();
        }
    }
}
