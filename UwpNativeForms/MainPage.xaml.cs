using Xamarin.Forms.Platform.UWP;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UwpNativeForms
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            var formsPage = new FormsBugProject.FormsMainPage();
            var nativeFormsPage = formsPage.CreateFrameworkElement();
            Content = nativeFormsPage;
        }
    }
}
