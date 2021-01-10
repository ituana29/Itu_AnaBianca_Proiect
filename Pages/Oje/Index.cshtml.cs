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
    public class IndexModel : PageModel
    {
        private readonly Itu_AnaBianca_ProiectContext _context;

        public IndexModel(Itu_AnaBianca_ProiectContext context)
        {
            _context = context;
        }

        public IList<Oja> Oja { get;set; }

        public async Task OnGetAsync()
        {
            Oja = await _context.Oja.Include(b => b.Publisher).ToListAsync();
        }
    }
}
