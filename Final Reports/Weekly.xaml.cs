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
using System.Data;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace Final_Reports
{
    /// <summary>
    /// Interaction logic for Weekly.xaml
    /// </summary>
    public partial class Weekly : Window
    {
        public Weekly()
        {
            InitializeComponent();
        }

        private void CrystalReportsViewer_Loaded(object sender, RoutedEventArgs e)
        {

         //   SqlConnection sqlcon = new SqlConnection(@"Data Source =.; Initial Catalog = NewCRMdb; Integrated Security = True");
         //   sqlcon.Open();
          

            Weekly_Report obj = new Weekly_Report();
            obj.Load("@Weekly_Report.rep");
            viewer1.ViewerCore.ReportSource = obj;
           
        }

    }
}
