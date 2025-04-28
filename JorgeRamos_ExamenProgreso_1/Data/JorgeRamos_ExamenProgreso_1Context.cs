using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JorgeRamos_ExamenProgreso_1.Models;

namespace JorgeRamos_ExamenProgreso_1.Data
{
    public class JorgeRamos_ExamenProgreso_1Context : DbContext
    {
        public JorgeRamos_ExamenProgreso_1Context (DbContextOptions<JorgeRamos_ExamenProgreso_1Context> options)
            : base(options)
        {
        }

        public DbSet<JorgeRamos_ExamenProgreso_1.Models.Cliente> Cliente { get; set; } = default!;
    }
}
