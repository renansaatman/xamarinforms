using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyPBs.ViewModels
{
    public class PrincipalPageViewModel
    {
        public Command ClickVer { get; set; }

        public PrincipalPageViewModel()
        {
            ClickVer = new Command(ExecuteClickVer);

        }

        private void ExecuteClickVer()
        {
            
        }
    }
}
