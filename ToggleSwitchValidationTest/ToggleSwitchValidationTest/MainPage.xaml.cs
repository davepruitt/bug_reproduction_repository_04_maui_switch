namespace ToggleSwitchValidationTest;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		this.BindingContext = new MainPageViewModel();
	}

    private async void MySwitch_Toggled(object sender, ToggledEventArgs e)
    {
		var result = await DisplayAlert("Are you sure?", string.Empty, "Yes", "No");
		var vm = this.BindingContext as MainPageViewModel;
		if (vm != null)
		{
			if (result)
			{
				vm.IsMySwitchToggled = e.Value;
			}
			else
			{
				vm.NotifyPropertyChanged("IsMySwitchToggled");
			}
		}
    }
}

