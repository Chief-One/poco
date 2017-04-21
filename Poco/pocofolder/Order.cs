using System;
 
namespace Your.Namespace.Here
{
    public class Order 
    {
        public int OrderId { get; set; }
        public int? BuyerId { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal? OrderTotal { get; set; }
    }

	public class OrderMap: : EntityMap<Order> 
    {
		public OrderMap()
		{
						this.Map(x => x.OrderId).
                 ToColumn("OrderId");

						this.Map(x => x.BuyerId).
                 ToColumn("BuyerId");

						this.Map(x => x.OrderDate).
                 ToColumn("OrderDate");

						this.Map(x => x.OrderTotal).
                 ToColumn("OrderTotal");

					}
    }
}      
