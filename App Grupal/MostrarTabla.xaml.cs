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

public partial class MostrarTabla : ContentPage
{
    private TablasDeMultiplicar tabla;

    public MostrarTabla(TablasDeMultiplicar tabla, double numerodado, double numero1, double numero2, double numero3, double numero4, double numero5, double numero6, double numero7, double numero8, double numero9, double numero10)
    {
        InitializeComponent();
        this.tabla = tabla;
        Número1.Text = Convert.ToString(numerodado + " X 1 = " + numero1);
        Número2.Text = Convert.ToString(numerodado + " X 2 = " + numero2);
        Número3.Text = Convert.ToString(numerodado + " X 3 = " + numero3);
        Número4.Text = Convert.ToString(numerodado + " X 4 = " + numero4);
        Número5.Text = Convert.ToString(numerodado + " X 5 = " + numero5);
        Número6.Text = Convert.ToString(numerodado + " X 6 = " + numero6);
        Número7.Text = Convert.ToString(numerodado + " X 7 = " + numero7);
        Número8.Text = Convert.ToString(numerodado + " X 8 = " + numero8);
        Número9.Text = Convert.ToString(numerodado + " X 9 = " + numero9);
        Número10.Text = Convert.ToString(numerodado + " X 10 = " + numero10);
    }

    private void ButtonVolverClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
        tabla.BorrarNúmero();
    }
}