using System;
 
namespace Your.Namespace.Here
{
    public class RECURRENCE 
    {
        public int r_id { get; set; }
        public string r_desc { get; set; }
    }

	public class RECURRENCEMap: : EntityMap<RECURRENCE> 
    {
		public RECURRENCEMap()
		{
						this.Map(x => x.r_id).
                 ToColumn("r_id");

						this.Map(x => x.r_desc).
                 ToColumn("r_desc");

					}
    }
}      
