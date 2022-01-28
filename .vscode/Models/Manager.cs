using System;
using Microsoft.EntityFrameworkCore;

namespace Deliverycart
{
    public class Manager
    {
        public int ManagerID {get;set;}
        public List<Shopper> Shoppers{get;set;}
    }

}