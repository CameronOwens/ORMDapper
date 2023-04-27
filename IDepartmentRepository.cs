using System;
using IntroSQL;

namespace ORM_Dapper1
{
	public interface IDepartmentRepository
	{
		IEnumerable<Department> GetAllDepartments();
	}
}

