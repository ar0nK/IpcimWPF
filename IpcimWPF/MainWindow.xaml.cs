using System.IO;
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
        private TextBox domainInput;
        private TextBox ipInput;

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
            var sorok = File.ReadAllLines("csudh.txt").Skip(1);
            foreach (var s in sorok)
            {
                string[] darabok = s.Split(';');
                string domainNev = darabok[0];
                string ipCim = darabok[1];
                ips.Add(new Ip(domainNev, ipCim));
            }
            dataGrid.ItemsSource = ips;
        }

        private void Bevitel(object sender, RoutedEventArgs e)
        {
            if(ips==null || ips.Count==0)
            {
                MessageBox.Show("Hiba az adatok betöltésekor!");
            }
            else
            {
                ips.Add(new Ip(domainInput.Text, ipInput.Text));
                dataGrid.ItemsSource = ips;
                dataGrid.Items.Refresh();
            }
        }

        private void Mentes(object sender, RoutedEventArgs e)
        {
            string menteni = "";
            foreach (var h in ips)
            {
                menteni += h.DomainName + ";" + h.IpAddress + "\n";
            }
            File.WriteAllText("csudh.txt", menteni);

        }
    }
}