using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CrudMvc.Models
{
    public class EscolaContext:DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
    }
}