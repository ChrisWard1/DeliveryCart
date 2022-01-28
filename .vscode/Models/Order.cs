using System;

namespace Deliverycart
{
    public class Order
    {
         public int OrderID {get;set;}
        public int CustomerID {get;set;}

        public Customer Customer {get;set;}

        public int ShopperID {get;set;}
        public Shopper Shopper {get;set;}
        public List <Order> Orders {get;set;}

        public int ShopperID {get;set;}        
        public int itemID {get;set;}

        public int Qty {get;set;}
    }
}