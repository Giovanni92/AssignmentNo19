using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo19
{
    class Employees
    {
		private int employeeID;
		private string firstName;
		private string lastName;
		private decimal salary;
		private int age;
		private List<int> appraisal;


		public int EmployeeID
		{
			get { return employeeID; }
			set { employeeID = value; }
		}

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public List<int> Appraisal
        {
            get { return appraisal; }
            set { appraisal = value; }
        }

    }
}
