using Interfaces.QueueManagement;
using System;

namespace QueueManagement
{
    // Harman and Abbe : 
    // I created the IQueue interface for you.
    // Please implement the Queue constructor and functions 
    // 

    public class OrderQueue<T> : IOrderQueue<T>
    {
    
        T[] orderQueue = new T[99999];
        //public static OrderQueue<T>[] orderQueue;
        public int front;
        //int position;
        public int rear = -1;
        public int queueSize = 999999;
        public int numOfItems;
          
        //cehcks if empty
        public bool isEmpty { get { return numOfItems == 0; } }
        //checks if  full
        public bool isFull { get { return numOfItems == queueSize; } }

        public OrderQueue()
        {
            //order quuee constructor
           orderQueue = new T[queueSize]; //can store 999999 items LOL
        }

        public int Count()
        {
            return numOfItems;
        }

        public T Dequeue()
        {
           if (front == rear)
            {
                Console.WriteLine("the queue is empty");
            }

            return orderQueue[--numOfItems];
        }

        public void Enqueue(T item)
        {
             if (isFull == true )
            {
                Console.WriteLine("the queue is full!");
            } 
            else
            {

              
                
                orderQueue[rear++] = item;
                
            }
        }

        public T Peek()
        {
           T topItem = default(T);
            if (isEmpty == true)
            {
                Console.WriteLine("the queue is empty ");
            }
            
           else
            {
                topItem = orderQueue[front];
               
            }

            return topItem;

    
        }
    }
}
