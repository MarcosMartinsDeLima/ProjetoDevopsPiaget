using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiPiaget.models;

namespace ApiPiaget.Data
{
    public class ApiPiagetContext : DbContext
    {
        public ApiPiagetContext (DbContextOptions<ApiPiagetContext> options)
            : base(options)
        {
        }

        public DbSet<ApiPiaget.models.Aluno> Aluno { get; set; } = default!;
        public DbSet<ApiPiaget.models.Professor> Professor { get; set; } = default!;
    }
}
