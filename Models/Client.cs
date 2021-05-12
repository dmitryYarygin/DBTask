using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Zags.Models;

namespace WebApplication2.Models
{
    public class Client
    {
        public long ID { get; set; }
        [Display(Name = "имя")]
        public string name { get; set; }
        [Display(Name = "пол")]
        public string sex { get; set; }
        [Display(Name = "дата рождения")]
        public DateTime dateOfBirth  { get; set; }
        [Display(Name = "возвраст")]
        public int age { get; set; }
        [Display(Name = "рост")]
        public int height { get; set; }
        [Display(Name = "вес")]
        public int weight { get; set; }
        [Display(Name = "кол-во детей")]
        public int childNum { get; set; }
        [Display(Name = "семейное положение")]
        public string matirealStatus { get; set; }
        [Display(Name = "вредные привычки")]
        public string BadHabits { get; set; }
        [Display(Name = "хобби")]
        public string hobby { get; set; }
        [Display(Name = "описание")]
        public string description { get; set; }
        [Display(Name = "адрес")]
        public string address { get; set; }
        [Display(Name = "телефон")]
        public string phone { get; set; }
        [Display(Name = "паспортные данные")]
        public string pasportData { get; set; }
        [Display(Name = "инфо о партнере")]
        public string aboutPartner { get; set; }

        [Display(Name = "знак зодиака")]
        public long? zodaicSignId { get; set; }
        [Display(Name = "знак зодиака")]
        public virtual ZodiacSign zodaicSign { get; set; }
        [Display(Name = "отношения")]
        public virtual Relations relations { get; set; }
        [Display(Name = "национальность")]
        public virtual Nationality nationality { get; set; }

        public virtual ICollection<Service> Services { get; set; }
    }
}
