using Microsoft.EntityFrameworkCore;
using MvcCorePostgresEC2.Data;
using MvcCorePostgresEC2.Models;

namespace MvcCorePostgresEC2.Repositories
{
    public class RepositoryHospital
    {
        private HospitalContext context;

        public RepositoryHospital(HospitalContext context)
        {
            this.context = context;
        }

        public async Task<List<Dept>> GetDeptsAsync()
        {
            return await context.Depts.ToListAsync();
        }

        public async Task<Dept> FindDeptAsync(int id)
        {
            return await context.Depts.FirstOrDefaultAsync(x => x.IdDept == id);
        }

        public async Task CreateDeptsAsync(int id, string nombre, string loc)
        {
            Dept dept = new Dept
            {
                IdDept = id,
                Nombre = nombre,
                Loc = loc
            };
            await context.Depts.AddAsync(dept);
            await context.SaveChangesAsync();
        }
    }
}
