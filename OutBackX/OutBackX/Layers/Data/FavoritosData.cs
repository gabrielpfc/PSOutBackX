using System;
using System.Collections.Generic;
using System.Linq;
using OutBackX.Model;
using SQLite;

namespace OutBackX.Layers.Data
{
    public class FavoritosData
    {
        private Config.DbConnection _dbConn;

        public FavoritosData()
        {
            _dbConn = new Config.DbConnection();
            _dbConn.Connection.CreateTable<Model.Favorito>();
        }

        public List<Model.Favorito> GetList()
        {
            return _dbConn.Connection.Table<Model.Favorito>().ToList();
        }

        public void Insert(Model.Favorito _FavoritoModel)
        {
            _dbConn.Connection.Insert(_FavoritoModel);
        }


        public void Update(Model.Favorito _FavoritoModel)
        {
            _dbConn.Connection.Update(_FavoritoModel);
        }

        public void Delete(Model.Favorito _FavoritoModel)
        {
            _dbConn.Connection.Delete(_FavoritoModel);
        }

        public void DropTable()
        {
            _dbConn.Connection.DropTable<Model.Favorito>();
        }
    }
}


