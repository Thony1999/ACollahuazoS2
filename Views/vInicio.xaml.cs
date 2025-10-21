namespace ACollahuazoS2.Views;

public partial class vInicio : ContentPage
{
	public vInicio()
	{
		InitializeComponent();
	}

	private async void btnMostrar_Clicked(object sender, EventArgs e)
	{
		try
		{
            string nombre = txtNombre.Text;
            string pais = pkPaises.Items[pkPaises.SelectedIndex].ToString();
            string fecha = dpFecha.Date.ToString();
            lblNombre.Text = nombre;
            lblPais.Text = pais;
            lblFecha.Text = fecha;
        }
		catch (Exception ex) {

            await DisplayAlert("Error", "Por favor, ingrese datos válidos en todos los campos.", "Entendido");
          
        }
    }
}