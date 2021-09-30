using FoodApp.Domain.Model;
using FoodApp.Persistance.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FoodApp.Persistance.Context
{
    public class FoodAppContext : DbContext
    {
        public FoodAppContext(DbContextOptions<FoodAppContext> options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Food> Foods { get; set; }

        public DbSet<FoodGroup> FoodGroups { get; set; }

        public DbSet<Serving> Servings { get; set; }

        public DbSet<Statement> Statements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=FoodAppDB;Trusted_Connection=True;MultipleActiveResultSets=true");
            optionsBuilder.UseSqlServer("workstation id=FoodAppDB.mssql.somee.com;packet size=4096;user id=ebola_SQLLogin_1;pwd=p5qwjuon1k;data source=FoodAppDB.mssql.somee.com;persist security info=False;initial catalog=FoodAppDB");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // You can remove SeedData method after creating migrations
            //SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            FillServingTable(modelBuilder);
            FillFoodTable(modelBuilder);
            FillFoodGroupTable(modelBuilder);
            FillStatementTable(modelBuilder);
        }

        private void FillStatementTable(ModelBuilder modelBuilder)
        {
            var statements = DataReader.ReadStatementCSV();
            var statementData = new List<Statement>();

            for (int i = 1; i < statements.Count; i++)
            {
                statementData.Add(
                    new Statement
                    {
                        Id = i,
                        FoodGroupId = statements[i][0],
                        DirectionalStatement = statements[i][1]
                    }
                );
            }
            modelBuilder.Entity<Statement>().HasData(statementData);
        }

        private void FillFoodGroupTable(ModelBuilder modelBuilder)
        {
            var foodGroups = DataReader.readFoodGroupCSV();
            var foodGroupData = new List<FoodGroup>();

            for (int i = 1; i < foodGroups.Count; i++)
            {
                var foodGroupCategoryId = int.Parse(foodGroups[i][2]) + 1;
                foodGroupData.Add(
                    new FoodGroup
                    {
                        Id = i,
                        FoodGroupId = foodGroups[i][0],
                        FoodGroupName = foodGroups[i][1],
                        FoodGroupCategoryId = foodGroupCategoryId,
                        FoodGroupCategoryName = foodGroups[i][3]
                    }
                );
            }
            modelBuilder.Entity<FoodGroup>().HasData(foodGroupData);
        }

        private void FillFoodTable(ModelBuilder modelBuilder)
        {
            var foods = DataReader.readFoodCSV();
            var foodData = new List<Food>();

            for (int i = 1; i < foods.Count; i++)
            {
                foodData.Add(
                    new Food
                    {
                        Id = i,
                        FoodGroupId = foods[i][0],
                        FoodGroupCategory = int.Parse(foods[i][1]),
                        ServingSize = foods[i][2],
                        Foods = foods[i][3]
                    }
                );
            }
            modelBuilder.Entity<Food>().HasData(foodData);
        }

        private void FillServingTable(ModelBuilder modelBuilder)
        {
            var servings = DataReader.readServingCSV();
            var servingData = new List<Serving>();

            for (int i = 1; i < servings.Count; i++)
            {
                servingData.Add(
                    new Serving
                    {
                        Id = i,
                        FoodGroupId = servings[i][0],
                        Gender = servings[i][1],
                        Age = servings[i][2],
                        Servings = servings[i][3]
                    }
                );
            }
            modelBuilder.Entity<Serving>().HasData(servingData);
        }
    }
}
