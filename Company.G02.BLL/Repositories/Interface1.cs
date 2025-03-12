using Company.G02.DAL.Modles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.G02.BLL.Repositories
{
    public interface Interface1
    {
        IEnumerable<Department> getall();
        Department get(int id);
        int Add(Department model);
        int Update(Department model);
        int delete(Department model);
    }
}
