using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FruitBazzar.ViewModel;



   public class MainViewModel : BindableObject
    {
        private ICommand _navigateCommand;

       public MainViewModel()
        {
            _navigateCommand = new Command(NavigateToNextPage);
        }

       public string WelcomeMessage
       {
            get { return "Welcome to our app!"; }
       }

        public ICommand NavigateCommand
        {
            get { return _navigateCommand; }
        }

        private async void NavigateToNextPage()
        {
            // 在这里执行导航逻辑
            await Application.Current.MainPage.Navigation.PushAsync(new login());
        }
    }
