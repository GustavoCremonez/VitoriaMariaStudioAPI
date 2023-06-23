using Microsoft.EntityFrameworkCore;
using VitoriaMariaStudio.Domain.Entities;
using VitoriaMariaStudio.Repository.Context;

namespace VitoriaMariaStudio.Repository.Seeder
{
    public class DbSeeder
    {
        public static void Seed(StudioDbContext context)
        {
            #region Role

            context.Set<Role>().AddRange(
                new Role
                {
                    Id = 1,
                    Name = "Administrador",
                },
                new Role
                {
                    Id = 2,
                    Name = "Cliente",
                });

            #endregion Role

            #region Person

            context.Set<Person>().AddRange(
                new Person
                {
                    Name = "Gustavo Cremonez",
                    Address = "Rua Maria Sarzedas, Londrina, Paraná.",
                    Email = "aparecido2332001@gmail.com",
                    Phone = "(43) 99125-7628"
                },
                new Person
                {
                    Name = "Vitoria Maria",
                    Address = "Avenida Simons Bolívar, Londrina, Paraná.",
                    Email = "teste@teste.com",
                    Phone = "(43) 99999-9999"
                });

            #endregion Person

            #region Category

            context.Set<Category>().AddRange(
                new Category
                {
                    Id = 1,
                    Name = "Sombrancelha",
                },
                new Category
                {
                    Id = 2,
                    Name = "Pele",
                });

            #endregion Category

            #region Job

            context.Set<Job>().AddRange(
                new Job
                {
                    Id = 1,
                    Name = "Job 1",
                    Description = "Job 1",
                    Price = 100.00M,
                    CategoryId = 2
                },
                new Job
                {
                    Id = 2,
                    Name = "Job 2",
                    Description = "Job 2",
                    Price = 76.50M,
                    CategoryId = 1
                },
                new Job
                {
                    Id = 3,
                    Name = "Job 3",
                    Description = "Job 3",
                    Price = 99.99M,
                    CategoryId = 2
                }
                );

            #endregion Job

            context.SaveChanges();
        }
    }
}