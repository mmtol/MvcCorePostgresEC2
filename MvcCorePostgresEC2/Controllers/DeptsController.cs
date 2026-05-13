using Microsoft.AspNetCore.Mvc;
using MvcCorePostgresEC2.Models;
using MvcCorePostgresEC2.Repositories;

namespace MvcCorePostgresEC2.Controllers
{
    public class DeptsController : Controller
    {
        private RepositoryHospital repo;

        public DeptsController(RepositoryHospital repo)
        {
            this.repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            List<Dept> depts = await repo.GetDeptsAsync();
            return View(depts);
        }

        public async Task<IActionResult> Details(int id)
        {
            Dept dept = await repo.FindDeptAsync(id);
            return View(dept);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Dept dept)
        {
            await repo.CreateDeptsAsync(dept.IdDept, dept.Nombre, dept.Loc);
            return RedirectToAction("Index");
        }
    }
}
