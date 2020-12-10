using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuanLyBanSach.Models
{
    class Role
    {
        public Role()
        {
            Employees = new HashSet<Employee>();
        }
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        [MaxLength(50)]
        public string Name { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
