using System;
 
namespace Your.Namespace.Here
{
    public class SCHEDULE_TIMES 
    {
        public int st_id { get; set; }
        public int st_sid { get; set; }
    }

	public class SCHEDULE_TIMESMap: : EntityMap<SCHEDULE_TIMES> 
    {
		public SCHEDULE_TIMESMap()
		{
						this.Map(x => x.st_id).
                 ToColumn("st_id");

						this.Map(x => x.st_sid).
                 ToColumn("st_sid");

					}
    }
}      
