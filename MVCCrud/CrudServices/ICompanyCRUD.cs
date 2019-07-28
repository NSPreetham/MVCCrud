using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCrud.CrudServices
{
    interface ICompanyCRUD
    {
            
        List<Directory> ReadCompanies();

        void CreateCompany(Directory Company);

        void DeleteCompany(int id);

        void UpdateCompany(int id);    

    }
}
