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
    /// Interaction logic for FluentWideButton.xaml
    /// </summary>
    public partial class FluentWideButton : UserControl
    {
        public FluentWideButton()
        {
            InitializeComponent();
        }
        private Brush myVar;

        public Brush Fill
        {
            //by mmhl
            get => myVar;
            set
            {
                myVar = value;
                root.Fill = myVar;
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





        private Color HoverColorr = Color.FromRgb(192, 192, 192);

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

    
        //*/*************************************************************************
        //end of properties
        //*/*************************************************************************
        private void Root_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Point pt = e.GetPosition(root);
            //double x = (pt.X /rectangle1.Width);
            //double y = (pt.Y/rectangle1.Height);

            RadialGradientBrush gradientBrush = new RadialGradientBrush
            {
                MappingMode = BrushMappingMode.Absolute,
                Center = new Point(pt.X, pt.Y),

            };
            GradientStop stop = new GradientStop(Color.FromRgb(180, 180, 180), 0);
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

            root.Fill = gradientBrush;
        }

        private void Root_MouseMove(object sender, MouseEventArgs e)
        {
            Point pt = e.GetPosition(root);
            //double x = (pt.X /rectangle1.Width);
            //double y = (pt.Y/rectangle1.Height);

            RadialGradientBrush gradientBrush = new RadialGradientBrush
            {
                MappingMode = BrushMappingMode.Absolute,
                Center = new Point(pt.X, pt.Y),

            };
            GradientStop stop = new GradientStop(HoverColorr, 0);
            GradientStop stop2 = new GradientStop(BackColorr, 1.2);
            GradientStopCollection gradients = new GradientStopCollection
            {
                stop,
                stop2
            };
            gradientBrush.GradientStops = gradients;
            gradientBrush.RadiusX = 150;
            gradientBrush.RadiusY = 600;
            gradientBrush.GradientOrigin = new Point(pt.X, pt.Y);
            
            root.Fill = gradientBrush;
            //end of fill
            //=====================================================
   

            RadialGradientBrush gradientBrushfill = new RadialGradientBrush
            {
                MappingMode = BrushMappingMode.Absolute,
                Center = new Point(pt.X, pt.Y),

            };
            GradientStop stop1 = new GradientStop(HoverColorr, 0);
            GradientStop stop21 = new GradientStop(BackColorr, 1.2);
            GradientStopCollection gradients1 = new GradientStopCollection
            {
                stop1,
                stop21
            };
            gradientBrushfill.GradientStops = gradients1;
            gradientBrushfill.RadiusX = 500;
            gradientBrushfill.RadiusY = 500;
            gradientBrushfill.GradientOrigin = new Point(pt.X, pt.Y);

            root.StrokeThickness =3;
            root.Stroke = gradientBrushfill;
        }

        private void Root_MouseLeave(object sender, MouseEventArgs e)
        {
            root.Fill =new SolidColorBrush( BackColorr);
            root.Stroke = new SolidColorBrush(Color.FromRgb(250,250,250));
        }

        private void Root_MouseEnter(object sender, MouseEventArgs e)
        {
            Point pt = e.GetPosition(root);
            //double x = (pt.X /rectangle1.Width);
            //double y = (pt.Y/rectangle1.Height);

            RadialGradientBrush gradientBrush = new RadialGradientBrush
            {
                MappingMode = BrushMappingMode.Absolute,
                Center = new Point(pt.X, pt.Y),
                
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

            root.Fill = gradientBrush;
        }

        private void Root_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Point pt = e.GetPosition(root);
            //double x = (pt.X /rectangle1.Width);
            //double y = (pt.Y/rectangle1.Height);

            RadialGradientBrush gradientBrush = new RadialGradientBrush
            {
                MappingMode = BrushMappingMode.Absolute,
                Center = new Point(pt.X, pt.Y),

            };
            GradientStop stop = new GradientStop(HoverColorr, 0);
            GradientStop stop2 = new GradientStop(BackColorr, 1.2);
            GradientStopCollection gradients = new GradientStopCollection
            {
                stop,
                stop2
            };
            gradientBrush.GradientStops = gradients;
            gradientBrush.RadiusX = 150;
            gradientBrush.RadiusY = 600;
            gradientBrush.GradientOrigin = new Point(pt.X, pt.Y);

            root.Fill = gradientBrush;
            //end of fill
            //=====================================================


            RadialGradientBrush gradientBrushfill = new RadialGradientBrush
            {
                MappingMode = BrushMappingMode.Absolute,
                Center = new Point(pt.X, pt.Y),

            };
            GradientStop stop1 = new GradientStop(HoverColorr, 0);
            GradientStop stop21 = new GradientStop(BackColorr, 1.2);
            GradientStopCollection gradients1 = new GradientStopCollection
            {
                stop1,
                stop21
            };
            gradientBrushfill.GradientStops = gradients1;
            gradientBrushfill.RadiusX = 500;
            gradientBrushfill.RadiusY = 500;
            gradientBrushfill.GradientOrigin = new Point(pt.X, pt.Y);

            root.StrokeThickness = 3;
            root.Stroke = gradientBrushfill;
        }
    }
}
