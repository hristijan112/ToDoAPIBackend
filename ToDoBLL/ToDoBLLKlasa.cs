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
        public List<ToDoShort> getTodoListInfos()
        {
            return _li.getTodoListsInfo();
        }

        //get a list by id
        public List<ToDoListInfo> getTodoListInfo(int id)
        {
            return _li.getListById(id);
        }

        //Create a new list
        public void addList(ToDoListInfo listPost)
        {
            _li.addList(listPost);
        }

        //Edit a list
        public void editList(int id, ToDoListInfo listPut)
        {
            _li.updateList(id, listPut);
        }

        //Delete a list
        public void deleteList(int id)
        {
            _li.deleteList(id);
        }
    }
}
