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
    public class DepDatabase
    {
        string _dbPath3;
        private SQLiteConnection conn3;
        public string StatusMessage { get; set; }

        public DepDatabase(string DatabasePath3)
        {
            _dbPath3 = DatabasePath3;
        }

        private void Init()
        {
            if (conn3 != null)
                return;
            conn3 = new SQLiteConnection(_dbPath3);
            conn3.CreateTable<Deportes>();
        }

        public int AddNewDeportes(string deportes)
        {
            Init();
            int result = conn3.Insert(deportes);
            return result;
        }

        public List<Deportes> GetAllDeportes()
        {
            Init();
            List<Deportes> deportes = conn3.Table<Deportes>().ToList();
            return deportes;
        }
    }
}
