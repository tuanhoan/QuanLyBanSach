using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuanLyBanSach.Models
{
    class Customer
    {
        public Customer()
        {
            Bills = new HashSet<Bill>();
        }
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        [MaxLength(100)]
        public string Name { get; set; }
        [Column("create_at")]
        public DateTime CreateAt { get; set; }
        [Column("phone_number")]
        [MaxLength(15)]
        public string PhoneNumber { get; set; }
        [Column("email")]
        [MaxLength(50)]
        public string Email { get; set; }
        [Column("address")]
        [MaxLength(150)]
        public string Address { get; set; }
        [Column("employee_id")] 
        public int EmloyeeId { get; set; }
        public virtual Employee EmployeeNavigation { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
    }
}
