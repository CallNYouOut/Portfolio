using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using group_project_i_brownie_bandits;

namespace group_project_i_brownie_bandits
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("UsersConnectionString") { }

        public DbSet<User> Users { get; set; }
    }
}
