using Dapper;
using Northwind.Application.Abstraction;
using Northwind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Infraestructure
{
    public class EmployessRepository :  IEmployessRepositore
    {
        private readonly ISqlConnectionFasctory _sqlConnectionFasctory;

        public EmployessRepository(ISqlConnectionFasctory sqlConnectionFasctory) 
        {
            this._sqlConnectionFasctory = sqlConnectionFasctory;
        }
        public IEnumerable<Employess> GetEmployesses()
        {
            var conetion = _sqlConnectionFasctory.GetNewConnection();
            return conetion.Query<Employess>("SELECT * FROM Employees");
        }

    }
}
