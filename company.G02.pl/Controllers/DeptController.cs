using Company.G02.BLL;
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
    }
}
