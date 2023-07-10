﻿namespace App_Grupal;

///<Summary>
///<Createddate> 2023/07/09 </Createddate>
///<company> INDEL </company>
///<lastmodificationdate> 2023/07/09 </lastmodificationdate>
///<lastmodificationdescription>
/// Se realizo el diseño y se configuró el código cs de la app y se agregó la imagen en el diseño
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
}