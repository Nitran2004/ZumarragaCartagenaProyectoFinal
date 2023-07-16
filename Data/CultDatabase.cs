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
    public class CultDatabase
    {
        string _dbPath2;
        private SQLiteConnection conn2;
        public string StatusMessage { get; set; }

        public CultDatabase(string DatabasePath2)
        {
            _dbPath2 = DatabasePath2;
        }

        private void Init()
        {
            if (conn2 != null)
                return;
            conn2 = new SQLiteConnection(_dbPath2);
            conn2.CreateTable<Cultura>();
        }

        public int AddNewCultura(string cultura)
        {
            Init();
            int result = conn2.Insert(cultura);
            return result;
        }

        public List<Cultura> GetAllCultura()
        {
            Init();
            List<Cultura> cultura = conn2.Table<Cultura>().ToList();
            return cultura;
        }
    }
}
