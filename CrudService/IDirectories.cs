using System;
using System.Collections.Generic;
using System.Text;


namespace CrudService
{
    public interface IDirectories
    {
        List<Directory> ReadCompanies();

        void CreateCompany(Directory Company);

        void DeleteCompany(int id);

        void UpdateCompany(int id);

    }
}
