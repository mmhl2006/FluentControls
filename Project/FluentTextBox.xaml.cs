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
    /// Interaction logic for FluentTextBox.xaml
    /// </summary>
    public partial class FluentTextBox : UserControl
    {
        public FluentTextBox()
        {
            InitializeComponent();
        }

        public string Text
        {
            get { return txtmain.Text; }
            set
            {
                
                txtmain.Text = value;
            }
        }

        private FontFamily fontname;

        public FontFamily fontFamily
        {
            //by mmhl
            get
            {
                return fontname;
            }
            set
            {
                fontname = value;
                txtmain.FontFamily = fontname;
            }
        }

        private double fontsSize;

        public double fontSize
        {
            //by mmhl
            get
            {
                return fontsSize;
            }
            set
            {
                fontsSize = value;
                txtmain.FontSize = fontsSize;
            }
        }

        private bool isenabled;

        public bool isEnabled
        {
            //by mmhl
            get
            {
                return isenabled;
            }
            set
            {
                isenabled = value;
                txtmain.IsEnabled = isenabled;
            }
        }

        private bool spellcheck;

        public bool IsEnabledSpellCheck
        {
            //by mmhl
            get
            {
                return spellcheck;
            }
            set
            {
                spellcheck = value;
                txtmain.SpellCheck.IsEnabled = spellcheck;
            }
        }

   

        private void Rectangle1_MouseEnter(object sender, MouseEventArgs e)
        {
            Point pt = e.GetPosition(txtmain);
            //double x = (pt.X /rectangle1.Width);
            //double y = (pt.Y/rectangle1.Height);
            RadialGradientBrush gradientBrush = new RadialGradientBrush
            {
                MappingMode = BrushMappingMode.Absolute,
                Center = new Point(pt.X, pt.Y)
            };
            GradientStop stop = new GradientStop(Color.FromRgb(218, 218, 218), 0);
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

            txtmain.Background = gradientBrush;
        }
        private void Rectangle1_MouseMove(object sender, MouseEventArgs e)
        {
            Point pt = e.GetPosition(txtmain);
            //double x = (pt.X /rectangle1.Width);
            //double y = (pt.Y/rectangle1.Height);
            RadialGradientBrush gradientBrush = new RadialGradientBrush
            {
                MappingMode = BrushMappingMode.Absolute,
                Center = new Point(pt.X, pt.Y)
            };
            GradientStop stop = new GradientStop(Color.FromRgb(218, 218, 218), 0);
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

            txtmain.Background = gradientBrush;
        }

        private void Rectangle1_MouseLeave(object sender, MouseEventArgs e)
        {
            txtmain.Background = new SolidColorBrush(Colors.Transparent);
        }
    }
}
