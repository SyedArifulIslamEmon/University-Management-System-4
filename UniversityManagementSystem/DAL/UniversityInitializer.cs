using System.Collections.Generic;
using System.Data.Entity;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.DAL
{
    public class UniversityInitializer : DropCreateDatabaseIfModelChanges<UniversityDbContext>
    {
        protected override void Seed(UniversityDbContext context)
        {
            var designation = new List<Designation>
            {
                new Designation {Name = "Professor"},
                new Designation {Name = "Asst. Professor"},
                new Designation {Name = "Lecturer"},
                new Designation {Name = "Asst. Lecturer"}
            };

            designation.ForEach(d => context.Designations.Add(d));
            context.SaveChanges();
        }
    }
}