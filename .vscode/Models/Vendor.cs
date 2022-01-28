using System;
using Microsoft.EntityFrameworkCore;


namespace Deliverycart.Models
{
    public class Vendor : User
    {
        public int VendorID {get;set;}

        public User User {get; set;}

        public int BillingID {get;set;}

        public string storeAddress {get;set;}
        public string storeCity {get;set;}
        public string storeState {get;set;}
        public int storeZip {get;set;}
        
    }
}