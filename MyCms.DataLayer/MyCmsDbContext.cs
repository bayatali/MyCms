using Microsoft.EntityFrameworkCore;
using MyCms.DomainClasses.Page;
using MyCms.DomainClasses.PageGroup;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCms.DataLayer
{
    public class MyCmsDbContext : DbContext
    {
        public MyCmsDbContext(DbContextOptions<MyCmsDbContext> options) : base(options)
        {

        }
 
        public DbSet<PageGroup> PageGroups { get; set; }
        public DbSet<Page> Pages { get; set; }
    }
}
