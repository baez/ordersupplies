using System;
using System.Collections;
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
using BusinessLogic.QueueManagement;


namespace WpfApp
{
    /// <summary>
    /// Interaction logic for OrderQueue.xaml
    /// </summary>
    public partial class OrderQueue : Page
    {

        Queue orderQueue = new Queue();
        public int queueSize = 999999;
   
        //int position;
        public int rear = -1;

  

        //checks if empty
        public bool isEmpty { get { return orderQueue.Count == 0; } }
        //checks if  full
        public bool isFull { get { return orderQueue.Count == queueSize; } }



        public OrderQueue()
        {
            orderQueue = new Queue(queueSize); // set our queue size
            
            
        }

        private void Enqueue(object sender, RoutedEventArgs e)
        {
           
            orderQueue.Enqueue(item.Text);
            UpdateQueue();
        }

        private void Dequeue(object sender, RoutedEventArgs e)
        {
        
            
            orderQueue.Dequeue();

            UpdateQueue();
        }

        public void UpdateQueue()
        {
            if (isEmpty == true)
            {
                const String str = "No items in the stack.";
                count.Text = str;
            } else
            {
                count.Text = orderQueue.Count.ToString();
                String str = "";

                foreach (object obj in orderQueue)
                {
                    str += obj + "\n";
                }

                stack.Text = str;
            }
            
        }

    
    }
}
