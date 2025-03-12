using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.G02.DAL.Modles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Company.G02.DAL.Data.configuration
{
    internal class Deptconfiduration:IEntityTypeConfiguration<Department>
    {
        
public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(b => b.id).UseIdentityColumn(10, 10);
        }
    }
}
