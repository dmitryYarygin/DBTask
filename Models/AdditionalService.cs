using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class AdditionalService
    {
        public long ID { get; set; }
        [Display(Name = "название сервиса")]
        public string name { get; set; }
        [Display(Name = "описание сервиса")]
        public string description { get; set; }
        [Display(Name = "цена")]
        public double price { get; set; }
    }
}
