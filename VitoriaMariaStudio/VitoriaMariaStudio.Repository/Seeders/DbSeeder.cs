using Microsoft.EntityFrameworkCore;
using VitoriaMariaStudio.Domain.Entities;
using VitoriaMariaStudio.Repository.Context;

namespace VitoriaMariaStudio.Repository.Seeders
{
    public class DbSeeder
    {
        public static void Seed(StudioDbContext context)
        {
            var roles = new List<Role> {
                new Role
                {
                    Name = "Role 1",
                },
                new Role
                {
                    Name = "Role 2",
                }
            };

            var persons = new List<Person>
            {
                new Person
                {
                    Name = "Name 1",
                    Address = "Address 1",
                    Email = "Email@1.com",
                    Phone = "1"
                },
                new Person
                {
                    Name = "Name 2",
                    Address = "Address 2",
                    Email = "Email@2.com",
                    Phone = "2"
                }
            };

            var professionals = new List<Professional>
            {
                new Professional
                {
                    Name = "Name 1",
                    Address = "Address 1",
                    Email = "Email@1.com",
                    Phone = "1",
                    Role = roles[0],
                    RoleId = roles[0].Id
                },
                new Professional
                {
                    Name = "Name 2",
                    Address = "Address 2",
                    Email = "Email@2.com",
                    Phone = "2",
                    Role = roles[1],
                    RoleId = roles[1].Id
                }
            };

            var categories = new List<Category>
            {
                new Category
                {
                    Name = "Category 1",
                },
                new Category
                {
                    Name = "Category 2",
                }
            };

            var jobs = new List<Job>
            {
                new Job
                {
                    Name = "Name 1",
                    Description = "Description 1",
                    Price = 1,
                    Category = categories[0],
                    CategoryId = categories[0].Id,
                },
                new Job
                {
                    Name = "Name 2",
                    Description = "Description 2",
                    Price = 2,
                    Category = categories[1],
                    CategoryId = categories[1].Id,
                }
            };

            var schedulings = new List<Scheduling>
            {
                new Scheduling
                {
                    Client = persons[0],
                    ClientId = persons[0].Id,
                    Date = DateTime.Now.AddDays(55),
                    Professional = professionals[0],
                    ProfessionalId= professionals[0].Id,
                },
                new Scheduling
                {
                    Client = persons[1],
                    ClientId = persons[1].Id,
                    Date = DateTime.Now.AddDays(13),
                    Professional = professionals[1],
                    ProfessionalId= professionals[1].Id,
                }
            };

            schedulings[0].Jobs = jobs;
            schedulings[1].Jobs = jobs;

            if (context.Roles.FirstOrDefault() == null) context.AddRange(roles);
            if (context.Persons.FirstOrDefault() == null) context.AddRange(persons);
            if (context.Professionals.FirstOrDefault() == null) context.AddRange(professionals);
            if (context.Categories.FirstOrDefault() == null) context.AddRange(categories);
            if (context.Schedulings.FirstOrDefault() == null) context.AddRange(schedulings);
            if (context.Jobs.FirstOrDefault() == null) context.AddRange(jobs);

            context.SaveChanges();
        }
    }
}