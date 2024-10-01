using InciAlbum.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InciAlbum.DataAccessLayer.Contexts
{
    public class InciAlbumContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-2PU1K7L\\SQLEXPRESS; database=InciAlbumDB; integrated security=true");
        }
        public DbSet<myService> myServices { get; set; }
        public DbSet<Stuff> Stuffs { get; set; }
        public DbSet<Notice> Notices { get; set; }
        public DbSet<myAdress> myAdresses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
