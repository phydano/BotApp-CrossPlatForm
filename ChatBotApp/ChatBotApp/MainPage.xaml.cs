using System;
using Xamarin.Forms;

namespace ChatBotApp
{
    public partial class MainPage : ContentPage
    {
        // A really simple app that embedded the bot webchat in. 
        public MainPage()
        {
            InitializeComponent();
        }

        // Generate a new web view when the user click on starting the chat 
        public async void ButtonIsClicked(object sender, EventArgs e)
        {
            var browser = new WebView();
            browser.Source = "https://webchat.botframework.com/embed/Contoso_SupportBot?s=byiqpxSrboM.cwA.MR0.FQ-fQiM-AxaEp5zWRtNWNKiuZAgn08aKNssVXDtbWoc";
            this.Content = browser;
        }
    }
}
