using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Data;
using SalesWebMVC.Models;

namespace SalesWebMVC.Services;

public class DepartmentService(SalesWebMVCContext context)
{
    public async Task<List<Department>> FindAllAsync()
    {
        return await context.Department.OrderBy(x => x.Name).ToListAsync();
    }
}