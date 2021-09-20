using Entities.Models;
using System.Collections.Generic;

namespace Contracts.Abstract
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetAllCompanies(bool trackChanges);

    }
}
