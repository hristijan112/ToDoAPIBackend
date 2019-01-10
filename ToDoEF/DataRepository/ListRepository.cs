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
        public List<todoListInfo> GetTodoListsInfo()
        {
            return _dbContext.todo_list_table.Select(e => new todoListInfo
            {
                id = e.id,
                name = e.name,
                desc = e.desc
            }).ToList();
        }

        //Create a new list
        public void AddList(todoListInfo listPost)
        {
            todo_list_table listAdd = new todo_list_table();

            listAdd.id = 0;
            listAdd.name = listPost.name;
            listAdd.desc = listPost.desc;

            _dbContext.todo_list_table.Add(listAdd);
            _dbContext.SaveChanges();
        }
    }
}
