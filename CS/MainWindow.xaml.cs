using System.Windows;
using DevExpress.Xpf.Gantt;

namespace DXGridSample {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
        private void RequestTimescaleRulers(object sender, RequestTimescaleRulersEventArgs e) {
            e.TimescaleRulers.Clear();
            e.TimescaleRulers.Add(new TimescaleRuler(TimescaleUnit.Month, formatProvider: new CustomFormatProvider(ganttView.Zoom)));
        }
    }
}