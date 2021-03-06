﻿using Microsoft.EntityFrameworkCore;
using SalesWebSystemMvc.Data;
using SalesWebSystemMvc.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebSystemMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebSystemMvcContext _context;

        public DepartmentService(SalesWebSystemMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
