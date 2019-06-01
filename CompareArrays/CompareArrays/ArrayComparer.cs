namespace CompareArrays
{
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
}