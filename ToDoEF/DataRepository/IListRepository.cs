using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoEF.Contracts;
using ToDoEF.DataAccess;

namespace ToDoEF.DataRepository
{
    interface IListRepository
    {
        List<todoListInfo> GetTodoListsInfo();

    }
}
