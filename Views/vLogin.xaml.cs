namespace ACollahuazoS2.Views;

public partial class vLogin : ContentPage
{

    string[] usuarios = { "Carlos", "Ana", "Jose" };
    string[] contrasenas = { "carlos123", "ana123", "jose123" };

    public vLogin()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        string user = txtUsuario.Text?.Trim();
        string pass = txtPassword.Text?.Trim();

        bool acceso = false;
        string nombreUsuario = "";

        // Validar usuario y contraseña
        for (int i = 0; i < usuarios.Length; i++)
        {
            if (user == usuarios[i] && pass == contrasenas[i])
            {
                acceso = true;
                nombreUsuario = usuarios[i];
                break;
            }
        }

        if (acceso)
        {       
            await DisplayAlert("Bienvenido", $"Hola {nombreUsuario}, has iniciado sesión correctamente.", "Continuar");

            txtUsuario.Text = string.Empty;
            txtPassword.Text = string.Empty;

            // Navegar a la vista principal (vInicio)
            await Navigation.PushAsync(new vInicio(nombreUsuario));

        }
        else
        {
            lblMensaje.Text = "Usuario o contraseña incorrectos.";

            txtUsuario.Text = string.Empty;
            txtPassword.Text = string.Empty;

            txtUsuario.Focus();
        }
    }
}