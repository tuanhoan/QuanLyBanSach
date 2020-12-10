using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuanLyBanSach.Models
{
    class Category
    {
        public Category()
        {
            Books = new HashSet<Book>();
        }
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        [MaxLength(50)]
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
