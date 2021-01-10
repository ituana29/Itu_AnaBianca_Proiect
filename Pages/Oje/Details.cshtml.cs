using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Itu_AnaBianca_Proiect.Data;
using Itu_AnaBianca_Proiect.Models;

namespace Itu_AnaBianca_Proiect.Pages.Oje
{
    public class DetailsModel : PageModel
    {
        private readonly Itu_AnaBianca_Proiect.Data.Itu_AnaBianca_ProiectContext _context;

        public DetailsModel(Itu_AnaBianca_Proiect.Data.Itu_AnaBianca_ProiectContext context)
        {
            _context = context;
        }

        public Oja Oja { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Oja = await _context.Oja.FirstOrDefaultAsync(m => m.ID == id);

            if (Oja == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
