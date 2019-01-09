using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoEF.DataAccess;

namespace ToDoEF.DataAccess
{
    public class DbAccess: IDbAccess
    {
        public todoListEntities GetContext()
        {
            return new todoListEntities();
        }
    }
}

