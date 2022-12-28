using Becomentario.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;


namespace Becomentario
{
    public class AplicationDbcontext:DbContext
    {
        public DbSet<comentario> Comenterio { get; set; }

        public AplicationDbcontext(DbContextOptions<AplicationDbcontext>options):base(options)
        {

        }
    }
}
