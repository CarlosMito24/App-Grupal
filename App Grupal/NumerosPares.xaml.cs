namespace App_Grupal;

///<Summary>
///<Createddate>10/7/2023</createddate>
///<company>INDEL</company>
///<lastmodificationdate>10/7/2023</lastmodificationdate>
///<lastmodificationdescription>
/// SE realizo el diseño de la app, y se configuró el archivo cs
///</lastmodificationdescription>
///<lastmodifierautor> Maycol Barrera </lastmodifierautor>
///</Summary>

public partial class NumerosPares : ContentPage
{
	public NumerosPares()
	{
		InitializeComponent();
	}

    private void ButtonClicked(object sender, EventArgs e)
    {
        Numeros.Text = "0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48, 50, 52, 54, 56, 58, 60, 62, 64, 66, 68, 70, 72, 74, 76, 78, 80, 82, 84, 86, 88, 90, 92, 94, 96, 98, 100";
        Numeros.IsVisible = true;
    }
}