using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Itu_AnaBianca_Proiect.Models;
using System.ComponentModel.DataAnnotations;

namespace Itu_AnaBianca_Proiect.Data
{
    public class Itu_AnaBianca_ProiectContext : DbContext
    {
        public Itu_AnaBianca_ProiectContext (DbContextOptions<Itu_AnaBianca_ProiectContext> options)
            : base(options)
        {
        }

        public DbSet<Itu_AnaBianca_Proiect.Models.Oja> Oja { get; set; }

        public DbSet<Itu_AnaBianca_Proiect.Models.Publisher> Publisher { get; set; }

        public DbSet<Itu_AnaBianca_Proiect.Models.Category> Category { get; set; }
    }
}
