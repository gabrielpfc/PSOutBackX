using System;
using System.Collections.Generic;
using System.Linq;
using OutBackX.Model;
using SQLite;

namespace OutBackX.Layers.Data
{
    public class FuncionarioData
    {
        public Funcionario GetLogin(Funcionario funcionario)
        {
            if (funcionario.Login == "Admin" && funcionario.Senha == "123")
            {
                return funcionario;
            }
            else
            {
                throw new Exception("Não foi possível efetuar o logon");
            }
        }

        private Config.DbConnection _dbConn;

        public FuncionarioData()
        {
            _dbConn = new Config.DbConnection();
            _dbConn.Connection.CreateTable<Model.Funcionario>();
        }


        public Model.Funcionario Get()
        {
            return _dbConn.Connection.Table<Model.Funcionario>().FirstOrDefault();
        }

        public void Insert(Model.Funcionario _funcionarioModel)
        {
            _dbConn.Connection.Insert(_funcionarioModel);
        }


        public void Update(Model.Funcionario _funcionarioModel)
        {
            _dbConn.Connection.Update(_funcionarioModel);
        }

        public void Delete(Model.Funcionario _funcionarioModel)
        {
            _dbConn.Connection.Delete(_funcionarioModel);
        }

        public void DropTable()
        {
            _dbConn.Connection.DropTable<Model.Funcionario>();
        }
    }
}


