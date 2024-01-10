using ProductoAppMAUI.Models;
using ProductoAppMAUI.Service;

namespace ProductoAppMAUI;

public partial class Login : ContentPage
{
    private readonly APIService _APIService;
        public Login(APIService apiservice)
    {
        InitializeComponent();
        _APIService = apiservice;
    }

    private async void OnClickLogIn(object sender, EventArgs e)
    {
        //Verificar que el formulario no est� vac�o
        if (string.IsNullOrEmpty(Correo.Text) || string.IsNullOrEmpty(Contrasenia.Text))
        {
            await DisplayAlert("Error", "Debe completar todos los campos.", "OK");
            return;
        }

        string username = Correo.Text;
        string password = Contrasenia.Text;
        User user = new User
        {
            Correo = username,
            Contrasenia = password,
        };


        User user2 = await _APIService.GetUser(user);
        if (user2 != null)
        {
            Preferences.Set("username", user2.Nombre);
            Preferences.Set("IdUser", user2.IdUsuario.ToString());
            await App.Current.MainPage.Navigation.PushAsync(new ProductoPage(_APIService));
        }
        else 
        {
            await DisplayAlert("Error", "Usuario o Contrase�a no encontrados, verifique que los ingres� correctamente", "OK");
            return;
        }
    }

    private async void OnClickRegisterView(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Register(_APIService));
    }
}