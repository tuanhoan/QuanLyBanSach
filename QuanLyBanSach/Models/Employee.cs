using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuanLyBanSach.Models
{
    class Employee
    {
        public Employee()
        {
            Bills = new HashSet<Bill>();
            Imports = new HashSet<Import>();
            Customers = new HashSet<Customer>();
        }
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        [MaxLength(50)]
        public string Name { get; set; }
        [Column("username")]
        [MaxLength(50)]
        public string UserName { get; set; }
        [Column("password")]
        [MaxLength(50)]
        public string Password { get; set; }
        [Column("phone_number")]
        [MaxLength(15)]
        public string PhoneNumber { get; set; }
        [Column("create_at")]
        public DateTime CreateAt { get; set; }
        [Column("address")]
        [MaxLength(150)]
        public string Address { get; set; }
        [Column("role_id")]
        public int RoleId { get; set; }
        public virtual Role RoleNaviagtion { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<Import> Imports { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
