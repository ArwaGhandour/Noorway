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

namespace datagrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public IEnumerable<string> myitems{get;set;}
        public MainWindow()
        {
            InitializeComponent();
            MCdatagrid.ItemsSource = LoadCollectionData();
           
        }
        private List<author> LoadCollectionData()
        {
            List<author> aut = new List<author>();
            aut.Add(new author()
            {
                id=001,
                name="arwa",
                DOB=new DateTime(2000,11,6),
                booktitle= "cenderila",
                ismvp =false,

            });

            aut.Add(new author()
            {
                id = 002,
                name = "SAFIA",
                DOB = new DateTime(2008, 9, 23),
                booktitle = "Beautiful and the monster",
                ismvp = true,

            });
            aut.Add(new author()
            {
                id = 003,
                name = "Eman",
                DOB = new DateTime(1985, 5, 13),
                booktitle = "home sweet home",
                ismvp = true,

            });
            return aut;
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    myitems = new List<string> { "arwa", "safia", "nada" };
        //    DataContext = this;
        //}
    }
    public class author
    {
        public  int id { get; set; }
        public string name { get; set; }
        public DateTime DOB { get; set; }
        public string booktitle { get; set; }
        public bool ismvp { get; set; }
    }
}
