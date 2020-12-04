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

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        
        public List<string> testOrder;

        

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
            catalogueViewer.ItemsSource = testCatalogue;

            testOrder = new List<string>();

            orderViewer.ItemsSource = testOrder;

            //oswald
            List<OrderItem> thisCatalogue = new List<OrderItem>();
            OrderItem a = new OrderItem("pen", "blue", 9.00, 0);
            OrderItem b = new OrderItem("pen", "red", 20.00, 0);
            thisCatalogue.Add(a);
            thisCatalogue.Add(b);
            catalogueViewer.ItemsSource = thisCatalogue;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
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
