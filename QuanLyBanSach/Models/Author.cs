using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuanLyBanSach.Models
{
    class Author
    {
        public Author()
        {
            Books = new HashSet<Book>();
        }
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        [MaxLength(50)]
        public string Name { get; set; }
        [Column("create_at")]
        public DateTime CreateAt { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
