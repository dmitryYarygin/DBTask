using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;
using WebDBLybrary.Models;

namespace Zags.Models
{
    public class Service
    {
        public long ID { get; set; }
        [Display(Name = "Дата")]
        public DateTime date { get; set; }
        [Display(Name = "клиент")]
        public virtual Client client { get; set; }
        [Display(Name = "сервис 1")]
        public int service1 { get; set; }
        [Display(Name = "сервис 2")]
        public int service2 { get; set; }
        [Display(Name = "сервис 3")]
        public int service3 { get; set; }
        [Display(Name = "цена")]
        public int price { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
