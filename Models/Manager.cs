using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Deliverycart2.Models
{
    public class Manager : Shopper
    {
        public int ManagerID {get;set;}  = default!;
        public List<Shopper> Shoppers{get;set;}= default!;
    }

}