//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BanVeMayBay.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ordersdetail
    {
        public int ID { get; set; }
        public int orderid { get; set; }
        public int ticketId { get; set; }
        public int quantity { get; set; }
    
        public virtual order order { get; set; }
        public virtual ticket ticket { get; set; }
    }
}
