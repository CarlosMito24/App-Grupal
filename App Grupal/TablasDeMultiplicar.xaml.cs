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

public partial class TablasDeMultiplicar : ContentPage
{
	public TablasDeMultiplicar()
	{
		InitializeComponent();
	}

    private void ButtonClicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Número.Text))
        {
            double numerodado;
            double numero1;
            double numero2;
            double numero3;
            double numero4;
            double numero5;
            double numero6;
            double numero7;
            double numero8;
            double numero9;
            double numero10;
            numerodado = Convert.ToDouble(Número.Text);
            numero1 = numerodado * 1;
            numero2 = numerodado * 2;
            numero3 = numerodado * 3;
            numero4 = numerodado * 4;
            numero5 = numerodado * 5;
            numero6 = numerodado * 6;
            numero7 = numerodado * 7;
            numero8 = numerodado * 8;
            numero9 = numerodado * 9;
            numero10 = numerodado * 10;
            Navigation.PushAsync(new MostrarTabla(this, numerodado, numero1, numero2, numero3, numero4, numero5, numero6, numero7, numero8, numero9, numero10));
        }
        else
        {
            DisplayAlert("Error", "Introduce los datos solicitados", "Ok");
            Número.Text = "";
        }
    }

    public void BorrarNúmero()
    {
        Número.Text = string.Empty;
    }
}