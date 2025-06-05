using System.Net.Http;
using System.Net.Http.Json;

namespace EXAMEN2_RobertoManosalvas.Views;

public partial class jokesPage : ContentPage
{
    private readonly HttpClient _httpClient;

    public jokesPage()
    {
        InitializeComponent();
        _httpClient = new HttpClient();
        Chiste();
    }

    private async void OnAnotherJokeButton(object sender, EventArgs e)
    {
        await Chiste();
    }

    private async Task Chiste()
    {
        try
        {
            var joke = await _httpClient.GetFromJsonAsync<Joke>("https://official-joke-api.appspot.com/random_joke");
            if (joke != null)
            {
                SetupLabel.Text = joke.Setup;
                PunchlineLabel.Text = joke.Punchline;
            }
        }
        catch (Exception ex)
        {
            SetupLabel.Text = "Error al cargar el chiste.";
            PunchlineLabel.Text = ex.Message;
        }
    }

    public class Joke
    {
        public string Type { get; set; }
        public string Setup { get; set; }
        public string Punchline { get; set; }
    }
}
