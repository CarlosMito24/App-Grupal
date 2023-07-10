namespace App_Grupal;

///<Summary>
///<Createddate> 2023/07/10 </Createddate>
///<company> INDEL </company>
///<lastmodificationdate> 2023/07/10 </lastmodificationdate>
///<lastmodificationdescription>
/// Se realizo el diseño y se configuró el código cs de la app y se agregó la imagen en el diseño
///</lastmodificationdescription>
///<lastmodifierautor> Fernando Claros </lastmodifierautor>
///</Summary>

public partial class SueldoSemanal : ContentPage
{
	public SueldoSemanal()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

        if (!string.IsNullOrEmpty(ht.Text) && !string.IsNullOrEmpty(ph.Text))
        {
            string total;
            double ht1 = Convert.ToDouble(ht.Text);
            double ph1 = Convert.ToDouble(ph.Text);
            double p = (ht1 * ph1);
            total = p.ToString("0.00");

            la.Text = Convert.ToString("$ " + total);
        }
        else
        {
            DisplayAlert("Error", "Introduce los datos solicitados", "Ok");
            la.Text = string.Empty;
        }
       
    }
}