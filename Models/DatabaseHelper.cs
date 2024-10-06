using Microsoft.EntityFrameworkCore;
using System;
using System.Data.SQLite;
using System.IO;

namespace Accounting.Models
{
    public class DatabaseHelper : DbContext
    {
        public DbSet<Debtor> Debtors { get; set; }
        public DbSet<Income> Income { get; set; }
        public DbSet<Ledger> Ledgers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try 
            {

                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                string projectRoot = Path.GetFullPath(Path.Combine(baseDirectory, @"..\..\..\"));

                string dbFilePath = Path.Combine(projectRoot, "Data", "accounts.db");

                optionsBuilder.UseSqlite($"Data Source={dbFilePath};");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message );
            }           
        }
        
    }
}
