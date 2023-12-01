using Microsoft.UI.Xaml;

namespace c__Winui3_test
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindowVM VM;

        public MainWindow()
        {
            this.InitializeComponent();
            VM = new();
            InitializeFlyout();
        }

        void InitializeFlyout()
        {
            // when moving these groups around, observe that only the last group set IsChecked for the default dot icon 
            // since they all fall under the same group
            Option7.IsChecked = Option7.Name == "Option8";
            Option8.IsChecked = Option8.Name == "Option8";
            Option9.IsChecked = Option9.Name == "Option8";

            Option1.IsChecked = Option1.Name == "Option1";
            Option2.IsChecked = Option2.Name == "Option1";
            Option3.IsChecked = Option3.Name == "Option1";
            Option4.IsChecked = Option4.Name == "Option1";
            
            Option5.IsChecked = Option5.Name == "Option6";
            Option6.IsChecked = Option6.Name == "Option6";

        }
    }
}
