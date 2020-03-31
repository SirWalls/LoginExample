using LoginExample.Services;
using LoginExample.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LoginExample.ViewModels
{
    public class LoginViewModel
    {

        #region Services
        
        private LoginService loginService;

        #endregion

        #region Properties

        public string User { get; set; }
        public string Password { get; set; }

        #endregion
        
        #region Constructors

        public LoginViewModel()
        {
            //inicializacion servicios
            loginService = new LoginService();
        }

        #endregion

        #region Commands

        public Command LoginCommand
        {
            get
            { return new Command(Login);
            }
        }

        #endregion

        #region Methods

        private void Login()
        {
            //capamos desde cliente las restricciones que veamos necesarias, en este caso que los campos no estén vacios
            if (string.IsNullOrEmpty(User) || string.IsNullOrEmpty(Password))
            {
                App.Current.MainPage.DisplayAlert("", "Debe ingresar usuario y contraseña","Ok");
                return;
            }
            else
            {
                //usamos el servicio para logearnos
                if (loginService.Login(User, Password))
                {
                    App.Current.MainPage = new NavigationPage(new UserPage());
                }
                else
                    App.Current.MainPage.DisplayAlert("Error", "Credenciales no válidas. Prueba con 'Usuario' y '1234' :)", "Ok");
            }
        }

        #endregion

    }
}
