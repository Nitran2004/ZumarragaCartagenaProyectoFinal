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
    public class DeportesViewModel
    {
        private DepDatabase _depDatabase;

        public ObservableCollection<Deportes> DeportesItems { get; set; }

        public DeportesViewModel()
        {
            _depDatabase = new DepDatabase("database_path"); // Reemplaza "database_path" con la ruta de tu base de datos
            DeportesItems = new ObservableCollection<Deportes>(_depDatabase.GetAllDeportes());
        }

        // Aquí puedes agregar métodos y propiedades adicionales según las necesidades de tu página Deportes
    }
}
