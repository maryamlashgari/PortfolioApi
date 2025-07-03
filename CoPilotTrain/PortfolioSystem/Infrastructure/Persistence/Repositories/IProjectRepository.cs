using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
    public interface IProjectRepository
    {
        Task AddAsync(Project project);
        // Other methods...
    }

}
