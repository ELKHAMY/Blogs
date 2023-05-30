using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.modles
{
    internal class News
    {
        public int id { get; set; }
        [StringLength(100)]
        public string? title { get; set; }
        [StringLength(100)]
        public string? bref { get; set; }
        [StringLength(100)]
        public string? description { get; set; }
        [ForeignKey("User")]
        public int user_id { get; set; }
        [ForeignKey("Catalog")]
        public int catalogid { get; set; }

        public virtual User user { get; set; }
        public virtual Cataloge cataloge { get; set; }
    }
}
