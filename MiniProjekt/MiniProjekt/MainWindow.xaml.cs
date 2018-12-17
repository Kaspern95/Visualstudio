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

namespace MiniProjekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            User bruger = new User();
            Product product = new Product(1,"Harry Potter - 2",true);
            bruger.Lend(7, product);
            //DAL.CreateProduct("Harry potter 25",1);
            //DAL.GetAllBookings();
            //DAL.CheckProduct();
            //DAL.Login("Klaus@admin.tv");
            //DAL.DeleteProduct(1);
            //DAL.EditProduct("Harry Potter 15", 0, 2);
        }
    }
}
