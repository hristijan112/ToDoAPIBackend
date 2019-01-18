using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoEF.Contracts;
using ToDoEF.DataAccess;

namespace ToDoEF.DataRepository
{
    public class ListRepository : IListRepository
    {
        private todoListEntities _dbContext;

        public ListRepository(DbAccess dbAccess)
        {
            _dbContext = dbAccess.GetContext();
        }

        //return all lists
        public List<ToDoListInfo> getTodoListsInfo()
        {
            return _dbContext.todo_list_table.Select(e => new ToDoListInfo
            {
                id = e.id,
                name = e.name,
                desc = e.desc,
            }).ToList();
        }

        //Select a list by ID
        public List<ToDoListInfo> getListById(int id)
        {
            return _dbContext.todo_list_table.Where(e => e.id == id).Select(l => new ToDoListInfo
            {
                id = l.id,
                name = l.name,
                desc = l.desc
            }).ToList();
        }

        //Create a new list
        public void addList(ToDoListInfo listPost)
        {
            todo_list_table listAdd = new todo_list_table();

            listAdd.id = 0;
            listAdd.name = listPost.name;
            listAdd.desc = listPost.desc;

            _dbContext.todo_list_table.Add(listAdd);
            _dbContext.SaveChanges();
        }

        //Edit a list
        public void updateList(int id, ToDoListInfo listPut)
        {
            var listEdit = _dbContext.todo_list_table.First(e => e.id == id);
            listEdit.id = id;
            listEdit.name = listPut.name;
            listEdit.desc = listPut.desc;

            _dbContext.SaveChanges();
        }

        //Delete a list
        public void deleteList(int id)
        {
            _dbContext.todo_list_table.Remove(_dbContext.todo_list_table.First(e => e.id == id));
            _dbContext.SaveChanges();
        }
    }
}