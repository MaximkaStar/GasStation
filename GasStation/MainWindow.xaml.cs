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

namespace GasStation
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double sum = 0;
        private List<Items> items;

        public MainWindow()
        {
            InitializeComponent();
            items = new List<Items>();

            Random random = new Random();
            int nameFuel = 92;

            for (int i = 0; i < 5; i++)
            {
                Items item = new Items();
                item.Type = TypePeace.Fuel;
                item.Price = random.Next(150, 300);
                item.Name = nameFuel.ToString();
                items.Add(item);
                nameFuel += 5;
            }
            Items Humburger = new Items();
            Humburger.Type = TypePeace.Food;
            Humburger.Name = "Humburger";
            Humburger.Price = 700;
            items.Add(Humburger);

            Items Choco = new Items();
            Choco.Type = TypePeace.Food;
            Choco.Name = "Chocolate";
            Choco.Price = 250;
            items.Add(Choco);

            Items Tarhun = new Items();
            Tarhun.Type = TypePeace.Food;
            Tarhun.Name = "Tarhun";
            Tarhun.Price = 300;
            items.Add(Tarhun);

            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Type == TypePeace.Fuel)
                {
                    FuelBox.Items.Add(items[i].Name);
                }

                else
                {
                    FoodBox.Items.Add(items[i].Name);
                }
            }


        }

        private void orderButtonClick(object sender, RoutedEventArgs e)
        {
            int AmmoutItemFuel;
            int AmmoutItemFood;

            if (int.TryParse(AmmoutFood.Text, out AmmoutItemFood) && int.TryParse(AmmoutLiter.Text, out AmmoutItemFuel) && FoodBox.SelectedItem != null && FuelBox.SelectedItem != null)
            {

                for (int i = 0; i < items.Count; i++)
                {
                    if (FoodBox.SelectedItem == items[i].Name)
                    {
                        sum += items[i].Price * AmmoutItemFood;
                    }
                    else if (FuelBox.SelectedItem == items[i].Name)
                    {
                        sum += items[i].Price * AmmoutItemFuel;
                    }
                }

                MessageBox.Show(string.Format("The total amount of the order - {0} tenge", sum));
                sum = 0;
            }

            else
            {
                MessageBox.Show("You have incorrectly filled in the order form.");
            }
        }
    }
}
