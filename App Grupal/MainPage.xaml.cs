namespace App_Grupal;

///<Summary>
///<Createddate> 2023/07/09 </Createddate>
///<company> INDEL </company>
///<lastmodificationdate> 2023/07/10 </lastmodificationdate>
///<lastmodificationdescription>
/// Se realizo el diseño, se configuró el código cs de la app para navegar a las demás apps, se agregó la imagen en el diseño de cada botón y se organizó todo según guía de trabajo
///</lastmodificationdescription>
///<lastmodifierautor> Carlos Mito </lastmodifierautor>
///</Summary>

public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();
	}

    private void ButtonTablasClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new TablasDeMultiplicar());
    }

    private void ButtonPesosADolaresClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PesosADolares());
    }

    private void ButtonSueldoSemanal_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SueldoSemanal());
    }

    private void ButtonLangosta_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Langosta());
    }

    private void Buttonnumerospares_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NumerosPares());
    }

    private void ButtonCuentaRegresiva_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CuentaRegresiva());
    }
}