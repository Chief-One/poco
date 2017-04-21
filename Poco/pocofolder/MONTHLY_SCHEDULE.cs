using System;
 
namespace Your.Namespace.Here
{
    public class MONTHLY_SCHEDULE 
    {
        public int ms_id { get; set; }
        public int ms_sid { get; set; }
        public int? ms_daynumber { get; set; }
        public int? ms_recurrenceid { get; set; }
        public int? ms_recurrenceweekdayid { get; set; }
    }

	public class MONTHLY_SCHEDULEMap: : EntityMap<MONTHLY_SCHEDULE> 
    {
		public MONTHLY_SCHEDULEMap()
		{
						this.Map(x => x.ms_id).
                 ToColumn("ms_id");

						this.Map(x => x.ms_sid).
                 ToColumn("ms_sid");

						this.Map(x => x.ms_daynumber).
                 ToColumn("ms_daynumber");

						this.Map(x => x.ms_recurrenceid).
                 ToColumn("ms_recurrenceid");

						this.Map(x => x.ms_recurrenceweekdayid).
                 ToColumn("ms_recurrenceweekdayid");

					}
    }
}      
