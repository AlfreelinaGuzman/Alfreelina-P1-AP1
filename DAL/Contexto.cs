using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Alfreelina_P1_AP1.Entidades;


namespace Alfreelina_P1_AP1.DAL{
 public class Contexto : DbContext{
     public DbSet<Ciudades> Ciudades{get; set;}

     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source =DATA/Ciudades.db");
        }
 }
}
