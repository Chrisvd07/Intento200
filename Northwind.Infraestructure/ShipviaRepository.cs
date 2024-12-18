using Northwind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Northwind.Application.Abstraction;

namespace Northwind.Infraestructure
{
    public class ShipviaRepository : IShipViaRepository
    {
        private readonly ISqlConnectionFasctory _sqlConnectionFasctory;

        public ShipviaRepository(ISqlConnectionFasctory sqlConnectionFasctory) 
        
        {
            this._sqlConnectionFasctory = sqlConnectionFasctory;
        }
        public IEnumerable<ShipVia> GetShipVias()
        {
            var connection = _sqlConnectionFasctory.GetNewConnection();
            return connection.Query<ShipVia>("SELECT * FROM Shippers");
        }
    }
}
