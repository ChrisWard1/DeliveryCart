using System;

namespace Deliverycart
{
    public class Order
    {
        public int OrderID {get;set;}

        public int CustomerID {get;set;}

        public int ShopperID {get;set;}
        public int itemID {get;set;}
        public int Qty {get;set;}
        public string itemName {get;set;}
    }
}