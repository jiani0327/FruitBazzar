using FruitBazzar.ViewModel;

namespace FruitBazzar;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainViewModel();
    }
}

