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

namespace TestSize
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SizeChanged += (s, e) =>
            {
                Text1.Text = string.Join("\n", new[] {
                    "Window content size:",
                    $"{Grid1.ActualWidth:0.###} x {Grid1.ActualHeight:0.###}",
                    "logical pixels",
                });
            };

            Loaded += (o, e) =>
            {
                var source = PresentationSource.FromVisual(this);
                var t = source.CompositionTarget.TransformToDevice;
                Text2.Text = $"System scale:\n{t.M11:0.###} x {t.M22:0.###}";
            };
        }
    };
}
