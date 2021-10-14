using MakeAuth.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeAuth.Data
{
    /// <summary>
    /// 
    /// Get-Migration - Список миграций
    /// Update-Database Initial - откат миграции до конкретной миграции с именем Initial (Имя соответственно может быть любое)
    /// Update-Database - применение миграций
    /// Update-Database 0 - откат всех миграций.
    /// Remove-Migration - удаляет файл последней миграции
    /// Drop-Database - удаление БД
    /// Add-Migration Test - создает новую миграцию с именем "Test"
    /// 
    /// </summary>
    public class MyDbContext: DbContext
    {
        //public MyDbContext(DbContextOptions<MyDbContext> options): base(options)
        //{
        //    //
        //}

        public DbSet<User> Users { get; set; }

        //public MyDbContext()
        //{
        //    Database.EnsureCreated();
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;user=root;password=root;database=sharp;",
                new MySqlServerVersion(new Version(8, 0, 11))
            );
        }
    }
}
