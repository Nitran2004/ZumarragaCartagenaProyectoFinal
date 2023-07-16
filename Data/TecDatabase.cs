using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LomasZumarraga_ProyectoFinal.Models;
using Microsoft.Maui.Controls;
using SQLite;

namespace LomasZumarraga_ProyectoFinal.Data
{
    public class TecDatabase
    {
        string _dbPath4;
        private SQLiteConnection conn4;
        public string StatusMessage { get; set; }

        public TecDatabase(string DatabasePath4)
        {
            _dbPath4 = DatabasePath4;
        }

        private void Init()
        {
            if (conn4 != null)
                return;
            conn4 = new SQLiteConnection(_dbPath4);
            conn4.CreateTable<Tecnologia>();
        }

        public int AddNewTecnologia(string tecnologia)
        {
            Init();
            int result = conn4.Insert(tecnologia);
            return result;
        }

        public List<Tecnologia> GetAllTecnologia()
        {
            Init();
            List<Tecnologia> tecnologia = conn4.Table<Tecnologia>().ToList();
            return tecnologia;
        }
    }
}
