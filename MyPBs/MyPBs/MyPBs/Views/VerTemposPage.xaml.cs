using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyPBs.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VerTemposPage : ContentPage
	{
		public VerTemposPage ()
		{
			InitializeComponent ();
            BindingContext = new ViewModels.VerTemposPageViewModel();
		}
	}
}