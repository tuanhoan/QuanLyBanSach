using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuanLyBanSach.Models
{
    class Bill
    {
        public Bill()
        {
            BillDetails = new HashSet<BillDetail>(); 
        }
        [Column("id")]
        public int Id { get; set; }
        [Column("create_at")]
        public DateTime CreateAt { get; set; }
        [Column("employee_id")]
        public int EmployeeId { get; set; }
        [Column("customer_id")]
        public int CustomerId { get; set; }
        public Employee EmployeeNavigation { get; set; }
        public Customer CustomerNavigation { get; set; } 
        public virtual ICollection<BillDetail> BillDetails { get; set; } 
    }
}
