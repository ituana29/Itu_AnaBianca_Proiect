using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Itu_AnaBianca_Proiect.Models
{
    public class Category
    {
        public int ID { get; set; }

        [Display(Name = "Nume client")]
        public string CategoryName { get; set; }
        public ICollection<OjaCategory> OjaCategories { get; set; }
    }
}
