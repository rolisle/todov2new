using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDoV2.Models;

namespace ToDoV2.Data
{
    public class MvcToDoContext : DbContext
    {
        public MvcToDoContext(DbContextOptions<MvcToDoContext> options) : base(options)
        {

        }

        public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}
