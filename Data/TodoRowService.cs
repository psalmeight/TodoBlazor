using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Collections.ObjectModel;

namespace TodoBlazor.Data
{
    public class TodoRowService
    {

        public Task<List<TodoRow>> GetObservableRows()
        {
            List<TodoRow> tempRows = new();

            tempRows.Add(new TodoRow(1, "pending", "Testing task first"));

            tempRows.Add(new TodoRow(
                2, "pending", "Testing task second"
            ));

            tempRows.Add(new TodoRow(
                3, "pending", "Testing task third"
            ));

            return Task.FromResult(tempRows);
        }

        public void AddToRow(List<TodoRow> list, TodoRow row)
        {
            list.Add(row);
        }
    }
}
