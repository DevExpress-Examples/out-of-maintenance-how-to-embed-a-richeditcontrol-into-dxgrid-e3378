using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Xml.Serialization;
using System.Reflection;

namespace DXSample {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            grid.ItemsSource = CarsData.ItemsSource;
        }
    }

    [XmlRoot("NewDataSet")]
    public class CarsData : List<Cars> {
        public static IList<Cars> ItemsSource {
            get {

                XmlSerializer s = new XmlSerializer(typeof(CarsData));
                return (List<Cars>)s.Deserialize(Assembly.GetExecutingAssembly().GetManifestResourceStream("DXSample.Cars2.xml"));
            }
        }
    }

    public class Cars {
        public int ID { get; set; }
        public string Trademark { get; set; }
        public string Model { get; set; }
        public int HP { get; set; }
        public double Liter { get; set; }
        public int Cyl { get; set; }
        public int TransmissSpeedCount { get; set; }
        public string TransmissAutomatic { get; set; }
        public int MPG_City { get; set; }
        public int MPG_Highway { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Hyperlink { get; set; }
        public byte[] Picture { get; set; }
        public decimal Price { get; set; }
        public string RtfContent { get; set; }
    }
}
