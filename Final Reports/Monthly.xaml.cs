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
using System.Windows.Shapes;

namespace Final_Reports
{
    /// <summary>
    /// Interaction logic for Monthly.xaml
    /// </summary>
    public partial class Monthly : Window
    {
        public Monthly()
        {
            InitializeComponent();
        }

        private void Viwer2_Loaded(object sender, RoutedEventArgs e)
        {
            Monthly_Report obj = new Monthly_Report();
            obj.Load("@Monthly_Report.rep");
          viwer2.ViewerCore.ReportSource = obj;
        }
    }
}
