using System.Collections.Generic;
using onevote.Models;

namespace onevote.Repositories
{
    public interface IElectionRepository
    {
        Election GetByID(int id);
    }
}