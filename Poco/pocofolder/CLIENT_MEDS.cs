using System;
 
namespace Your.Namespace.Here
{
    public class CLIENT_MEDS 
    {
        public int cm_id { get; set; }
        public string cm_desc { get; set; }
    }

	public class CLIENT_MEDSMap: : EntityMap<CLIENT_MEDS> 
    {
		public CLIENT_MEDSMap()
		{
						this.Map(x => x.cm_id).
                 ToColumn("cm_id");

						this.Map(x => x.cm_desc).
                 ToColumn("cm_desc");

					}
    }
}      
