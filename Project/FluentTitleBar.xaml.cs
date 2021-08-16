using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MMHLco.FluentControls
{
    /// <summary>
    /// Interaction logic for FluentRadioButton.xaml
    /// </summary>
    public partial class FluentRadioButton : UserControl
    {
        private Window tr;
        public FluentRadioButton(Window targetwindow)
        {
            InitializeComponent();
            tr = targetwindow;
        }

        private void FluentRetangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            FluentEssentials.FluentEssentials.ExitApp(tr);
        }

        private void FluentRetangle_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            FluentEssentials.FluentEssentials.MaximizeApp(tr);
        }

        private void FluentRetangle_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            FluentEssentials.FluentEssentials.MinimizeApp(tr);
            FluentButton button = new FluentButton();
        }
    }
}
