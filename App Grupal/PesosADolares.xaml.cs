namespace App_Grupal;

///<Summary>
///<Createddate> 2023/07/09 </Createddate>
///<company> INDEL </company>
///<lastmodificationdate> 2023/07/09 </lastmodificationdate>
///<lastmodificationdescription>
/// Se realizo el diseño y se configuró el código cs de la app y se agregó la imagen en el diseño
///</lastmodificationdescription>
///<lastmodifierautor> Carlos Mito </lastmodifierautor>
///</Summary>

public partial class PesosADolares : ContentPage
{
	public PesosADolares()
	{
		InitializeComponent();
	}

    private void ButtonClicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Pesos.Text))
        {
            double pesosmexicanos, dolares;
            string conversion;
            pesosmexicanos = Convert.ToDouble(Pesos.Text);
            dolares = pesosmexicanos / 17;
            conversion = dolares.ToString("0.00");
            Dolares.Text = Convert.ToString(conversion);
        }
        else
        {
            DisplayAlert("Error", "Introduce los datos solicitados", "Ok");
            Dolares.Text = "";
        }
    }
}