using System;
 
namespace Your.Namespace.Here
{
    public class SCHEDULE 
    {
        public int s_id { get; set; }
        public int s_cmid { get; set; }
        public int s_mfmiid { get; set; }
        public DateTime s_startdate { get; set; }
        public DateTime? s_enddate { get; set; }
        public bool? s_active { get; set; }
        public DateTime? s_insertdate { get; set; }
        public string s_insertedby { get; set; }
        public DateTime? s_lastupdate { get; set; }
        public string s_lastupdatedby { get; set; }
    }

	public class SCHEDULEMap: : EntityMap<SCHEDULE> 
    {
		public SCHEDULEMap()
		{
						this.Map(x => x.s_id).
                 ToColumn("s_id");

						this.Map(x => x.s_cmid).
                 ToColumn("s_cmid");

						this.Map(x => x.s_mfmiid).
                 ToColumn("s_mfmiid");

						this.Map(x => x.s_startdate).
                 ToColumn("s_startdate");

						this.Map(x => x.s_enddate).
                 ToColumn("s_enddate");

						this.Map(x => x.s_active).
                 ToColumn("s_active");

						this.Map(x => x.s_insertdate).
                 ToColumn("s_insertdate");

						this.Map(x => x.s_insertedby).
                 ToColumn("s_insertedby");

						this.Map(x => x.s_lastupdate).
                 ToColumn("s_lastupdate");

						this.Map(x => x.s_lastupdatedby).
                 ToColumn("s_lastupdatedby");

					}
    }
}      
