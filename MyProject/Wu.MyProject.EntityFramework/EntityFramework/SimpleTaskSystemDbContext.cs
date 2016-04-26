using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.EntityFramework;
using Wu.MyProject.People;

namespace Wu.MyProject.EntityFramework
{
    public class SimpleTaskSystemDbContext : AbpDbContext
    {
        public virtual IDbSet<Task> Tasks { get; set; }

        public virtual IDbSet<Person> People { get; set; }

        public SimpleTaskSystemDbContext()
            : base("Default")
        {

        }

        public SimpleTaskSystemDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

    }
}
