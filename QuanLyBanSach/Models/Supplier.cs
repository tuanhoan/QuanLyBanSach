using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuanLyBanSach.Models
{
    class Supplier
    {
        public Supplier()
        {
            Imports = new HashSet<Import>();
        }
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        [MaxLength(50)]
        public string Name { get; set; }
        [Column("phone_number")]
        [MaxLength(15)]
        public string PhoneNumber { get; set; }
        [Column("create_at")]
        public DateTime CreateAt { get; set; }
        [Column("email")]
        [MaxLength(50)]
        public string Email { get; set; }
        [Column("address")]
        [MaxLength(150)]
        public string Address { get; set; }
        public virtual ICollection<Import> Imports { get; set; }
    }
}
