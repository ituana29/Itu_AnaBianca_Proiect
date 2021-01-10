using System.ComponentModel.DataAnnotations;

namespace Itu_AnaBianca_Proiect.Models
{
    public class OjaCategory
    {
        public int ID { get; set; }
        public int OjaID { get; set; }
        public Oja Oja { get; set; }
        public int CategoryID { get; set; }
        [Display(Name = "Client")]
        public Category Category { get; set; }
    }
}