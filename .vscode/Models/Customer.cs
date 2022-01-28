using System;
using EntityFrameworkCore;

namespace Deliverycart.Models
{
    public class Customer
    {
        public int CustomerID {get;set;}
        public int BillingID {get;set;}
        public int UserID{get;set;}
        public string delivAdd {get;set;}
        //one to many
        public List<Order> Orders {get;set;}
        public User User {get; set;}
    }
}