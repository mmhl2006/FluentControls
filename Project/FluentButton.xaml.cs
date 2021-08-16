using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace MMHLco.FluentControls
{
    /// <summary>
    /// Interaction logic for FluentButton.xaml
    /// </summary>
    public partial class FluentButton : UserControl
    {
        private bool nowork = false;
        public FluentButton()
        {
            InitializeComponent();

            // rectangle1.MouseDown += Rectangle1_MouseDown1;
        }

        private Brush myVar;

        public Brush Fill
        {
            //by mmhl
            get => myVar;
            set
            {
                myVar = value;
                rectangle1.Fill = myVar;
            }
        }

        private HorizontalAlignment Allign;

        public HorizontalAlignment TextHorizontalAlignment
        {
            //by mmhl
            get
            {
                return Allign;
            }
            set
            {
                Allign = value;
                label1.HorizontalAlignment = Allign;
            }
        }

        private VerticalAlignment Alllign;

        public VerticalAlignment TextVerticalAlignment
        {
            //by mmhl
            get
            {
                return Alllign;
            }
            set
            {
                Alllign = value;
                label1.VerticalAlignment = Alllign;
            }
        }

        private string text;

        public string Text
        {
            get => text;
            set
            {
                text = value;
                label1.Content = text;
            }
        }
        /********************************************************************/

        /********************************************************************/
        private void Rectangle1_MouseEnter(object sender, MouseEventArgs e)
        {
            Point pt = e.GetPosition(rectangle1);
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

            rectangle1.Fill = gradientBrush;
        }
        private void Rectangle1_MouseMove(object sender, MouseEventArgs e)
        {
            Point pt = e.GetPosition(rectangle1);
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

            rectangle1.Fill = gradientBrush;
        }

        private void Rectangle1_MouseLeave(object sender, MouseEventArgs e)
        {
            rectangle1.Fill = new SolidColorBrush(Colors.Transparent);
        }

        private void Rectangle1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //     e1 = e;
            Point pt = e.GetPosition(rectangle1);
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

            rectangle1.Fill = gradientBrush;
            nowork = true;
        }
        public void ApplyEffectTo(FluentButton target)
        {
            Point pt = Mouse.GetPosition(target);
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

            target.Fill = gradientBrush;
            nowork = true;
        }
        private void Dealy(int inter)
        {
            Timer timer = new Timer()
            {
                Interval = inter,
                AutoReset = false
            };
            timer.Start();
            timer.Stop();
        }

        private void Rectangle1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (nowork == true)
            {
                Dealy(3000);
            }
            Point pt = e.GetPosition(rectangle1);
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

            rectangle1.Fill = gradientBrush;
        }
    }
}
