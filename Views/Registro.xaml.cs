namespace DesarrolloMovil3.Views;

public partial class Registro : ContentPage
{
	public Registro()
	{
		InitializeComponent();
	}

    private void btnRegistrar_Clicked(object sender, EventArgs e)
    {
		string usuario = txtUser.Text;
		string contrase = txtPassword.Text;

		DisplayAlert("ALERTA", "USUARIO GUARDADO", "OK");
		Navigation.PushAsync(new Login(usuario,contrase));
    }
}