namespace App_Grupal;

public partial class SueldoSemanal : ContentPage
{
	public SueldoSemanal()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        string total;
		double ht1 = Convert.ToDouble(ht.Text);
        double ph1 = Convert.ToDouble(ph.Text);
        double p = (ht1 * ph1);
        total = p.ToString("0.00");

        la.Text = Convert.ToString("$ " + total);
    }
}