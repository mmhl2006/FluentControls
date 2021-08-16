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
    /// Interaction logic for FluentFrontLabel.xaml
    /// </summary>
    public partial class FluentFrontLabel : UserControl
    {/// <summary>
    /// only a front label for other controls like FluentRectangle
    /// </summary>
        public FluentFrontLabel()
        {
            InitializeComponent();
        }

        public void ApplyEffectTo(FluentRetangle retangle)
        {
            Point pt = Mouse.GetPosition(this);
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

            retangle.Fill = gradientBrush;
        }

        private Brush myVar;

        public Brush BackgroundFill
        {
            //by mmhl
            get => myVar;
            set
            {
                myVar = value;
                label1.Background = myVar;
            }
        }
        private Brush myyVar;

        public Brush ForegroundFill
        {
            //by mmhl
            get => myyVar;
            set
            {
                myyVar = value;
                label1.Foreground = myyVar;
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

    }
}
