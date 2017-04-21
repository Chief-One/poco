using System;
 
namespace Your.Namespace.Here
{
    public class Buyer 
    {
        public int BuyerId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public char? Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public double? CreditRating { get; set; }
        public char? XCode { get; set; }
        public string TelephoneNumber { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public string Notes { get; set; }
    }

	public class BuyerMap: : EntityMap<Buyer> 
    {
		public BuyerMap()
		{
						this.Map(x => x.BuyerId).
                 ToColumn("BuyerId");

						this.Map(x => x.FirstName).
                 ToColumn("FirstName");

						this.Map(x => x.MiddleName).
                 ToColumn("MiddleName");

						this.Map(x => x.LastName).
                 ToColumn("LastName");

						this.Map(x => x.Gender).
                 ToColumn("Gender");

						this.Map(x => x.DateOfBirth).
                 ToColumn("DateOfBirth");

						this.Map(x => x.CreditRating).
                 ToColumn("CreditRating");

						this.Map(x => x.XCode).
                 ToColumn("XCode");

						this.Map(x => x.TelephoneNumber).
                 ToColumn("TelephoneNumber");

						this.Map(x => x.Street1).
                 ToColumn("Street1");

						this.Map(x => x.Street2).
                 ToColumn("Street2");

						this.Map(x => x.City).
                 ToColumn("City");

						this.Map(x => x.ZipCode).
                 ToColumn("ZipCode");

						this.Map(x => x.Longitude).
                 ToColumn("Longitude");

						this.Map(x => x.Latitude).
                 ToColumn("Latitude");

						this.Map(x => x.Notes).
                 ToColumn("Notes");

					}
    }
}      
