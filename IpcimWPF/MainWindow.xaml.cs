using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IpcimWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public class Ip
    {
        public string DomainName {  get; set; }
        public string IpAddress { get; set; }

        public Ip(string domainName, string ipAddress)
        {
            DomainName = domainName;
            IpAddress = ipAddress;
        }
    }
    
    
    public partial class MainWindow : Window
    {
        public List<Ip> ips = new List<Ip>();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Bevitel(object sender, RoutedEventArgs e)
        {

        }

        private void Mentes(object sender, RoutedEventArgs e)
        {

        }
    }
}