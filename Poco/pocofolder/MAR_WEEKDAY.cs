using System;
 
namespace Your.Namespace.Here
{
    public class MAR_WEEKDAY 
    {
        public int mwd_id { get; set; }
        public string mwd_desc { get; set; }
    }

	public class MAR_WEEKDAYMap: : EntityMap<MAR_WEEKDAY> 
    {
		public MAR_WEEKDAYMap()
		{
						this.Map(x => x.mwd_id).
                 ToColumn("mwd_id");

						this.Map(x => x.mwd_desc).
                 ToColumn("mwd_desc");

					}
    }
}      
