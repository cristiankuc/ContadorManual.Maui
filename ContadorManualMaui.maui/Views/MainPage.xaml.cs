using ContadorManualMaui.maui.Models;

namespace ContadorManualMaui.maui.Views;

public partial class MainPage : ContentPage
{

    private Contador _contador;
	public MainPage()
	{
		InitializeComponent();
        _contador = new Contador();
        LabelConteo.Text = _contador.Conteo.ToString();
	}

    private void OnContarButtonClicked(object sender, EventArgs e)
    {
        _contador.Contar();
        LabelConteo.Text = _contador.Conteo.ToString();
    }

    private void OnReinicarButtonClicked1(object sender, EventArgs e)
    {
        _contador.Reiniciar();
        LabelConteo.Text = _contador.Conteo.ToString();
    }
}