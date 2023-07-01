namespace _15_E4;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

		double Ga = Convert.ToDouble(G.Text);
        double Pr = Convert.ToDouble(P.Text);

        double Li = Ga * 3.78541;
		double To = Li * Pr;

		la.Text = "Total a pagar : $" + To;

    }
}

