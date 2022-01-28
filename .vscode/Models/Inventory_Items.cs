using System;
using EntityFrameworkCore;

namespace Deliverycart
{
    public class Inventory_Items
    {
        public int invitemID {get;set;}

        public int VendorID {get;set;}

        public string itemName {get;set;}

        public int qtyonHand {get;set;}
    }
}