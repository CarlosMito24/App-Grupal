namespace App_Grupal;

///<Summary>
///<Createddate> 2023/07/09 </Createddate>
///<company> INDEL </company>
///<lastmodificationdate> 2023/07/09 </lastmodificationdate>
///<lastmodificationdescription>
/// Se realizo el dise�o y se configur� el c�digo cs de la app
///</lastmodificationdescription>
///<lastmodifierautor> Carlos Mito </lastmodifierautor>
///</Summary>

public partial class MostrarTabla : ContentPage
{
    private TablasDeMultiplicar tabla;

    public MostrarTabla(TablasDeMultiplicar tabla, double numerodado, double numero1, double numero2, double numero3, double numero4, double numero5, double numero6, double numero7, double numero8, double numero9, double numero10)
    {
        InitializeComponent();
        this.tabla = tabla;
        N�mero1.Text = Convert.ToString(numerodado + " X 1 = " + numero1);
        N�mero2.Text = Convert.ToString(numerodado + " X 2 = " + numero2);
        N�mero3.Text = Convert.ToString(numerodado + " X 3 = " + numero3);
        N�mero4.Text = Convert.ToString(numerodado + " X 4 = " + numero4);
        N�mero5.Text = Convert.ToString(numerodado + " X 5 = " + numero5);
        N�mero6.Text = Convert.ToString(numerodado + " X 6 = " + numero6);
        N�mero7.Text = Convert.ToString(numerodado + " X 7 = " + numero7);
        N�mero8.Text = Convert.ToString(numerodado + " X 8 = " + numero8);
        N�mero9.Text = Convert.ToString(numerodado + " X 9 = " + numero9);
        N�mero10.Text = Convert.ToString(numerodado + " X 10 = " + numero10);
    }

    private void ButtonVolverClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
        tabla.BorrarN�mero();
    }
}