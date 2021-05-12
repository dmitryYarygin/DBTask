using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Relations
    {
        public long ID { get; set; }
        [Display(Name = "название отношения")]
        public string name { get; set; }
        [Display(Name = "описание")]
        public string describtion { get; set; }

        public virtual ICollection<Client> clients { get; set; }
    }
}
