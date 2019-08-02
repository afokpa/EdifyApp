using System.Collections.Generic;
using System.Threading.Tasks;
using EdifyApp.API.Models;

namespace EdifyApp.API.Data
{
    public interface IEdifyRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll();
         Task<IEnumerable<User>> GetUsers();
         Task<User> GetUser(int id);
    }
}