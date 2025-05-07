namespace squispeS3A.Views;

public partial class vUno : ContentPage
{
	public vUno()
	{
		InitializeComponent();
	}
	string usuariof = "";
	string contrasenaf = "";
	public vUno (string usuario, string contrasena)
	{
        InitializeComponent();
		this.usuariof = usuario;
		this contrasenaf = contrasena;
    }
	private void btnIniciarSesion_Clicked(object sender, EventArgs e)
	{
		if(txtUsuario.Text == usuariof && txtContrasena.Text == contrasenaf)
		{
			Navigation.PushAsync(new Views.vDos(usuariof));
		}
		else
		{
			DisplayAlert("Alerta", "Usuario/Contraseña incorrectos", "OK");
		}
	}
}