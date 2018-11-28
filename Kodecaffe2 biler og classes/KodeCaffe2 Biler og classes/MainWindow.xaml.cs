using System.Collections.Generic;
using System.Windows;

namespace KodeCaffe2_Biler_og_classes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CarDealer poul = new CarDealer(new List<Car>()
        {
            new Car("Mazda 210", 5000, 48, 21300),
            new Car("Toyota Jumbo", 12502, 23, 2140),
            new Car("Fiat Hawaii", 4500, 10, 8000)
        }
        );
        public MainWindow()
        {
            InitializeComponent();
            CarListBox.ItemsSource = poul.Cars;
        }

        private void btn_SellCar(object sender, RoutedEventArgs e)
        {
            poul.SellCar((List<Car>)CarListBox.SelectedItem);
            CarListBox.Items.Refresh();
            MyMoney.Content = $"Mine Penge: {poul.Money}";
        }
    }
}
