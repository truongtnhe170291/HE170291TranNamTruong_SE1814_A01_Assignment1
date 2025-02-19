using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTO
{
    public class AccountViewModel
    {
        public short AccountID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100)]
        public string AccountName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        [StringLength(70)]
        public string AccountEmail { get; set; }

        public int? AccountRole { get; set; }

        [StringLength(70)]
        public string? AccountPassword { get; set; }
    }
}
