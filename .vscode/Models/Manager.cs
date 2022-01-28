using System;
using Microsoft.EntityFrameworkCore;

namespace Deliverycart.Models
{
    public class Manager : Shopper
    {
        public int ManagerID {get;set;}
        public List<Shopper> Shoppers{get;set;}
    }

}