namespace DesarrolloMovil3.Views;

public partial class Login : ContentPage
{
    string user;
    string password;

    public Login()
    {
        InitializeComponent();
    }
    public Login(string usuario, string contrase)
	{
		InitializeComponent();
        user = usuario;
        password = contrase;
	}

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        if (user != null && password!=null)
        {
            if (user == txtUser.Text && password == txtContrasena.Text)
            {
                Navigation.PushAsync(new HomePage(user));
            }
            else
            {
                DisplayAlert("ERROR", "Usuario o contraseña incorrectos", "OK");
            }

        }
        else
        {
            DisplayAlert("Alerta", "LLENE LOS CAMPOS O REGISTRESE", "OK");
        }
        
        
        
    }

    private void btnRegistrar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Registro());
    }
}