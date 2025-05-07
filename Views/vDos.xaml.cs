namespace squispeS3A.Views;

public partial class vDos : ContentPage
{
	public vDos(string usuario)
	{
		InitializeComponent();
		lblUsuario.Text="Usuario conectado " + usuario;
	}
}