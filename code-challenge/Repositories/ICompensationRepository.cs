using challenge.Models;
using System;
using System.Threading.Tasks;

namespace challenge.Repositories
{
    public interface ICompensationRepository
    {
        Employee GetById(String id);
        Employee Add(Compensation compensation);
        Employee Remove(Compensation compensation);
        Task SaveAsync();
    }
}