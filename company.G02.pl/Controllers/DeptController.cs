using company.G02.pl.Models;
using Company.G02.BLL;
using Company.G02.DAL.Modles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace company.G02.pl.Controllers
{
    public class DeptController : Controller
    {
        private readonly deptReposit _deptReposit;
        public DeptController(deptReposit deptdes)
        {
            _deptReposit = deptdes;
        }
        [HttpGet]
        public IActionResult Index()
        {
           var model= _deptReposit.getall();
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateDeptDto dto)
        {
            if (ModelState.IsValid)
            {
                var dept = new Department()
                {
                    code=dto.code,
                    name=dto.name,
                    createat=dto.createat
                };
                var count=_deptReposit.Add(dept);
                if(count > 0)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View();
        }
    }
}
