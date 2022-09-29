namespace MauiTest;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
        //get screen size
        var width = DeviceDisplay.MainDisplayInfo.Width;
        var height = DeviceDisplay.MainDisplayInfo.Height;

        WebView1.WidthRequest = width-10;
        WebView1.HeightRequest = height-10;
    }
}