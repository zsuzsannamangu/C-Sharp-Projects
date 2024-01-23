using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstToNewDatabase
{
    public class SchoolContext : DbContext //The Code-First approach requires a context class which should be derived from DbContext built-in class
    {
        public SchoolContext() : base()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<SchoolContext>());
        }

        public DbSet<Student> Students { get; set; } //The context class exposes DbSet properties.
                                                     //The DbSet is a collection of entity classes, so we have given the property name as the plural of entity name like Students and Grades.
        public DbSet<Grade> Grades { get; set; }
    }
}
