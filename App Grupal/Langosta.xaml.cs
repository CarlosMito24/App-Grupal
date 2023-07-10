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

public partial class Langosta : ContentPage
{
	public Langosta()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

        if (!string.IsNullOrEmpty(np.Text))
        {
            int tt, p = Convert.ToInt32(np.Text);

            if (p >= 300)
            {
                tt = (p * 75);
            }
            else if (p > 200)
            {
                tt = (p * 85);
            }
            else
            {
                tt = (p * 95);
            }
            la.Text = Convert.ToString("$ " + tt);
        }
        else
        {
            DisplayAlert("Error", "Introduce los datos solicitados", "Ok");
            la.Text = string.Empty;
        }
        
    }
}