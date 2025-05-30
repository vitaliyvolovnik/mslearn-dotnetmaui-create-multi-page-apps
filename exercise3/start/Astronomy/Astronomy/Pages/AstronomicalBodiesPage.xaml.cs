using System.Text.Json;

namespace Astronomy.Pages;

public partial class AstronomicalBodiesPage : ContentPage
{

    AstronomicalBody body = new AstronomicalBody
    {
        Name = "Moon",
        Mass = "7.342*10^22 kg",
        Circumference = "10,921 km",
        Age = "4.53 billion years",
        EmojiIcon = "🌕",
    };

    public AstronomicalBodiesPage()
	{
		InitializeComponent();

        var json = Uri.EscapeDataString(JsonSerializer.Serialize(body));


        btnComet.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails?astroName=comet");
        btnEarth.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails?name=earth123&mass=5.972e24&diameter=12742&astroName=earth");
        btnMoon.Clicked += async (s, e) => await Shell.Current.GoToAsync($"astronomicalbodydetails?astroJson={json}");
        btnSun.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails?astroName=sun");
    }
}