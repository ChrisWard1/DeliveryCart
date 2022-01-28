using System;
using EntityFrameworkCore;

namespace Deliverycart
{
    public class Customer
    {
        public int CustomerID {get;set;}

        public int BillingID {get;set;}

        public int UserID{get;set;}

        public string delivAdd {get;set;}
    }
}