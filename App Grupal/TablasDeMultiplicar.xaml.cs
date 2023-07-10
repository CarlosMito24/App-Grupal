namespace App_Grupal;

///<Summary>
///<Createddate> 2023/07/09 </Createddate>
///<company> INDEL </company>
///<lastmodificationdate> 2023/07/09 </lastmodificationdate>
///<lastmodificationdescription>
/// Se realizo el dise�o y se configur� el c�digo cs de la app y se agreg� la imagen en el dise�o
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
        if (!string.IsNullOrEmpty(N�mero.Text))
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
            numerodado = Convert.ToDouble(N�mero.Text);
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
            N�mero.Text = "";
        }
    }

    public void BorrarN�mero()
    {
        N�mero.Text = string.Empty;
    }
}