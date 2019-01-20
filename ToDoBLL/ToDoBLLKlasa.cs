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
        public List<ToDoListInfo> getTodoListInfos()
        {
            return _li.getTodoListsInfo();
        }

        //get all lists ordered by name ascending
        public List<ToDoListInfo> getToDoListInfosASC()
        {
            return _li.getTodoListsInfoASC();
        }

        //get all lists ordered by name descending
        public List<ToDoListInfo> getToDoListInfosDESC()
        {
            return _li.getTodoListsInfoDESC();
        }

        //get a list by id
        public List<ToDoListInfo> getTodoListInfo(int id)
        {
            return _li.getListById(id);
        }

        //get a list by name
        public List<ToDoListInfo> getListByName(string name)
        {
            return _li.getListByName(name);
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
