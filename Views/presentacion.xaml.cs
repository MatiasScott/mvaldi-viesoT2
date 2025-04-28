namespace mvaldiñviesoT2.Views;

public partial class presentacion : ContentPage
{
	public presentacion()
	{
		InitializeComponent();
        btnNotas.Clicked += btnNotas_Clicked;
	}

    private async void btnNotas_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (pkEstudiantes.SelectedIndex == -1)
            {
                await DisplayAlert("Error", "Seleccione un estudiante", "OK");
                return;
            }

            double seg1 = Convert.ToDouble(txtNotaS1.Text);
            double seg2 = Convert.ToDouble(txtNotaS2.Text);
            double exa1 = Convert.ToDouble(txtExamen1.Text);
            double exa2 = Convert.ToDouble(txtExamen2.Text);
            if (seg1 < 0 || seg1 > 10)
            {
                await DisplayAlert("Error", "Ingrese notas válidas entre 0 y 10", "OK");
                return;
            }
            if (seg2 < 0 || seg1 > 10)
            {
                await DisplayAlert("Error", "Ingrese notas válidas entre 0 y 10", "OK");
                return;
            }
            if (exa1 < 0 || seg1 > 10)
            {
                await DisplayAlert("Error", "Ingrese notas válidas entre 0 y 10", "OK");
                return;
            }
            if (exa2 < 0 || seg1 > 10)
            {
                await DisplayAlert("Error", "Ingrese notas válidas entre 0 y 10", "OK");
                return;
            }

            double p1 = (seg1 * 0.3) + (exa1 * 0.2);
            double p2 = (seg2 * 0.3) + (exa2 * 0.2);
            double notaFinal = p1 + p2;

            String estado = "";

            if (notaFinal >= 7) { estado = "APROBADO"; }
            else if (notaFinal >= 5) { estado = "COMPLEMENTARIO"; }
            else { estado = "REPROBADO"; }

                lblNotaParcial1.Text = $"Nota Parcial 1: {p1:F2}";
            lblNotaParcial2.Text = $"Nota Parcial 2: {p2:F2}";

            // Mostrar resultados
            string resultado = $"Nombre: {pkEstudiantes.SelectedItem}\n" +
                               $"Fecha: {pkDate.Date.ToShortDateString()}\n" +
                               $"Nota Parcial 1: {p1:F2}\n" +
                               $"Nota Parcial 2: {p2:F2}\n" +
                               $"Nota Final: {notaFinal:F2}\n" +
                               $"Estado: {estado}";

            await DisplayAlert("Resultados", resultado, "OK");
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", ex.Message, "OK");
        }
    }
}