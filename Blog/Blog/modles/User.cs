using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.modles
{
    internal class User
    {
        public int id { get; set; }

        [StringLength(50)]
        public string? name { get; set; }
        public int? age { get; set; }

        [StringLength(100)]
        public string? address { get; set; }
        [Required]
        public string? email { get; set; }
        [Required]
        public string? password { get; set; }

        public string? photo { get; set; }

        public virtual List<News> News { get; set; } = new List<News>();
    }
}
