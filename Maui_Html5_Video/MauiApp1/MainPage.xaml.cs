namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

		var htmlSource = new HtmlWebViewSource();
		htmlSource.Html = @"<html><body><video autoplay muted loop playsinline class='slideContent' style='width:100%'><source src='https://dev1.kompas-xnet.si/TRIMOTERM.mp4' type='video/mp4'></video></body></html>";
		webView.Source = htmlSource;
	}
}

