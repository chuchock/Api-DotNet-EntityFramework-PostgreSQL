using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_postgresql.Models;
using Microsoft.EntityFrameworkCore;

namespace api_postgresql.DataAccess
{
	public class PostgreSqlContext : DbContext
	{
		public PostgreSqlContext(DbContextOptions<PostgreSqlContext> options) : base(options)
		{
		}

		public DbSet<Patient> patients { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
		}

		public override int SaveChanges()
		{
			ChangeTracker.DetectChanges();
			return base.SaveChanges();
		}
	}
}
