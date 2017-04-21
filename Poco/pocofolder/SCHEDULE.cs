using System;
 
namespace Your.Namespace.Here
{
    /// <summary>
    /// Represents a SCHEDULE.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
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
}      
