// See https://aka.ms/new-console-template for more information
using System;
namespace Lecture1
{
    public class Program
    {
        public enum Season
        {
            Spring,
            Sommer, 
            Autumn, 
            Winter
        }
        public void Main(string[] args)
        {
            bool isGoldCustomer = true;
            //float price = 19.95f;

            /* if (isGoldCustomer)
            {
                price = 19.95f;
            }
            else
            {
                price = 29.95f;
            } */

            float price = (isGoldCustomer) ? 19.95f : 29.95f; // the same as is/else statement above
            Console.WriteLine(price);
        }
        
    }

}
