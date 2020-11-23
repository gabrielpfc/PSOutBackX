using System;
using System.Collections.Generic;
using System.Linq;
using OutBackX.Model;
using SQLite;

namespace OutBackX.Layers.Data
{
    public class RestauranteData
    {
        private Config.DbConnection _dbConn;

        public RestauranteData()
        {
            _dbConn = new Config.DbConnection();
            _dbConn.Connection.CreateTable<Model.Restaurante>();
        }

        public List<Model.Restaurante> GetList()
        {
            return _dbConn.Connection.Table<Model.Restaurante>().ToList();
        }

        public void Insert(Model.Restaurante _RestauranteModel)
        {
            _dbConn.Connection.Insert(_RestauranteModel);
        }


        public void Update(Model.Restaurante _RestauranteModel)
        {
            _dbConn.Connection.Update(_RestauranteModel);
        }

        public void Delete(Model.Restaurante _RestauranteModel)
        {
            _dbConn.Connection.Delete(_RestauranteModel);
        }

        public void DropTable()
        {
            _dbConn.Connection.DropTable<Model.Restaurante>();
        }
    }
}


