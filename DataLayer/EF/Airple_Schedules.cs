//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Airple_Schedules
    {
        public Airple_Schedules()
        {
            this.Tickets = new HashSet<Ticket>();
        }
    
        public int Id { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }
        public int AirplaneId { get; set; }
    
        public virtual Airplane Airplane { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}