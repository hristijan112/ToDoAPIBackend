using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoEF.DataAccess
{
    public interface IDbAccess
    {
        todoListEntities GetContext();
    }
}
