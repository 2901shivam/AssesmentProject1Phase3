using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AssesmentProjectPhase3.Models;

namespace AssesmentProjectPhase3.Data
{
    public class AssesmentProjectPhase3Context : DbContext
    {
        public AssesmentProjectPhase3Context (DbContextOptions<AssesmentProjectPhase3Context> options)
            : base(options)
        {
        }

        public DbSet<AssesmentProjectPhase3.Models.DeptMaster> DeptMaster { get; set; } = default!;

        public DbSet<AssesmentProjectPhase3.Models.EmpProfile>? EmpProfile { get; set; }
    }
}
