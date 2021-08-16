using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace MMHLco.FluentControls
{
    /// <summary>
    /// Interaction logic for FluentCheckBox.xaml
    /// </summary>
    public partial class FluentCheckBox : UserControl
    {
        public FluentCheckBox()
        {
            InitializeComponent();
        }

        private bool checke = false;

        public bool Checked
        {
            //by mmhl
            get => checke;
            set
            {
                checke = value;
                if (checke == true)
                {
                    check();
                }
                else
                {
                    _checked.Fill = new SolidColorBrush(Colors.White);
                }
            }
        }

        private void Checked_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Checked == false)
            {
                Checked = true;
            }
            else
            {
                Checked = false;
            }
        }
        private void check()
        {

            RadialGradientBrush gradientBrush = new RadialGradientBrush();
            GradientStop stop = new GradientStop(Color.FromRgb(0, 128, 0), 0.639);
            GradientStop stop2 = new GradientStop(Colors.White, 1);
            GradientStopCollection gradients = new GradientStopCollection
            {
                stop,
                stop2
            };
            gradientBrush.GradientStops = gradients;
            //     gradientBrush.RadiusX = 200;
            //   gradientBrush.RadiusY = 200;
            //gradientBrush.GradientOrigin = new Point(0, 1);
            _checked.Fill = gradientBrush;
        }
        private void Rectangle1_MouseEnter(object sender, MouseEventArgs e)
        {
            Point pt = e.GetPosition(lblcaption);
            RadialGradientBrush gradientBrush = new RadialGradientBrush
            {
                MappingMode = BrushMappingMode.Absolute,
                Center = new Point(pt.X, pt.Y)
            };
            GradientStop stop = new GradientStop(Color.FromRgb(169, 169, 169), 0);
            GradientStop stop2 = new GradientStop(Colors.Transparent, 1.2);
            GradientStopCollection gradients = new GradientStopCollection
            {
                stop,
                stop2
            };
            gradientBrush.GradientStops = gradients;
            gradientBrush.RadiusX = 200;
            gradientBrush.RadiusY = 200;
            gradientBrush.GradientOrigin = new Point(pt.X, pt.Y);
            lblcaption.Background = gradientBrush;
        }
        private void Rectangle1_MouseMove(object sender, MouseEventArgs e)
        {
            Point pt = e.GetPosition(lblcaption);
            RadialGradientBrush gradientBrush = new RadialGradientBrush
            {
                MappingMode = BrushMappingMode.Absolute,
                Center = new Point(pt.X, pt.Y)
            };
            GradientStop stop = new GradientStop(Color.FromRgb(169, 169, 169), 0);
            GradientStop stop2 = new GradientStop(Colors.Transparent, 1.2);
            GradientStopCollection gradients = new GradientStopCollection
            {
                stop,
                stop2
            };
            gradientBrush.GradientStops = gradients;
            gradientBrush.RadiusX = 200;
            gradientBrush.RadiusY = 200;
            gradientBrush.GradientOrigin = new Point(pt.X, pt.Y);

            lblcaption.Background = gradientBrush;
        }

        private void Rectangle1_MouseLeave(object sender, MouseEventArgs e)
        {
            lblcaption.Background = new SolidColorBrush(Colors.Transparent);
        }

        private void Lblcaption_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Checked == false)
            {
                Checked = true;
            }
            else
            {
                Checked = false;
            }
            Point pt = e.GetPosition(lblcaption);
            //double x = (pt.X /rectangle1.Width);
            //double y = (pt.Y/rectangle1.Height);
            RadialGradientBrush gradientBrush = new RadialGradientBrush
            {
                MappingMode = BrushMappingMode.Absolute,
                Center = new Point(pt.X, pt.Y)
            };
            GradientStop stop = new GradientStop(Color.FromRgb(169, 169, 169), 0);
            GradientStop stop2 = new GradientStop(Colors.Transparent, 3);
            GradientStopCollection gradients = new GradientStopCollection
            {
                stop,
                stop2
            };
            gradientBrush.GradientStops = gradients;
            gradientBrush.RadiusX = 200;
            gradientBrush.RadiusY = 200;
            gradientBrush.GradientOrigin = new Point(pt.X, pt.Y);

            lblcaption.Background = gradientBrush;
        }

        private void Lblcaption_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Rectangle1_MouseMove(sender, e);
        }
    }
}
