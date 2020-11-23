using System;
namespace OutBackX.Layers.Business
{
    public class LogoffBusiness
    {

        public void Logoff()
        {
            string message = string.Empty;

            try
            {
                new Data.FuncionarioData().Delete(Model.Global.Funcionario);
                Model.Global.Funcionario = null;
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }

        }

    }
}
