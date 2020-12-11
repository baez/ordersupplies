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
using Contracts.OrderManagement;
using Interfaces;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        
        public List<string> testOrder;
        public Order cart;
        

        public Window1()
        {
            InitializeComponent();

            this.Width = 1000;
            this.Height = 500;
            this.Title = "Test Order Entry";
            var testCatalogue = new List<string>();
            testCatalogue.Add("Test 1");
            testCatalogue.Add("Test 2");
            testCatalogue.Add("Test 3 - This is much longer item to test side scrolling");
            //catalogueViewer.ItemsSource = testCatalogue;

            testOrder = new List<string>();
            //cart = new Order();

            orderViewer.ItemsSource = testOrder;

            //oswald
            List<OrderItem> thisCatalogue = new List<OrderItem>();
            thisCatalogue.Add(new OrderItem("pen", "blue", 9.00, 0));
            thisCatalogue.Add(new OrderItem("pen", "red", 20.00, 0));
            thisCatalogue.Add(new OrderItem("Chair", "red", 20.00, OrderItemCategory.Furniture));
            thisCatalogue.Add(new OrderItem("Laser Printer", "HP", 200.00, OrderItemCategory.ComputerAccessories));
            thisCatalogue.Add(new OrderItem("Laptop", "red", 20.00, OrderItemCategory.Computer));
            thisCatalogue.Add(new OrderItem("Face Mask", "Blue, 10 pack", 10, OrderItemCategory.PersonalProtectiveEquipment));
            
            catalogueViewer.ItemsSource = thisCatalogue;
            //catalogList.ItemsSource = thisCatalogue;
        }

        //Display current orders into debug console.
        private void BtnSave(object sender, RoutedEventArgs e)
        {
           
            var order = new Order(Convert.ToInt32(OrderNumber.Text), Username.Text);

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            string newItem = catalogueViewer.SelectedItem.ToString();
            //cart.Add((OrderItem)catalogueViewer.SelectedItem);
            testOrder.Add(newItem);
            orderViewer.Items.Refresh();
        }

        private void remButton_Click(object sender, RoutedEventArgs e)
        {
            string remItem = orderViewer.SelectedItem.ToString();
            testOrder.Remove(remItem);
            orderViewer.Items.Refresh();
        }
        
    }
}
