namespace squispeExamen.Views;

public partial class Login : ContentPage
{
    private readonly string[] usuarios = { "estudiante2025", "uisrael", "sistemas" };
    private readonly string[] contrasenas = { "moviles", "2025 ", "2025_1" };
    public Login()
	{
		InitializeComponent();
	}

    private async void btnInicioSesion_Clicked(object sender, EventArgs e)
    {
        string user = txtUsuario.Text;
        string pass = txtContrasena.Text;

        bool encontrado = false;
        int indice = -1;

        for (int i = 0; i < usuarios.Length; i++)
            {
                if (usuarios[i].Equals(user, StringComparison.OrdinalIgnoreCase) && contrasenas[i] == pass)
                {
                    encontrado = true;
                    indice = i;
                    break;
                }
            }

            if (encontrado)
            {
                await DisplayAlert("Bienvenido", $"Hola {usuarios[indice]}!", "OK");
                await Navigation.PushAsync(new Views.Registro(usuarios[indice]));
            }
            else
            {
                await DisplayAlert("Error", "Usuario o contraseña incorrectos.", "OK");
            }
    }
    private async void btnAcercade_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Info", "Este programa fue realizado por Salomé Quispe","OK");
    }
}