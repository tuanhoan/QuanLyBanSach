using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuanLyBanSach.Models
{
    class Book
    {
        public Book()
        {
            BillDetails = new HashSet<BillDetail>();
            ImportDetails = new HashSet<ImportDetail>();
        }
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        [MaxLength(100)]
        public string Name { get; set; }
        [Column("category_id")]
        public int CategoryId { get; set; }
        [Column("publisher_id")]
        public int PublisherId { get; set; }
        [Column("author_id")]
        public int AuthorId { get; set; }
        [Column("price")]
        public double Price { get; set; }
        [Column("count")]
        public int Count { get; set; }
        public Category CategoryNavigation { get; set; }
        public Publisher PublisherNavigation { get; set; }
        public Author AuthorNavigation { get; set; }
        public ICollection<BillDetail> BillDetails { get; set; }
        public ICollection<ImportDetail> ImportDetails { get; set; }
    }
}
