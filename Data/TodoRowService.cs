using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace TodoBlazor.Data
{
    public class TodoRowService
    {
        public Task<List<TodoRow>> GetTodoRows()
        {
            List<TodoRow> tempRows = new();

            tempRows.Add(new TodoRow(
                1, "Testing task first", "pending"
            ));

            tempRows.Add(new TodoRow(
                2, "Testing task second", "pending"
            ));

            tempRows.Add(new TodoRow(
                3, "Testing task third", "pending"
            ));

            return Task.FromResult(tempRows);
        }

        public void AddToRow(List<TodoRow> list, TodoRow row)
        {
            list.Add(row);
        }
    }
}
