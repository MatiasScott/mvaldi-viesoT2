using static System.Runtime.InteropServices.JavaScript.JSType;

namespace mvaldiñviesoT2.Views;

public partial class login : ContentPage
{
	public login()
	{
		InitializeComponent();
	}

    string[] user = { "Carlos", "Ana", "Jose" };
    string[] pass = { "carlos123", "ana123", "jose123" };

    private void btnLogin_Clicked(object sender, EventArgs e)
	{
        string usuario = txtnombre.Text;
        string contrania = txtcontrasena.Text;

        int index = Array.IndexOf(user, usuario);

        if (index != -1 && pass[index] == contrania)
        {
            DisplayAlert("Inicio de sesión", $"Bienvenido {usuario}", "OK");
            Navigation.PushAsync(new Views.presentacion());
        }
        else
        {
            DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
        }
    }
}