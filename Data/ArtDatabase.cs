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
    public class ArtDatabase
    {
        string _dbPath1;
        private SQLiteConnection conn1;
        public string StatusMessage { get; set; }

        public ArtDatabase(string DatabasePath1)
        {
            _dbPath1 = DatabasePath1;
        }

        private void Init()
        {
            if (conn1 != null)
                return;
            conn1 = new SQLiteConnection(_dbPath1);
            conn1.CreateTable<Arte>();
        }

        public int AddNewArte(string arte)
        {
            Init();
            int result = conn1.Insert(arte);
            return result;
        }

        public List<Arte> GetAllArte()
        {
            Init();
            List<Arte> arte = conn1.Table<Arte>().ToList();
            return arte;
        }
    }
}
