using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNote.Data
{
    public interface IDataHelper<Table>
    {
        Task<List<Table>> GetAllAsync();
        Task<Table> FindAsync(int Id);
        Task AddDataAsync(Table table);
        Task UpdateDataAsync(Table table);
        Task RemoveDataAsync(Table table);
    }
}
