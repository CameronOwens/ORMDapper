using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using IntroSQL;
using ORM_Dapper1;

namespace ORM_Dapper1
{
	public class DapperDepartmentRepository : IDepartmentRepository
	{
		private readonly IDbConnection _connection;

		public DapperDepartmentRepository(IDbConnection connection)
		{
			_connection = connection;
		}

		public IEnumerable<Department> GetAllDepartments()
		{
			return _connection.Query<Department>("SELECT * FROM departments;");
		}
    }
}

