using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcBasicWalkthrough.Models;
using System.ComponentModel.DataAnnotations;

namespace MvcBasicWalkthrough.ViewModels
{
    public class ShoppingCartViewModel
    {
        [Key]
        public int ShoppingCartId { get; set; }
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}