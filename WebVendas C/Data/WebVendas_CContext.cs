using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebVendas_C.Models
{
    public class WebVendas_CContext : DbContext
    {
        public WebVendas_CContext(DbContextOptions<WebVendas_CContext> options) : 
        base(options){}

        public DbSet<WebVendas_C.Models.Department> Department { get; set; }
    }
}
