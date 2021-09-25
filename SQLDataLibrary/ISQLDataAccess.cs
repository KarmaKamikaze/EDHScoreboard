using System.Collections.Generic;
using System.Threading.Tasks;

namespace SQLDataLibrary
{
    public interface ISQLDataAccess
    {
        string ConnectionStringName { get; set; }

        Task<List<T>> LoadData<T, U>(string sql, U paramters);
        Task SaveData<T>(string sql, T parameters);
    }
}