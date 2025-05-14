using System.Text.Json;

namespace Astronomy.Pages;



[QueryProperty(nameof(AstroJson), "astroJson")]
public partial class AstronomicalBodyPage : ContentPage
{

    public AstronomicalBodyPage()
    {
        InitializeComponent();
    }

    private string _astroJson;
    private AstronomicalBody astronomicalBody;
    public string AstroJson
    {
        get => _astroJson;
        set
        {
            _astroJson = value;
            astronomicalBody = JsonSerializer.Deserialize<AstronomicalBody>(Uri.UnescapeDataString(_astroJson));

        }
    }

 

    protected override void OnAppearing()
    {
        base.OnAppearing();



        Title = astronomicalBody.Name;

        lblIcon.Text = astronomicalBody.EmojiIcon;
        lblName.Text = astronomicalBody.Name;
        lblMass.Text = astronomicalBody.Mass;
        lblCircumference.Text = astronomicalBody.Circumference;
        lblAge.Text = astronomicalBody.Age;

    }

}