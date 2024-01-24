using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.Models
{
    public class OrderHeader
    {
        public int Id { get; set; }

        //cada pedido pertenecerá a un usuario
        public string ApplicationUserId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [ValidateNever]
        public ApplicationUser ApplicationUser { get; set; }

        //caracteristicas del pedido (fecha, total, etc.)
        public DateTime OrderDate { get; set; }
        public DateTime ShippingDate { get; set; }
        public double OrderTotal { get; set; }

        //estado del pedido, del pago y del envío, junto con el nro de seguimiento
        public string? OrderStatus { get; set; }
        public string? PaymentStatus { get; set; }
        public string? TrackingNumber { get; set; }
        public string? Carrier { get; set; }

        //datos para usuarios del tipo Company (pagan a 30 días)
        public DateTime PaymentDate { get; set; }
        //TODO: DateOnly type only available on .NET 8
        public DateTime PaymentDueDate { get; set; }

        //para tarjetas de credito
        public string? SessionId { get; set; }
        public string? PaymentIntentId { get; set; }

        //datos del usuario (algunos coinciden con ApplicationUser)
        [Required]
        public string Name { get; set; }
        [Required]
        public string StreetAddress { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string PostalCode { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
    }
}
