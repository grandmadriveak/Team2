using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2.Model
{
    class Department
    {
        private string _depid;
        private string _depname;

       public Department() {  }

        public Department(string DepId, String DepName)
        {
            _depid = DepId;
            _depname = DepName;
        }

        public string DepId
        {
            get { return _depid; }
            set { _depid = value; }
        }

        public string DepName
        {
            get { return _depname; }
            set { _depname = value; }
        }

    }
}
