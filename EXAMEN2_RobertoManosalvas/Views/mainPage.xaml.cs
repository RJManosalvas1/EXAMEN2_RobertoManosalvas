namespace EXAMEN2_RobertoManosalvas.Views;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
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