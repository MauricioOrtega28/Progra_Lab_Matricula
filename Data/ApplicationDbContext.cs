using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Progra_Lab_Matricula.Data
{
    public class ApplicationDbContext:IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {


        }

         public DbSet<Progra_Lab_Matricula.Models.Alumno> DataContactos{get; set;}
    }
}