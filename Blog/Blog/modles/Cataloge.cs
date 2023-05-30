using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.modles
{
    internal class Cataloge
    {
        public int id { get; set; }
        [StringLength(50)]
        public string? name { get; set; }
        [StringLength(100)]
        public string? description { get; set; }
        public virtual List<News> News { get; set; } = new List<News>();
    }
}
