using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Deliverycart.Models
{
    public class User
    {
        private int UserID {get;set;}

        private string FirstName {get;set;}

        public string LastName {get;set;}        
        public string Address {get;set;}
        public string City {get;set;}
        public string State {get;set;}
        public int zipCode {get;set;}
        

        public List <Customer> Customer {get;set;}
        public List <Vendor> Vendor {get;set;}
        public List<Shopper> Shopper {get;set;}

    }
}