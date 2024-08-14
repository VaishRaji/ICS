using System.Collections.Generic;

namespace MVC_EF_Db.Controllers
{
    internal class northwindEntities
    {
        public northwindEntities()
        {
        }

        public IEnumerable<object> Customers { get; internal set; }
    }
}