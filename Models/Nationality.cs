using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Nationality
    {
        public long ID { get; set; }
        [Display(Name = "название национальности")]
        public string name { get; set; }
        [Display(Name = "замечания")]
        public string remark { get; set; }

        public virtual ICollection<Client> clients { get; set; }
    }
}
