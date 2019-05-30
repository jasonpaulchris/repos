using System;
using System.ComponentModel.DataAnnotations;

namespace Livly.Data
{
    public class Orders
    {
        public Orders()
        {

        }
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public bool HasTipped { get; set; }
        public decimal OrderAmount { get; set; }
        public string RestaurantName { get; set; }
        public decimal TippingHistory { get; set; }
        public DateTime OrderTime { get; set; }
    }
}
