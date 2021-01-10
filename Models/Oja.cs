using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Itu_AnaBianca_Proiect.Models
{
    public class Oja
    {
        public int ID { get; set; }

        [Display(Name = "Culoare Oja")]
        public string Culoare { get; set; }

        [Display(Name = "Firma")]
        public string Firma { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Pret { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Entry Date")]
        public DateTime PublishingDate { get; set; }

        public int PublisherID { get; set; }
        public Publisher Publisher { get; set; }
        public ICollection<OjaCategory> OjaCategories { get; set; }
    }
}
