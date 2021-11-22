using System;

namespace CarRentalManagement.Shared.Domain
{
    public class Booking : BaseDomainModel
    {
        public DateTime DateOut { get; set; }
        public DateTime Datein { get; set; }
        public int VehicleId { get; set; }  
        public virtual Vehicle Vehicle { get; set; }    
        public int CustomerId { get; set; } 
        public virtual Customer Customer { get; set; }
    }
}