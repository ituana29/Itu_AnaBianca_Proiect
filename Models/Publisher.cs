using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Itu_AnaBianca_Proiect.Models
{
    public class Publisher
    {
        public int ID { get; set; }

        [Display(Name = "Magazin")]
        public string PublisherName { get; set; }
        public ICollection<Oja> Oje { get; set; }
    }
}
