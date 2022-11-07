using System.Text.RegularExpressions;
namespace Disclipper;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		string idval = entry.Text.Split(":")[2].TrimEnd('>');
		string suffix = ".png";
		if (entry.Text.StartsWith("<a")){
			suffix = ".gif";
		}

		output.Text = $"https://cdn.discordapp.com/emojis/{idval}{suffix}";
        await Clipboard.Default.SetTextAsync($"https://cdn.discordapp.com/emojis/{idval}{suffix}");

    }
}

