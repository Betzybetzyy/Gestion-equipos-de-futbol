using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVA1.Contenedor.Clases
{
    public static class EquipoCollection
    {
        public static ObservableCollection<Equipo> ListaEquipos { get; set; } = new ObservableCollection<Equipo>();

    }
}
