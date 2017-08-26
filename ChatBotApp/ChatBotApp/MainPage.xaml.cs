using Xamarin.Forms;

namespace ChatBotApp
{
    public partial class MainPage : ContentPage
    {
        // A really simple app that embedded the bot webchat in. 
        public MainPage()
        {
            var browser = new WebView();
            browser.Source = "https://webchat.botframework.com/embed/Contoso_SupportBot?s=byiqpxSrboM.cwA.MR0.FQ-fQiM-AxaEp5zWRtNWNKiuZAgn08aKNssVXDtbWoc";
            this.Content = browser;
        }
    }
}
