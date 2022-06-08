using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModelViewController.Models;

namespace ModelViewController.Data
{
    public class ModelViewControllerContext : DbContext
    {
        public ModelViewControllerContext (DbContextOptions<ModelViewControllerContext> options)
            : base(options)
        {
        }

        public DbSet<ModelViewController.Models.Movie> Movie { get; set; }
    }
}
