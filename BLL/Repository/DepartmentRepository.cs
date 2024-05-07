﻿using BLL.Interfaces;
using DAL.Context;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository
{
	public class DepartmentRepository : GenericRepository<Department>,IDepartmentRepository
	{
		public DepartmentRepository(MVC2DbContext _context): base(_context) { }// constructor channing
	}
}
