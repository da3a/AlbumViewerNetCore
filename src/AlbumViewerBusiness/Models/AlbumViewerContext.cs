using Microsoft.EntityFrameworkCore;
using System;


namespace AlbumViewerBusiness
{
    public class AlbumViewerContext : DbContext
    {
        public string ConnectionString { get; set; }

        public AlbumViewerContext(DbContextOptions<AlbumViewerContext> options) : base(options)
        {
        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Album>().ToTable("Albums");
        }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);

        //    if (optionsBuilder.IsConfigured)
        //        return;

        //    // Auto configuration
        //    ConnectionString = Configuration.GetValue<string>("Data:AlbumViewer:ConnectionString");
        //    optionsBuilder.UseSqlServer(ConnectionString);
        //}

    }
}