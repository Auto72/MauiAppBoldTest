namespace MauiAppBoldTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            this.Title = GetLabelText(Label1);
        }

        private void Button2_Clicked(object sender, EventArgs e)
        {
            this.Title = GetLabelText(Label2Span);
        }

        public static string GetLabelText(Label lbl)
        {
            if (lbl.FormattedText != null)
            {
                // La label usa FormattedText (Span)  
                string composedText = string.Concat(lbl.FormattedText.Spans.Select(s => s.Text));
                return composedText;
            }
            else
            {
                // La label usa Text semplice  
                return lbl.Text;
            }
        }
    }
}
