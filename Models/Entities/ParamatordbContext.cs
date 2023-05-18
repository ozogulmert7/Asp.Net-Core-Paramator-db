using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace occupy.Models.Entities;

public partial class ParamatordbContext : DbContext
{
    public ParamatordbContext()
    {
    }

    public ParamatordbContext(DbContextOptions<ParamatordbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<About> Abouts { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<Site> Sites { get; set; }

    public virtual DbSet<Slide> Slides { get; set; }

    public virtual DbSet<Success> Successes { get; set; }

    public virtual DbSet<Team> Teams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;port=3306;database=paramatordb;user=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.27-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8_turkish_ci")
            .HasCharSet("utf8");

        modelBuilder.Entity<About>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("about");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Detail).HasColumnName("detail");
            entity.Property(e => e.Image)
                .HasMaxLength(200)
                .HasDefaultValueSql("'0'")
                .HasColumnName("image");
            entity.Property(e => e.Isview).HasColumnName("isview");
            entity.Property(e => e.Order).HasColumnName("order");
            entity.Property(e => e.Subtitle)
                .HasMaxLength(200)
                .HasDefaultValueSql("'0'")
                .HasColumnName("subtitle");
            entity.Property(e => e.Title)
                .HasMaxLength(200)
                .HasDefaultValueSql("'0'")
                .HasColumnName("title");
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.HasKey(e => e.Int).HasName("PRIMARY");

            entity.ToTable("message");

            entity.Property(e => e.Int).HasColumnName("int");
            entity.Property(e => e.Isview).HasColumnName("isview");
            entity.Property(e => e.Order).HasColumnName("order");
            entity.Property(e => e.Subtitle)
                .HasMaxLength(150)
                .HasColumnName("subtitle");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasColumnName("title");
            entity.Property(e => e.Url)
                .HasMaxLength(150)
                .HasColumnName("url");
            entity.Property(e => e.UrlTarget)
                .HasMaxLength(50)
                .HasColumnName("urlTarget");
            entity.Property(e => e.UrlText)
                .HasMaxLength(150)
                .HasColumnName("urlText");
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("service");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Image)
                .HasMaxLength(150)
                .HasColumnName("image");
            entity.Property(e => e.Isview).HasColumnName("isview");
            entity.Property(e => e.Order).HasColumnName("order");
            entity.Property(e => e.Subtitle)
                .HasMaxLength(150)
                .HasDefaultValueSql("'0'")
                .HasColumnName("subtitle");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasDefaultValueSql("'0'")
                .HasColumnName("title");
            entity.Property(e => e.Url)
                .HasMaxLength(200)
                .HasColumnName("url");
            entity.Property(e => e.UrlTarget)
                .HasMaxLength(50)
                .HasColumnName("urlTarget");
            entity.Property(e => e.UrlText)
                .HasMaxLength(200)
                .HasColumnName("urlText");
        });

        modelBuilder.Entity<Site>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("site");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .HasColumnName("email");
            entity.Property(e => e.Facebook)
                .HasMaxLength(250)
                .HasColumnName("facebook");
            entity.Property(e => e.Favicon)
                .HasMaxLength(250)
                .HasColumnName("favicon");
            entity.Property(e => e.Instagram)
                .HasMaxLength(250)
                .HasColumnName("instagram");
            entity.Property(e => e.Logo)
                .HasMaxLength(250)
                .HasColumnName("logo");
            entity.Property(e => e.Title)
                .HasMaxLength(250)
                .HasColumnName("title");
            entity.Property(e => e.Twitter)
                .HasMaxLength(250)
                .HasColumnName("twitter");
            entity.Property(e => e.Url)
                .HasMaxLength(250)
                .HasColumnName("url");
            entity.Property(e => e.Youtube)
                .HasMaxLength(250)
                .HasColumnName("youtube");
        });

        modelBuilder.Entity<Slide>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("slide");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Image)
                .HasMaxLength(250)
                .HasColumnName("image");
            entity.Property(e => e.Isview)
                .HasDefaultValueSql("'0'")
                .HasColumnName("isview");
            entity.Property(e => e.Order).HasColumnName("order");
            entity.Property(e => e.Subtitle)
                .HasColumnType("text")
                .HasColumnName("subtitle");
            entity.Property(e => e.Title)
                .HasMaxLength(150)
                .HasColumnName("title");
            entity.Property(e => e.Url)
                .HasMaxLength(250)
                .HasColumnName("url");
            entity.Property(e => e.UrlTarget)
                .HasMaxLength(50)
                .HasColumnName("urlTarget");
            entity.Property(e => e.UrlText)
                .HasMaxLength(250)
                .HasColumnName("urlText");
        });

        modelBuilder.Entity<Success>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("success");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Image)
                .HasMaxLength(100)
                .HasColumnName("image");
            entity.Property(e => e.Isview).HasColumnName("isview");
            entity.Property(e => e.Order).HasColumnName("order");
            entity.Property(e => e.Subtitle)
                .HasMaxLength(200)
                .HasDefaultValueSql("'0'")
                .HasColumnName("subtitle");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasDefaultValueSql("'0'")
                .HasColumnName("title");
            entity.Property(e => e.Url)
                .HasMaxLength(200)
                .HasColumnName("url");
            entity.Property(e => e.UrlTarget)
                .HasMaxLength(50)
                .HasColumnName("urlTarget");
            entity.Property(e => e.UrlText)
                .HasMaxLength(150)
                .HasColumnName("urlText");
        });

        modelBuilder.Entity<Team>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("team");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Facebook)
                .HasMaxLength(200)
                .HasColumnName("facebook");
            entity.Property(e => e.Image)
                .HasMaxLength(250)
                .HasDefaultValueSql("'0'")
                .HasColumnName("image");
            entity.Property(e => e.Instagram)
                .HasMaxLength(200)
                .HasColumnName("instagram");
            entity.Property(e => e.Isview).HasColumnName("isview");
            entity.Property(e => e.Linkedin)
                .HasMaxLength(200)
                .HasColumnName("linkedin");
            entity.Property(e => e.Order).HasColumnName("order");
            entity.Property(e => e.Subtitle)
                .HasMaxLength(250)
                .HasDefaultValueSql("'0'")
                .HasColumnName("subtitle");
            entity.Property(e => e.Title)
                .HasMaxLength(200)
                .HasDefaultValueSql("'0'")
                .HasColumnName("title");
            entity.Property(e => e.Twitter)
                .HasMaxLength(200)
                .HasColumnName("twitter");
            entity.Property(e => e.Youtube)
                .HasMaxLength(200)
                .HasColumnName("youtube");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
