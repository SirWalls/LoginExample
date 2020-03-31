using LoginExample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginExample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
        LoginViewModel loginViewModel;
		public LoginPage()
		{
            loginViewModel = new LoginViewModel();
            InitializeComponent();
            BindingContext = loginViewModel;
		}
	}
}