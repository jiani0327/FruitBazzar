using FruitBazzar.ViewModel;

namespace FruitBazzar
{

    public partial class login : ContentPage
    {
        //public login()
        //{
        //	InitializeComponent();

        //       var passwordEntry = new Entry
        //       {
        //           Placeholder = "Password",
        //           IsPassword = true
        //       };

        //       var signUpLabel = new Label
        //       {
        //           Text = "Sign Up Here",
        //           TextColor = Colors.White,
        //           FontAttributes = FontAttributes.Bold,
        //           Margin = new Thickness(0, 10, 0, 0)
        //       };

        //       var signUpTapGestureRecognizer = new TapGestureRecognizer();
        //       signUpTapGestureRecognizer.Tapped += async (s, e) =>
        //       {
        //           // 处理 "Sign Up Here" 文本被点击时的导航逻辑
        //           await Navigation.PushAsync(new SignUpPage());
        //       };

        //       signUpLabel.GestureRecognizers.Add(signUpTapGestureRecognizer);

        //       // 将所有控件添加到 StackLayout 中
        //       var stackLayout = new StackLayout
        //       {
        //           Children = { passwordEntry, signUpLabel },
        //           Margin = new Thickness(20)
        //       };

        //       Content = stackLayout;
        //   }

        //       private void BtnLogin_Clicked(object sender, EventArgs e)
        //       {
        //           Navigation.PushAsync(new Home());
        //       }
        //   }
        public login()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();


        }


        private async void SignUpLabel_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }

        private void BtnLogin_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Home());
        }


    }
}