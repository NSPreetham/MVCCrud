using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCrud.CrudServices
{
    public class CompanyCRUD : ICompanyCRUD
    {
        ModelCompanies dbModel = new ModelCompanies();
        public List<Directory> ReadCompanies()
        {
            var Comp = from C in dbModel.Directories select C;
            List<Directory> lstDir = Comp.ToList();
            return lstDir;
        }

        public void CreateCompany(Directory Company)
        {

        }

        public void DeleteCompany(int id)
        {

        }

        public void UpdateCompany(int id)
        {

        }
    }
}