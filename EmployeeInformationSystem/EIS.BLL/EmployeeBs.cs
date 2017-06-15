using EIS.BOL;
using EIS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIS.BLL
{
    public class EmployeeBs
    {
        private EmployeeDb ObjDb;

        public List<string> Errors = new List<string>();

        public EmployeeBs()
        {
            ObjDb = new EmployeeDb();
        }
        public IEnumerable<Employee> GetALL()
        {
            return ObjDb.GetALL();
        }
        public Employee GetByID(string Id)
        {
            return ObjDb.GetByID(Id);
        }

        public bool Insert(Employee emp)
        {
            if (IsValidOnInsert(emp))
            {
                ObjDb.Insert(emp);                
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Delete(string Id)
        {
            ObjDb.Delete(Id);
        }
        public bool Update(Employee emp)
        {
            if (IsValidOnUpdate(emp))
            {
                ObjDb.Update(emp);
                return true;
            }
            else
            {
                return false;
            }
        }
        public Employee GetByEmail(string email)
        {
            return ObjDb.GetByEmail(email);
        }

        public bool IsValidOnInsert(Employee emp)
        {
            return true;
        }

        public bool IsValidOnUpdate(Employee emp)
        {
            return true;
        }
    }
}
