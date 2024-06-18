namespace DesarrolloMovil3.Views;

public partial class HomePage : ContentPage
{
	public HomePage(string nombre)
	{
		InitializeComponent();

		lblNombre.Text= "Bienvenido "+nombre;
	}

}