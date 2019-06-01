using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstCart = new CartMock
            {
                ShippingMethods = new ShippingMethod[]
                {
                    new ShippingMethod
                    {
                        Amount = 0,
                        Description = "Free Standard Shipping"
                    },
                    new ShippingMethod()
                    {
                        Amount = 14.99,
                        Description = "Expedited Shipping"
                    },
                    new ShippingMethod()
                    {
                        Amount = 19.99,
                        Description = "Next Business Day"
                    }
                },
            };
            firstCart.SelectedShippingMethod = firstCart.ShippingMethods[0];

            var secondCart = new CartMock
            {
                ShippingMethods = new ShippingMethod[]
                {
                    new ShippingMethod
                    {
                        Amount = 0,
                        Description = "Free Standard Shipping"
                    },
                    new ShippingMethod()
                    {
                        Amount = 14.99,
                        Description = "Expedited Shipping"
                    },
                    //new ShippingMethod()
                    //{
                    //    Amount = 19.99,
                    //    Description = "Next Business Day"
                    //}
                },
            };

            secondCart.SelectedShippingMethod = secondCart.ShippingMethods[0];

            Console.WriteLine("The first cart's selected shipping method is " + firstCart.SelectedShippingMethod.Description);
            Console.WriteLine("The second cart's selected shipping method is " + secondCart.SelectedShippingMethod.Description);

            Console.WriteLine("==========================================================================");
            Console.WriteLine("=                                 After                                  =");
            Console.WriteLine("==========================================================================");

            var comparer = new ArrayComparer();
            var mostDiscountedMethod = comparer.CompareShippingMethods(firstCart, secondCart);
            if (mostDiscountedMethod != null)
            {
                secondCart.SelectedShippingMethod = mostDiscountedMethod;
            }

            Console.WriteLine("The current second cart's selected shipping method is " + secondCart.SelectedShippingMethod.Description);
            Console.ReadLine();
        }
    }

    public class ArrayComparer
    {
        // compare the two arrays to see if there has been any change
        // grab the members of the array that have changed and store them in a new array
        // set the selected shipping method to the thing with the biggest difference in pricing

        public ShippingMethod CompareShippingMethods(CartMock originalCart, CartMock newCart) 
        {
            var largestDiscount = 0.00;
            ShippingMethod mostDiscountedShippingMethod = null;
            for (int i = 0; i < originalCart.ShippingMethods.Length; i++)
            {
                if ((originalCart.ShippingMethods[i].Amount - newCart.ShippingMethods[i].Amount) > largestDiscount)
                {
                    largestDiscount = originalCart.ShippingMethods[i].Amount - newCart.ShippingMethods[i].Amount;
                    mostDiscountedShippingMethod = newCart.ShippingMethods[i];
                }
            }
            return mostDiscountedShippingMethod;
        }

    }

    public class CartMock
    {
        public ShippingMethod[] ShippingMethods { get; set; }
        public ShippingMethod SelectedShippingMethod { get; set; }
    }

    public class ShippingMethod
    {
        public double Amount { get; set; }
        public string Description { get; set; }
    }
}
