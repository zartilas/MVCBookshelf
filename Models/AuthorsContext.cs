using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCBookshelf.Models
{
    public class AuthorsContext : DbContext //connection with database
    {
        public DbSet<authors> Authors { get; set; }
    }
}