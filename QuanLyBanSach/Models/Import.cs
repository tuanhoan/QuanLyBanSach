using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuanLyBanSach.Models
{
    class Import
    {
        public Import()
        {
            ImportDetails = new HashSet<ImportDetail>();
        }
        [Column("id")]
        public int Id { get; set; }
        [Column("suplier_id")]
        public int SupplierId { get; set; }
        [Column("empoyee_id")]
        public int EmployeeId { get; set; }
        [Column("create_at")]
        public DateTime CreateAt { get; set; }
        public Supplier SupplierNavigation { get; set; }
        public Employee EmployeeNavigation { get; set; }
        public virtual ICollection<ImportDetail> ImportDetails { get; set; }
    }
}
