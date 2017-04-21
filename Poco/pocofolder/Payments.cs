using System;
 
namespace Your.Namespace.Here
{
    public class Payments 
    {
        public int ProductId { get; set; }
        public int? BuyerId { get; set; }
    }

	public class PaymentsMap: : EntityMap<Payments> 
    {
		public PaymentsMap()
		{
						this.Map(x => x.ProductId).
                 ToColumn("ProductId");

						this.Map(x => x.BuyerId).
                 ToColumn("BuyerId");

					}
    }
}      
