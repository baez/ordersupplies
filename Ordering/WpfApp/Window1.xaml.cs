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
using Newtonsoft.Json;
using System.IO;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        //Need to have a create order button (everything disabled until created)
        //Add quantity to order system
        //write order to JSON 

        //Remove item needs to be rewritten


        //We need to set up these to use in the program
        public Order newOrder;
        public List<OrderItem> thisCatalogue;
        public List<Order> previousOrders;


        public Window1()
        {
            InitializeComponent();

            //First We disable the add to order button until the order is created
            addButton.IsEnabled = false;
            submitButton.IsEnabled = false;
            remButton.IsEnabled = false;
            deleteOrderButton.IsEnabled = false;

            //This sets up our window
            this.Width = 1000;
            this.Height = 500;
            this.Title = "Welcome to Our Catalogue";

            //Here we'll handle our previous order lists

            previousOrders = new List<Order>();

            //oswald
            thisCatalogue = new List<OrderItem>();
            OrderItem a = new OrderItem("pen", "blue", 9.99, 0);
            OrderItem b = new OrderItem("pens", "red", 20.49, 0);
            thisCatalogue.Add(a);
            thisCatalogue.Add(b);
            catalogueViewer.ItemsSource = thisCatalogue;
        }

        //This handles creating our initial order, which we will add items too
        private void Create_Order(object sender, RoutedEventArgs e)
        {
            //First we create a variable for our username
            string userName = Username.Text;
            int orderNumber = 0;

            //Now we try and get an integer for the order Number
            try
            {
                orderNumber = int.Parse(OrderNumber.Text);
            }
            catch
            {
                errorMessage.Text = "Please enter a whole number for the order number.";
                return;
            }

            //Now we check to make sure something valid was entered
            if(orderNumber == 0 || userName == "")
            {
                //If we're missing either a username or password, we throw an error message for the user
                errorMessage.Text = "Please enter a valid Username and Order Number.";
                return;
            } 
            else
            {
                //We clear any error messages
                errorMessage.Text = "";

                //We enable our add to order button
                addButton.IsEnabled = true;
                
                //We create our new order
                newOrder = new Order(orderNumber, userName);

                //We disable the ability to create a new order
                createOrder.IsEnabled = false;

                //And enable submitting the order
                submitButton.IsEnabled = true;

                //Enable deleting the order
                deleteOrderButton.IsEnabled = true;

                //And set up the viewer to target this order
                orderViewer.ItemsSource = newOrder.OrderList;
            }           
        }

        //This handles submitting our order
        private void Submit_Order(object sender, RoutedEventArgs e)
        {
            //First we use the class method to make a JSON object
            //newOrder.SubmitOrder();

            //For now we just display it
            Console.WriteLine("Here is the final order:");
            //Console.WriteLine(newOrder.FinalOrder);

            //We clear our text boxes
            Username.Text = "";
            OrderNumber.Text = "";

            //Then we reneable our buttons to make a new order
            createOrder.IsEnabled = true;
            addButton.IsEnabled = false;
            submitButton.IsEnabled = false;
            remButton.IsEnabled = false;
            deleteOrderButton.IsEnabled = false;

            //And let the user know the order has been submitted
            errorMessage.Text = "Order: " + newOrder.OrderNumber + ", successfully submitted by " + newOrder.UserName + "!\nFinal Total: $" + newOrder.TotalCost;

            //We add this order to our previous order list
            previousOrders.Add(newOrder);

            //Now we covert our list to a JSON string
            string JSONList = JsonConvert.SerializeObject(previousOrders, Formatting.Indented);
            
            //This writes our JSON List to a local file.
            File.WriteAllText(@"OrderBackup.JSON", JSONList);

            //Then we overwrite the order with a placeholder to clear it
            newOrder = new Order(1, "PlaceHolder");

            //And clear our total cost
            Cost.Text = "Total Cost: $0.00";
        }

        //This function handles adding an item to the order
        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            //First we get the index of our selected item
            int selectedIndex = catalogueViewer.SelectedIndex;

            //Now we'll check the added quantity
            int quantity = 0;
            try
            {
                quantity = int.Parse(Quantity.Text);
            } 
            catch
            {
                //We set the quantity to zero, and we'll handle it later
                quantity = 0;
            }

            //Now we check to see if a quantity was actually added above 0
            if (quantity < 0)
            {
                //We throw and error if they've selected less than 1 quantity
                errorMessage.Text = "Please enter a quantity greater than 0.";
            }
            else if (quantity == 0)
            {
                //This means either they entered zero, or entered a non integer.
                errorMessage.Text = "Please only enter whole numbers greater than 0 in the Quantity field.\nNo Items were added to the order.";
            }
            else
            {
                //We clear our error messages, if any
                errorMessage.Text = "";

                //Now we add that item to our order
                newOrder.AddItem(thisCatalogue[selectedIndex], quantity);

                //And we refresh the order view
                orderViewer.Items.Refresh();

                //and enable our remove button
                remButton.IsEnabled = true;

                //Reset the quantity to one
                Quantity.Text = "1";

                //And update our total cost
                Cost.Text = "Total Cost: $" + newOrder.TotalCost;
            }
        }

        private void remButton_Click(object sender, RoutedEventArgs e)
        {
            //First we set up a string from our object, the first characters of which will be the item ID
            string itemString = orderViewer.SelectedItem.ToString().Substring(10);

            //We know the Item ID ends with a comma, so we find the index of that comma
            int commaIndex = itemString.IndexOf(',');

            //Then we make a new string of just the Item ID
            string IDString  = itemString.Substring(0, commaIndex);
            Console.WriteLine(IDString);

            //Then we parse to an int
            int itemID = -1;
            try
            {
                errorMessage.Text = "";
                itemID = int.Parse(IDString);
            }
            catch
            {
                errorMessage.Text = "Item could not be removed!";
            }
            
            //And we can remove the item.
            newOrder.RemoveItem(itemID);

            //And we refresh the order view
            orderViewer.Items.Refresh();

            //If there aren't any items, we disable the remove items button
            if(orderViewer.Items.Count == 0)
            {
                remButton.IsEnabled = false;
            }

            //And update our total cost
            Cost.Text = "Total Cost: $" + newOrder.TotalCost;
        }

        //This handles deleting an order entirely
        private void Delete_Order(object sender, RoutedEventArgs e)
        {
            //First we clear our text boxes
            Username.Text = "";
            OrderNumber.Text = "";

            //Then we reneable our buttons to make a new order
            createOrder.IsEnabled = true;
            addButton.IsEnabled = false;
            submitButton.IsEnabled = false;
            remButton.IsEnabled = false;
            deleteOrderButton.IsEnabled = false;

            //And let the user know the order has been submitted
            errorMessage.Text = "Order: " + newOrder.OrderNumber + ", has been deleted by " + newOrder.UserName + "!";

            //And clear our total cost
            Cost.Text = "Total Cost: $0.00";

            //Then we overwrite the order with a placeholder to clear it
            newOrder = new Order(1, "PlaceHolder");
        }

        private void LoadOrders()
        {
            
        }
    }
}
