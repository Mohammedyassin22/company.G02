using Company.G02.BLL.Repositories;
using Company.G02.DAL.Data.context;
using Company.G02.DAL.Modles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Company.G02.BLL
{
    public class deptReposit : Interface1
    {
        private readonly context _context;
        public deptReposit()
        {
            _context=new context();
        }
        
        public int Add(Department model)
        {
            _context.dept.Add(model);
          return  _context.SaveChanges();
        }
        public Department get(int id)
        {
            return _context.dept.Find(id);
        }

        public IEnumerable<Department> getall()
        {
            return _context.dept.ToList();
        }

        public int Update(Department model)
        {
             _context.dept.Update(model);
           return _context.SaveChanges();
        }
        public int delete(Department model)
        {
             _context.dept.Remove(model);
          return  _context.SaveChanges();
        }
    }
}
