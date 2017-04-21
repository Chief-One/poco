using System;
 
namespace Your.Namespace.Here
{
    public class WEEKLY_SCHEDULE 
    {
        public int ws_id { get; set; }
        public int ws_sid { get; set; }
        public int ws_weekdayid { get; set; }
    }

	public class WEEKLY_SCHEDULEMap: : EntityMap<WEEKLY_SCHEDULE> 
    {
		public WEEKLY_SCHEDULEMap()
		{
						this.Map(x => x.ws_id).
                 ToColumn("ws_id");

						this.Map(x => x.ws_sid).
                 ToColumn("ws_sid");

						this.Map(x => x.ws_weekdayid).
                 ToColumn("ws_weekdayid");

					}
    }
}      
