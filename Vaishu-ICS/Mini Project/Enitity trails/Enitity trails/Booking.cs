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
    
    public partial class Booking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Booking()
        {
            this.Cancellations = new HashSet<Cancellation>();
        }
    
        public int BookingId { get; set; }
        public string PassengerName { get; set; }
        public int TrainNo { get; set; }
        public string ClassName { get; set; }
        public System.DateTime DateOfTravel { get; set; }
        public int NumberOfTickets { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public string Status { get; set; }
    
        public virtual Train Train { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cancellation> Cancellations { get; set; }
    }
}