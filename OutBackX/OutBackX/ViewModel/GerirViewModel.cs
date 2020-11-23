using System;
using System.Collections.Generic;
using System.Windows.Input;
using OutBackX.Views.Components;
using Xamarin.Forms;

namespace OutBackX.ViewModel
{
    public class GerirViewModel
    {
        public ICommand VoltarClicked { get; private set; }

        public GerirViewModel()
        {
            VoltarClicked = new Command(() => {
                MessagingCenter.Send<GerirViewModel>(this, "MainPageAbrir");
            });
        }

    }
}
