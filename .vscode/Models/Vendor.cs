using System;

namespace Deliverycart
{
    public class Vendor
    {
        public int VendorID {get;set;}

        public int UserID {get;set;}

        public int BillingID {get;set;}

        public string storeAddress {get;set;}
        public string storeCity {get;set;}
        public string storeState {get;set;}
        public int storeZip {get;set;}
        
    }
}