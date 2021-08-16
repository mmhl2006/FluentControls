using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MMHLco.FluentControls
{
    /// <summary>
    /// Interaction logic for FluentRetangle.xaml
    /// </summary>
    public partial class FluentRetangle : UserControl
    {
        public FluentRetangle()
        {
            InitializeComponent();
        }

        private Color HoverColorr = Color.FromRgb(192,192,192);

        public Color HoverColor
        {
            //by mmhl/
            get
            {
                return HoverColorr;
            }
            set
            {
                HoverColorr = value;

            }
        }

        private Color BackColorr = Colors.Transparent;

        public Color BackColor
        {
            //by mmhl
            get
            {
                return BackColorr;
            }
            set
            {
                BackColorr = value;

            }
        }

        private Brush fill = GetBrush(new Point(1,1));

        public Brush Fill
        {
            //by mmhl
            get
            {
                return fill;
            }
            set
            {
                fill = value;
                rectangle1.Fill = fill;
            }
        }

        private static Brush GetBrush(Point pt)
        {
            
            //double x = (pt.X /rectangle1.Width);
            //double y = (pt.Y/rectangle1.Height);
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

            return gradientBrush;
        }
        private void Rectangle1_MouseEnter(object sender, MouseEventArgs e)
        {
            Point pt = e.GetPosition(rectangle1);
            //double x = (pt.X /rectangle1.Width);
            //double y = (pt.Y/rectangle1.Height);
            RadialGradientBrush gradientBrush = new RadialGradientBrush
            {
                MappingMode = BrushMappingMode.Absolute,
                Center = new Point(pt.X, pt.Y)
            };
            GradientStop stop = new GradientStop(HoverColorr, 0);
            GradientStop stop2 = new GradientStop(BackColorr, 1.2);
            GradientStopCollection gradients = new GradientStopCollection
            {
                stop,
                stop2
            };
            gradientBrush.GradientStops = gradients;
            gradientBrush.RadiusX = 200;
            gradientBrush.RadiusY = 200;
            gradientBrush.GradientOrigin = new Point(pt.X, pt.Y);

            rectangle1.Fill = gradientBrush;
        }
        private void Rectangle1_MouseMove(object sender, MouseEventArgs e)
        {
            Point pt = e.GetPosition(rectangle1);
            //double x = (pt.X /rectangle1.Width);
            //double y = (pt.Y/rectangle1.Height);
            RadialGradientBrush gradientBrush = new RadialGradientBrush
            {
                MappingMode = BrushMappingMode.Absolute,
                Center = new Point(pt.X, pt.Y)
            };
            GradientStop stop = new GradientStop(HoverColorr, 0);
            GradientStop stop2 = new GradientStop(BackColorr, 1.2);
            GradientStopCollection gradients = new GradientStopCollection
            {
                stop,
                stop2
            };
            gradientBrush.GradientStops = gradients;
            gradientBrush.RadiusX = 200;
            gradientBrush.RadiusY = 200;
            gradientBrush.GradientOrigin = new Point(pt.X, pt.Y);

            rectangle1.Fill = gradientBrush;
        }

        private void Rectangle1_MouseLeave(object sender, MouseEventArgs e)
        {
            rectangle1.Fill = new SolidColorBrush(BackColorr);
        }

    }
}
