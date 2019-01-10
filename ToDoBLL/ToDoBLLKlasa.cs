using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoEF;
using ToDoEF.Contracts;
using ToDoEF.DataAccess;
using ToDoEF.DataRepository;

namespace ToDoBLL
{
    public class ToDoBLLKlasa
    {
        ListRepository _li;

        public ToDoBLLKlasa(ListRepository listRepo)
        {
            _li = listRepo;
        }

        //get all lists
        public List<todoListInfo> GetTodoListInfos()
        {
            return _li.GetTodoListsInfo();
        }

        //Create a new list
        public void AddList(todoListInfo listPost)
        {
            _li.AddList(listPost);
        }
    }
}
