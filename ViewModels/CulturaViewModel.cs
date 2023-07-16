using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LomasZumarraga_ProyectoFinal.Models;
using LomasZumarraga_ProyectoFinal.Data;
using System.Collections.ObjectModel;

namespace LomasZumarraga_ProyectoFinal.ViewModels
{
    public class CulturaViewModel
    {
        private CultDatabase _cultDatabase;

        public ObservableCollection<Cultura> CulturaItems { get; set; }

        public CulturaViewModel()
        {
            _cultDatabase = new CultDatabase("database_path"); // Reemplaza "database_path" con la ruta de tu base de datos
            CulturaItems = new ObservableCollection<Cultura>(_cultDatabase.GetAllCultura());
        }

        // Aquí puedes agregar métodos y propiedades adicionales según las necesidades de tu página Cultura
    }
}
