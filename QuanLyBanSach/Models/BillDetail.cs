using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuanLyBanSach.Models
{
    class BillDetail
    {
        [Column("book_id")]
        public int BookId { get; set; }
        [Column("bill_id")]
        public int BillId { get; set; }
        [Column("count")]
        public int Count { get; set; } 
        public Book BookNavigation { get; set; }
        public Bill BillNavigation { get; set; }
    }
}
