using System;
using OutBackX.Model;
using OutBackX.Layers.Data;

namespace OutBackX.Layers.Business
{
    public class FuncionarioBusiness
    {

        public Funcionario Login(Funcionario funcionario)
        {
            //Efetuar login
            Funcionario _funcionario = new FuncionarioData().GetLogin(funcionario);

            // Grava os dados do funcionario no dispositivo
            SaveInvestidorLogged(funcionario);
            
            return _funcionario;

        }

        public Model.Funcionario GetFuncionarioLogged()
        {
            var cliente = new Data.FuncionarioData().Get();

            return cliente;
        }

        public void SaveInvestidorLogged(Funcionario funcionario)
        {
            new Data.FuncionarioData().Insert(funcionario);
        }
    }
}
