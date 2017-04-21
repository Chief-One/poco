using System;
 
namespace Your.Namespace.Here
{
    /// <summary>
    /// Represents a Order.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class Order 
    {
        public int OrderId { get; set; }
 
        public int? BuyerId { get; set; }
 
        public DateTime? OrderDate { get; set; }
 
        public decimal? OrderTotal { get; set; }
    }
}      
