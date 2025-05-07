namespace squispeS3A.Views;

public partial class vTres : ContentPage
{
	public vTres()
	{
		InitializeComponent();
	}

	private void btnGuardar_Clicked(object sender, EventArgs e)
	{
		string usuarioc = txtUsuario.Text;
		string contrasenac = txtContrasena.Text;
		DisplayAlert("Alerta", "Usuario almacenado", "ok");
		Navigaton.PushAsync(new Views.vUno(usuarioc, contrasenac));
	}
}