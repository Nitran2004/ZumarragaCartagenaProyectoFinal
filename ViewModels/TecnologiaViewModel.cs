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
    public class TecnologiaViewModel
    {
        private TecDatabase _tecDatabase;

        public ObservableCollection<Tecnologia> TecnologiaItems { get; set; }

        public TecnologiaViewModel()
        {
            _tecDatabase = new TecDatabase("database_path"); // Reemplaza "database_path" con la ruta de tu base de datos
            TecnologiaItems = new ObservableCollection<Tecnologia>(_tecDatabase.GetAllTecnologia());
        }

        // Aquí puedes agregar métodos y propiedades adicionales según las necesidades de tu página Tecnologia
    }
}
