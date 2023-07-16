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
    public class ArteViewModel
    {
        private ArtDatabase _artDatabase;

        public ObservableCollection<Arte> ArteItems { get; set; }

        public ArteViewModel()
        {
            _artDatabase = new ArtDatabase("database_path"); // Reemplaza "database_path" con la ruta de tu base de datos
            ArteItems = new ObservableCollection<Arte>(_artDatabase.GetAllArte());
        }

        // Aquí puedes agregar métodos y propiedades adicionales según las necesidades de tu página Arte
    }
}
