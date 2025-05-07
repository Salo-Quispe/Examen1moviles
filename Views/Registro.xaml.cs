namespace squispeExamen.Views;

public partial class Registro : ContentPage
{
    private const decimal COSTO_TOTAL = 300m;
    private const decimal PORCENTAJE_INICIAL = 0.15m;
    private const decimal PORCENTAJE_INTERES = 0.05m;

    public string Usuario { get; set; }

    public Registro()
    {
        InitializeComponent();
    }

    public Registro(string username)
    {
        InitializeComponent();
        welcomeLabel.Text = $"Bienvenido, {username}!";
    }

    private void btnCalcularPago_Clicked(object sender, EventArgs e)
    {
        // Calcular el monto inicial
        decimal montoInicial = COSTO_TOTAL * PORCENTAJE_INICIAL;
        entryMontoInicial.Text = montoInicial.ToString("F2");

        // Calcular el saldo restante
        decimal saldoRestante = COSTO_TOTAL - montoInicial;

        // Dividir en 3 cuotas
        decimal cuotaBase = saldoRestante / 3;

        // Interés por cuota (5% del costo total)
        decimal interesPorCuota = COSTO_TOTAL * PORCENTAJE_INTERES;

        // Cuota final con interés
        decimal cuotaMensual = cuotaBase + interesPorCuota;

        entryCuotaMensual.Text = cuotaMensual.ToString("F2");
    }

    private async void btnverResumen_Clicked(object sender, EventArgs e)
    {
        // Validar campos requeridos
        if (string.IsNullOrWhiteSpace(nombreEntry.Text) ||
            string.IsNullOrWhiteSpace(apellidoEntry.Text) ||
            pickerVA.SelectedItem == null ||
            pickerCiudad.SelectedItem == null ||
            string.IsNullOrWhiteSpace(entryMontoInicial.Text) ||
            string.IsNullOrWhiteSpace(entryCuotaMensual.Text))
        {
            await DisplayAlert("Error", "Por favor complete todos los campos antes de continuar.", "OK");
            return;
        }

        string nombre = nombreEntry.Text;
        string apellido = apellidoEntry.Text;
        string voltaje = pickerVA.SelectedItem.ToString();
        string ciudad = pickerCiudad.SelectedItem.ToString();
        DateTime fecha = datePickerFecha.Date;
        decimal cuotaMensual = decimal.Parse(entryCuotaMensual.Text);

        await Navigation.PushAsync(new Resumen(nombre, apellido, voltaje, ciudad, fecha, cuotaMensual));
    }
}
