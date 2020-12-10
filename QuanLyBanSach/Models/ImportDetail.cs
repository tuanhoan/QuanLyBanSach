using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuanLyBanSach.Models
{
    class ImportDetail
    {
        [Column("id")]
        public int ImportId { get; set; }
        [Column("book_id")]
        public int BookId { get; set; }
        [Column("count")]
        public int Count { get; set; }
        [Column("price")]
        public double Price { get; set; }
        public Book BookNavigation { get; set; }
        public Import ImportNavigation { get; set; }
    }
}
