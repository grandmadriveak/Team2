using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2.Model
{
    class Employee : Department
    {
        private string _cusid;
        private string _empname;
        private int _age;
        private bool _gender;
        private decimal _salary;

        public Employee() {  }

        public Employee(string CusId, string EmpName, int Age, bool Gender, decimal Salary)
        {
            _cusid = CusId;
            _empname = EmpName;
            _age = Age;
            _gender = Gender;
            _salary = Salary;
        }

        public string CusId
        {
            get { return _cusid; }
            set { _cusid = value; }
        }

        public string EmpName
        {
            get { return _empname; }
            set { _empname = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public bool Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public decimal Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

    }
}
