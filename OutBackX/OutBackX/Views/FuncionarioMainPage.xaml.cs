using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OutBackX.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FuncionarioMainPage : ContentPage
    {
        public FuncionarioMainPage()
        {
            InitializeComponent();
        }

        public void SairClicked(object o, EventArgs e)
        {

            MessagingCenter.Send<String>("", "Logoff");

        }
    }
}