namespace mobilka;

public partial class MainPage : ContentPage
{
    private readonly string[] tekstyCytatow = { "Dzień dobry", "Good morning", "Buenos dias" };
    private int indeksAktualnegoTekstu = 0;

    public MainPage()
    {
        InitializeComponent();

        lblRozmiarOpis.Text = "Rozmiar: " + (int)sliderRozmiar.Value;
        lblCytat.FontSize = sliderRozmiar.Value;
    }
    private void SliderRozmiar_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        int nowaWartosc = (int)e.NewValue;

        lblRozmiarOpis.Text = "Rozmiar: " + nowaWartosc;
        lblCytat.FontSize = nowaWartosc;
    }

    private void ButtonZmienTekst_Clicked(object sender, EventArgs e)
    {
        indeksAktualnegoTekstu = (indeksAktualnegoTekstu + 1) % tekstyCytatow.Length;
        lblCytat.Text = tekstyCytatow[indeksAktualnegoTekstu];
    }
}