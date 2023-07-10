namespace App_Grupal;

///<Summary>
///<Createddate>10/7/2023</createddate>
///<company>INDEL</company>
///<lastmodificationdate>10/7/2023</lastmodificationdate>
///<lastmodificationdescription>
/// SE realizo el diseño de la app, y se configuró el archivo C#
///</lastmodificationdescription>
///<lastmodifierautor> Maycol Barrera </lastmodifierautor>
///</Summary>

public partial class CuentaRegresiva : ContentPage
{
	public CuentaRegresiva()
	{
		InitializeComponent();
	}

    private void ButtonClicked(object sender, EventArgs e)
    {
        Numeros.Text = "10 - 9 - 8 - 7 - 6 - 5 - 4 - 3 - 2 - 1";
        Numeros.IsVisible = true;
    }
}