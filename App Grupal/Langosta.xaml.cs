namespace App_Grupal;

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

        }
        
    }
}