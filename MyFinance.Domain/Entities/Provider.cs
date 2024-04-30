using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Domain.Entities
{
    public class Provider
    {
        public string? ConfirmPassword { get; set; }
        public DateTime? DateCreated { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public int Id { get; set; }
        public bool IsApproved { get; set; }
        public string? UserName { get; set; }
        public virtual ICollection<Product>? Products { get; set; }
    }
}
