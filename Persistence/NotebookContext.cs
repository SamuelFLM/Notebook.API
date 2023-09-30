using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_test.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api_test.Persistence
{
    public class NotebookContext : DbContext
    {
        public NotebookContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Notebook> Notebooks {get;set;}
}
}