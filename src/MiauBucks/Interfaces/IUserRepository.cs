using MiauBucks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiauBucks.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> All { get; }
        User Find(int id);
        User FindByUser(int id);
        void Insert(User item);
        void Update(User item);
        void Delete(int id);
    }
}
