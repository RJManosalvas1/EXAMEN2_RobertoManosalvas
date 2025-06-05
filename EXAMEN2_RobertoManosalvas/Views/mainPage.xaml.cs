namespace EXAMEN2_RobertoManosalvas.Views;

public partial class mainPage : ContentPage
{
    public mainPage()
    {
        InitializeComponent();
    }


    private async void aboutPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new aboutPage());
    }

    private async void jokesPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new jokesPage());
    }
}