//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Enitity_trails
{
    using System;
    using System.Collections.Generic;
    
    public partial class TicketClassDetail
    {
        public int ClassId { get; set; }
        public Nullable<int> TrainNo { get; set; }
        public string ClassName { get; set; }
        public int TotalSeats { get; set; }
        public int AvailableSeats { get; set; }
        public Nullable<decimal> Fare { get; set; }
    
        public virtual Train Train { get; set; }
    }
}